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

                string query = string.Format("SELECT r.id, r.teljesitett, r.rendelo_nev, r.datum, r.surgosseg " +
                    "FROM rendeles as r " + (filters.Length > 0 ? "WHERE " + filters : "") + ";");

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgwRendeles.Rows.Clear();
                        while (reader.Read())
                        {
                            dgwRendeles.Rows.Add(reader.GetInt32(0), reader.GetBoolean(1), reader.GetString(2), reader.GetDateTime(3), reader.GetInt32(4));
                        }
                    }
                }

                for (int i = 0; i < dgwRendeles.Rows.Count; i++)
                {
                    int rendeles_id = Convert.ToInt32(dgwRendeles.Rows[i].Cells[0].Value.ToString());

                    query = string.Format("SELECT v.db, v.hossz, v.feluletkezeles, tipus.nev, anyag.rovid, anyagminoseg.nev, meret.szelesseg, meret.magassag, meret.vastagsag, meret.atmero " +
                        "FROM vagaslista as v " +
                        "INNER JOIN szalanyag ON v.szalanyag_id = szalanyag.id " +
                        "INNER JOIN meret ON szalanyag.meret_id = meret.id " +
                        "INNER JOIN anyag ON szalanyag.anyag_id = anyag.id " +
                        "INNER JOIN anyagminoseg ON szalanyag.anyagminoseg_id = anyagminoseg.id " +
                        "INNER JOIN tipus ON szalanyag.tipus_id = tipus.id " +
                        "WHERE v.rendeles_id = {0};", rendeles_id);

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Meret m = new Meret(reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9));
                                dgwRendeles.Rows[i].Cells[5].Value += string.Format("- {0} x {1} x {2} {3}\n", 
                                    reader.GetInt32(0), 
                                    reader.GetInt32(1), 
                                    string.Format("{0} ({1}, {2}, {3})", reader.GetString(3), reader.GetString(4), reader.GetString(5), m.getNev()),
                                    (reader.GetBoolean(2)?"+ felületkezelés":""));
                            }
                        }
                    }
                }

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

                string insertquery = string.Format("INSERT INTO rendeles(rendelo_nev, datum, surgosseg, teljesitett) VALUES('{0}', '{1}', {2}, {3});" +
                    " SELECT CAST(scope_identity() AS int)",
                    txtNev.Text,
                    string.Format("{0}-{1}-{2} {3}:{4}", dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpDate.Value.Hour, dtpDate.Value.Minute),
                    nudSurgosseg.Value,
                    "0");

                openConnection();

                using (SqlCommand insertCommand = new SqlCommand(insertquery, conn))
                {
                    rendelesId = Convert.ToInt32(insertCommand.ExecuteScalar());
                }

                int succesfulInserts = 0;

                for (int i = 0; i < vagaslistaFelvetel.Count; i++)
                {
                    insertquery = string.Format("INSERT INTO vagaslista(db, hossz, feluletkezeles, szalanyag_id, rendeles_id) VALUES({0}, {1}, {2}, {3}, {4});",
                        vagaslistaFelvetel[i].db,
                        vagaslistaFelvetel[i].hossz,
                        vagaslistaFelvetel[i].feluletkezeles ? 1 : 0,
                        vagaslistaFelvetel[i].szalanyag_id,
                        rendelesId);

                    using (SqlCommand insertCommand = new SqlCommand(insertquery, conn))
                    {
                        int result = insertCommand.ExecuteNonQuery();

                        if (result >= 0)
                            succesfulInserts++;
                    }
                }

                if (succesfulInserts != vagaslistaFelvetel.Count)
                    MessageBox.Show("Hiba történt az adatbeszúrás közben (vágáslista)!");


                conn.Close();

                txtNev.Text = "";
                dtpDate.Value = DateTime.Now;
                nudSurgosseg.Value = 1;
                lbVagaslista.Items.Clear();
                vagaslistaFelvetel.Clear();

                fillTable();
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

        private void btnRendelesTorles_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dgwRendeles.SelectedRows[0].Cells[1].Value) == true)
            {
                MessageBox.Show("Csak olyan rendelést lehet törölni, amely még nem volt teljesítve!");
                return;
            }

            if (MessageBox.Show("Biztosan törli a kiválasztott rendelést?", "Rendelés törlése", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int rendeles_id = Convert.ToInt32(dgwRendeles.SelectedRows[0].Cells[0].Value.ToString());
            try
            {
                string deletequery = string.Format("DELETE FROM rendeles " +
                    "WHERE id = {0};", rendeles_id);

                bool successful = true;
                openConnection();
                using (SqlCommand insertCommand = new SqlCommand(deletequery, conn))
                {
                    int result = insertCommand.ExecuteNonQuery();

                    if (result < 0)
                        successful = false;
                }

                if (successful)
                {
                    deletequery = string.Format("DELETE FROM vagaslista " +
                    "WHERE rendeles_id = {0};", rendeles_id);

                    using (SqlCommand insertCommand = new SqlCommand(deletequery, conn))
                    {
                        int result = insertCommand.ExecuteNonQuery();

                        if (result < 0)
                            successful = false;
                    }

                    if (successful)
                        MessageBox.Show("Sikeres törlés!");
                    else
                        MessageBox.Show("Sikertelen törlés!");

                    fillTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a törlés közben!\n\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRendelesTeljesites_Click(object sender, EventArgs e)
        {
            
        }
    }
}
