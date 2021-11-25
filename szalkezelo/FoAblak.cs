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
            fillRaktarTable();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void TsmKilepes_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void fillRaktarTable()
        {
            string query = "SELECT tipus.nev, anyag.nev, meret.nev, anyagminoseg.nev, raktar.db, raktar.hossz " +
                "FROM raktar " +
                "INNER JOIN szalanyag ON raktar.szalanyag_id = szalanyag.id " +
                "INNER JOIN meret ON szalanyag.meret_id = meret.id " +
                "INNER JOIN anyag ON szalanyag.anyag_id = anyag.id " +
                "INNER JOIN anyagminoseg ON szalanyag.anyagminoseg_id = anyagminoseg.id " +
                "INNER JOIN tipus ON szalanyag.tipus_id = tipus.id ;";

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
                            dgwRaktar.Rows.Add(string.Format("{0} ({1}, {2}, {3})", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)), reader.GetInt32(4), reader.GetInt32(5));
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

        private void TsmRendeles_Click(object sender, EventArgs e)
        {

        }

        private void TsmBevetelezes_Click(object sender, EventArgs e)
        {
            Bevetelezes bev = new Bevetelezes();

            bev.ShowDialog();

            fillRaktarTable();
        }

        private void TsmSzalanyag_Click(object sender, System.EventArgs e)
        {
            SzalanyagInput si = new SzalanyagInput();

            si.ShowDialog();
        }

        private void TsmMeret_Click(object sender, EventArgs e)
        {
            SimpleNameInput sni = new SimpleNameInput("meret");

            sni.ShowDialog();
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
            SimpleNameInput sni = new SimpleNameInput("tipus");

            sni.ShowDialog();
        }
    }
}
