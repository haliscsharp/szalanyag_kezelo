using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace szalkezelo
{
    public struct vagas
    {
        public int db;
        public int hossz;
        public bool feluletkezeles;
        public int szalanyag_id;
    }

    public partial class Rendeles : BaseForm
    {

        List<vagas> vagaslistaFelvetel;

        public Rendeles()
        {
            InitializeComponent();
        }

        public void addVagas(vagas vagat, string szalanyagNev)
        {
            vagaslistaFelvetel.Add(vagat);
            lbVagaslista.Items.Add(string.Format("{0} x {1}mm x {2}; {3}", vagat.db, vagat.hossz, szalanyagNev, (vagat.feluletkezeles?"felületkezelés":"")));
        }

        private void Rendeles_Load(object sender, EventArgs e)
        {
            fillTable();

            vagaslistaFelvetel = new List<vagas>();
        }

        private void fillTable()
        {
            try
            {
                string filters = "";

                if (txtSzuroNev.Text != "")
                {
                    filters += string.Format(" r.beszallito_nev  like '%{0}%'", txtSzuroNev.Text);
                }

                if (chkSzuroDatumTol.Checked)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += string.Format(" r.datum >= '{0}-{1}-{2} {3}:{4}'", dtpSzuroTol.Value.Year, dtpSzuroTol.Value.Month, dtpSzuroTol.Value.Day, dtpSzuroTol.Value.Hour, dtpSzuroTol.Value.Minute);
                }

                if (chkSzuroDatumIg.Checked)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += string.Format(" r.datum <= '{0}-{1}-{2} {3}:{4}'", dtpSzuroIg.Value.Year, dtpSzuroIg.Value.Month, dtpSzuroIg.Value.Day, dtpSzuroIg.Value.Hour, dtpSzuroIg.Value.Minute);
                }

                if (chkSzuroTeljesitett.Checked && !chkSzuroNemTeljesitett.Checked)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += string.Format(" r.teljesitett = 1");
                }

                if (chkSzuroNemTeljesitett.Checked && !chkSzuroTeljesitett.Checked)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += string.Format(" r.teljesitett = 0");
                }

                string query = string.Format("SELECT r.teljesitett, r.rendelo_nev, r.datum, r.surgosseg " +
                    "FROM rendeles as r " + (filters.Length > 0 ? "WHERE " + filters : "") + ";");

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgwRendeles.Rows.Clear();
                        while (reader.Read())
                        {
                            dgwRendeles.Rows.Add(reader.GetBoolean(0), reader.GetString(1), reader.GetDateTime(2), reader.GetInt32(3));
                        }
                    }
                }

                dgwRendeles.Rows[0].Cells[4].Value = "Halis\nCodos és mellé egy nagyon hosszú szöveg\nKowa";
                // string.Format("{0} x {1} x {2}", reader.GetInt32(4), reader.GetInt32(5), string.Format("{0} ({1}, {2}, {3})", reader.GetString(6), reader.GetString(7), reader.GetString(8), m.getNev()))

                // Meret m = new Meret(reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11), reader.GetInt32(12));

                //"INNER JOIN vagaslista as v ON v.rendeles_id = r.id " +
                //"INNER JOIN szalanyag ON v.szalanyag_id = szalanyag.id " +
                //"INNER JOIN meret ON szalanyag.meret_id = meret.id " +
                //"INNER JOIN anyag ON szalanyag.anyag_id = anyag.id " +
                //"INNER JOIN anyagminoseg ON szalanyag.anyagminoseg_id = anyagminoseg.id " +
                //"INNER JOIN tipus ON szalanyag.tipus_id = tipus.id "

            }
            catch (Exception e)
            {
                MessageBox.Show("Hiba történt a tábla frissítése során!\n\n" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            if (txtNev.Text == "" || lbVagaslista.Items.Count <= 0)
            {
                MessageBox.Show("Rossz bemeneti adatok!");
                return;
            }

            try
            {
                int rendelesId = -1;

                string insertquery = string.Format("INSERT INTO rendeles(rendelo_nev, datum, surgosseg, teljesitett) VALUES('{0}', '{1}', {2}, {3});",
                    txtNev.Text,
                    string.Format("{0}-{1}-{2} {3}:{4}", dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpDate.Value.Hour, dtpDate.Value.Minute),
                    nudSurgosseg.Value,
                    "0");

                openConnection();

                using (SqlCommand insertCommand = new SqlCommand(insertquery, conn))
                {
                    rendelesId = Convert.ToInt32(insertCommand.ExecuteScalar());

                    conn.Close();

                    txtNev.Text = "";
                    dtpDate.Value = DateTime.Now;
                    nudSurgosseg.Value = 1;
                    lbVagaslista.Items.Clear();
                    vagaslistaFelvetel.Clear();

                    fillTable();
                }

                MessageBox.Show(rendelesId.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatbeszúrás közben!\n\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUjVagas_Click(object sender, EventArgs e)
        {
            VagaslistaInput vi = new VagaslistaInput();

            vi.ShowDialog(this);
        }

        private void btnVagasEltavolitasa_Click(object sender, EventArgs e)
        {
            if (lbVagaslista.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Biztosan eltávolítja?\n\n" + lbVagaslista.SelectedItem.ToString(), "Vágás törlése", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vagaslistaFelvetel.RemoveAt(lbVagaslista.SelectedIndex);
                    lbVagaslista.Items.RemoveAt(lbVagaslista.SelectedIndex);
                }
            }
        }

        private void TeljesitettSzuro_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSzuroTeljesitett.Checked && !chkSzuroNemTeljesitett.Checked)
            {
                MessageBox.Show("Legalább az egyik teljesített szűrőnek aktívnak kell lennie!");
                chkSzuroNemTeljesitett.Checked = true;
            }
        }

        private void btnSzuro_Click(object sender, EventArgs e)
        {
            fillTable();
        }
    }
}
