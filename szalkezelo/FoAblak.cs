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
    public partial class FoAblak : BaseForm
    {
        public FoAblak()
        {
            InitializeComponent();

            this.tsmKilepes.Click += TsmKilepes_Click;
            this.tsmRendeles.Click += TsmRendeles_Click;
            this.tsmBevetelezes.Click += TsmBevetelezes_Click;
            this.tsmSzalanyag.Click += TsmSzalanyag_Click;

            this.tsmMeret.Click += TsmMeret_Click;
            this.tsmAnyag.Click += TsmAnyag_Click;
            this.tsmMinoseg.Click += TsmMinoseg_Click;
            this.tsmTipus.Click += TsmTipus_Click;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            fillTable();

            fillCbSzalanyag();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void fillTable()
        {
            string filters = "";

            if (cbSzuroSzalanyag.Items.Count > 0 && int.Parse(cbSzuroSzalanyag.SelectedValue.ToString()) != -1)
            {
                filters = "WHERE szalanyag.id = " + cbSzuroSzalanyag.SelectedValue;
            }

            string query = "SELECT tipus.nev, anyag.nev, meret.szelesseg, meret.magassag, meret.vastagsag, meret.atmero, anyagminoseg.nev, raktar.db, raktar.hossz " +
                "FROM raktar " +
                "INNER JOIN szalanyag ON raktar.szalanyag_id = szalanyag.id " +
                "INNER JOIN meret ON szalanyag.meret_id = meret.id " +
                "INNER JOIN anyag ON szalanyag.anyag_id = anyag.id " +
                "INNER JOIN anyagminoseg ON szalanyag.anyagminoseg_id = anyagminoseg.id " +
                "INNER JOIN tipus ON szalanyag.tipus_id = tipus.id " + filters + ";";
            
            try
            {
                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgwRaktar.Rows.Clear();
                        while (reader.Read())
                        {
                            Meret m = new Meret(reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5));
                            dgwRaktar.Rows.Add(string.Format("{0} ({1}, {2}, {3})", reader.GetString(0), reader.GetString(1), m.getNev(), reader.GetString(6)), reader.GetInt32(7), reader.GetInt32(8));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hiba történt a tábla frissítése során!\n\n"+e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void fillCbSzalanyag()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nev");

            try
            {
                string query = string.Format("SELECT szalanyag.id ,tipus.nev, anyag.rovid, anyagminoseg.nev, meret.szelesseg, meret.magassag, meret.vastagsag, meret.atmero " +
                    "FROM szalanyag " +
                    "INNER JOIN meret ON szalanyag.meret_id = meret.id " +
                    "INNER JOIN anyag ON szalanyag.anyag_id = anyag.id " +
                    "INNER JOIN anyagminoseg ON szalanyag.anyagminoseg_id = anyagminoseg.id " +
                    "INNER JOIN tipus ON szalanyag.tipus_id = tipus.id ;");

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Rows.Clear();
                        dt.Rows.Add(-1, "<üres>");

                        while (reader.Read())
                        {
                            Meret m = new Meret(reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7));
                            dt.Rows.Add(reader.GetInt32(0), string.Format("{0} ({1}, {2}, {3})", reader.GetString(1), reader.GetString(2), reader.GetString(3), m.getNev()));
                        }
                    }
                }

                cbSzuroSzalanyag.SelectedIndexChanged -= CbSzuroSzalanyag_SelectedIndexChanged;

                cbSzuroSzalanyag.DataSource = dt;
                cbSzuroSzalanyag.ValueMember = "id";
                cbSzuroSzalanyag.DisplayMember = "nev";

                cbSzuroSzalanyag.SelectedIndexChanged += CbSzuroSzalanyag_SelectedIndexChanged;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hiba történt a szálanyag lista frissítése során!\n\n" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CbSzuroSzalanyag_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTable();
        }

        private void TsmKilepes_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void TsmRendeles_Click(object sender, EventArgs e)
        {
            Rendeles re = new Rendeles();

            re.ShowDialog();
        }

        private void TsmBevetelezes_Click(object sender, EventArgs e)
        {
            Bevetelezes bev = new Bevetelezes();

            bev.ShowDialog();

            fillTable();
        }

        private void TsmSzalanyag_Click(object sender, System.EventArgs e)
        {
            SzalanyagInput si = new SzalanyagInput();

            si.ShowDialog();

            fillCbSzalanyag();
        }

        private void TsmMeret_Click(object sender, EventArgs e)
        {
            MeretInput mi = new MeretInput();

            mi.ShowDialog();
        }

        private void TsmAnyag_Click(object sender, EventArgs e)
        {
            AnyagInput ai = new AnyagInput();

            ai.ShowDialog();
        }

        private void TsmMinoseg_Click(object sender, EventArgs e)
        {
            SimpleNameInput sni = new SimpleNameInput("anyagminoseg");

            sni.ShowDialog();
        }

        private void TsmTipus_Click(object sender, EventArgs e)
        {
            TipusInput ti = new TipusInput();

            ti.ShowDialog();
        }
    }
}
