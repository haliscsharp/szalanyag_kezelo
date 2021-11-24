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
    public partial class SzalanyagInput : BaseForm
    {
        public SzalanyagInput()
        {
            InitializeComponent();
        }

        private void SimpleInput_Load(object sender, EventArgs e)
        {
            fillTable();
            fillComboboxes();
        }

        private void fillComboboxes()
        {
            fillCbMeret();
            fillCbAnyag();
            fillCbMinoseg();
            fillCbTipus();
        }

        private void fillCbMeret()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nev");

            try
            {
                string query = "SELECT id, nev FROM meret;";

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Rows.Clear();
                        dt.Rows.Add(-1, "<üres>");

                        while (reader.Read())
                        {
                            dt.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                }

                cbMeret.DataSource = dt;
                cbMeret.ValueMember = "id";
                cbMeret.DisplayMember = "nev";
            }
            catch (Exception e)
            {
                MessageBox.Show("Hiba történt a méret lista frissítése során!\n\n" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void fillCbAnyag()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nev");

            try
            {
                string query = "SELECT id, nev, rovid FROM anyag;";

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Rows.Clear();
                        dt.Rows.Add(-1, "<üres>");

                        while (reader.Read())
                        {
                            dt.Rows.Add(reader.GetInt32(0), string.Format("{0} ({1})", reader.GetString(1), reader.GetString(2)));
                        }
                    }
                }

                cbAnyag.DataSource = dt;
                cbAnyag.ValueMember = "id";
                cbAnyag.DisplayMember = "nev";
            }
            catch (Exception e)
            {
                MessageBox.Show("Hiba történt az anyag lista frissítése során!\n\n" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void fillCbMinoseg()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nev");

            try
            {
                string query = "SELECT id, nev FROM anyagminoseg;";

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Rows.Clear();
                        dt.Rows.Add(-1, "<üres>");

                        while (reader.Read())
                        {
                            dt.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                }

                cbMinoseg.DataSource = dt;
                cbMinoseg.ValueMember = "id";
                cbMinoseg.DisplayMember = "nev";
            }
            catch (Exception e)
            {
                MessageBox.Show("Hiba történt az anyagminőség lista frissítése során!\n\n" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void fillCbTipus()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nev");

            try
            {
                string query = "SELECT id, nev FROM tipus;";

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Rows.Clear();
                        dt.Rows.Add(-1, "<üres>");

                        while (reader.Read())
                        {
                            dt.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                }

                cbTipus.DataSource = dt;
                cbTipus.ValueMember = "id";
                cbTipus.DisplayMember = "nev";
            }
            catch (Exception e)
            {
                MessageBox.Show("Hiba történt a típus lista frissítése során!\n\n" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            try
            {
                openConnection();

                string readquery = string.Format("SELECT id FROM szalanyag WHERE " +
                    "meret_id = (SELECT id FROM meret WHERE meret.id = {0}) " +
                    "AND anyag_id = (SELECT id FROM anyag WHERE anyag.id = {1}) " +
                    "AND anyagminoseg_id = (SELECT id FROM anyagminoseg WHERE anyagminoseg.id = {2}) " +
                    "AND tipus_id = (SELECT id FROM tipus WHERE tipus.id = {3});", cbMeret.SelectedValue, cbAnyag.SelectedValue, cbMinoseg.SelectedValue, cbTipus.SelectedValue);

                bool alreadyExists = true;

                using (SqlCommand readCommand = new SqlCommand(readquery, conn))
                {
                    using (SqlDataReader reader = readCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Már létezik bejegyzés a megadott névvel!");
                        }
                        else
                        {
                            alreadyExists = false;
                        }
                    }
                }

                if (!alreadyExists)
                {
                    string insertquery = string.Format("INSERT INTO szalanyag(meret_id, anyag_id, anyagminoseg_id, tipus_id) VALUES({0}, {1}, {2}, {3});", cbMeret.SelectedValue, cbAnyag.SelectedValue, cbMinoseg.SelectedValue, cbTipus.SelectedValue);

                    using (SqlCommand insertCommand = new SqlCommand(insertquery, conn))
                    {
                        int result = insertCommand.ExecuteNonQuery();

                        if (result < 0)
                        {
                            MessageBox.Show("Hiba adatbeszúrás közben!");
                        }
                        else
                        {
                            conn.Close();
                            cbMeret.SelectedIndex = 0;
                            cbAnyag.SelectedIndex = 0;
                            cbMinoseg.SelectedIndex = 0;
                            cbTipus.SelectedIndex = 0;
                            fillTable();
                        }
                    }
                }
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

        private void fillTable()
        {
            try
            {
                string query = string.Format("SELECT meret.nev, anyag.nev, anyag.rovid, anyagminoseg.nev, tipus.nev " +
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
                        dgwSzalanyag.Rows.Clear();
                        while (reader.Read())
                        {
                            dgwSzalanyag.Rows.Add(reader.GetString(0), string.Format("{0} ({1})", reader.GetString(1), reader.GetString(2)), reader.GetString(3), reader.GetString(4));
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

        private void btnUjMeret_Click(object sender, EventArgs e)
        {
            SimpleNameInput sni = new SimpleNameInput("meret");

            sni.ShowDialog();

            fillCbMeret();
        }

        private void btnUjAnyag_Click(object sender, EventArgs e)
        {
            AnyagInput ai = new AnyagInput();

            ai.ShowDialog();

            fillCbAnyag();
        }

        private void btnUjMinoseg_Click(object sender, EventArgs e)
        {
            SimpleNameInput sni = new SimpleNameInput("anyagminoseg");

            sni.ShowDialog();

            fillCbMinoseg();
        }

        private void btnUjTipus_Click(object sender, EventArgs e)
        {
            SimpleNameInput sni = new SimpleNameInput("tipus");

            sni.ShowDialog();

            fillCbTipus();
        }
    }
}
