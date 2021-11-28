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
            fillCbSzuroMeret();
            fillCbAnyag();
            fillCbMinoseg();
            fillCbTipus();
        }

        private void fillCbSzuroMeret()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nev");

            try
            {
                string query = "SELECT id, szelesseg, magassag, vastagsag, atmero FROM meret;";

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Rows.Clear();
                        dt.Rows.Add(-1, "<üres>");

                        while (reader.Read())
                        {
                            Meret m = new Meret(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4));
                            dt.Rows.Add(reader.GetInt32(0), m.getNev());
                        }
                    }
                }

                cbSzuroMeret.SelectedIndexChanged -= Szuro_SelectedIndexChanged;

                cbSzuroMeret.DataSource = dt;
                cbSzuroMeret.ValueMember = "id";
                cbSzuroMeret.DisplayMember = "nev";

                cbSzuroMeret.SelectedIndexChanged += Szuro_SelectedIndexChanged;
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

        private void fillCbMeret()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nev");

            try
            {
                bool[] sizeFilters = new bool[4];

                for (int i = 0; i < sizeFilters.Length; i++)
                {
                    sizeFilters[i] = true;
                }

                if (cbTipus.SelectedValue != null && int.Parse(cbTipus.SelectedValue.ToString()) != -1)
                {
                    string query = string.Format("SELECT kellSzelesseg, kellMagassag, kellVastagsag, kellAtmero FROM tipus " +
                           "WHERE id = {0};", cbTipus.SelectedValue);

                    openConnection();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            sizeFilters[0] = reader.GetBoolean(0);
                            sizeFilters[1] = reader.GetBoolean(1);
                            sizeFilters[2] = reader.GetBoolean(2);
                            sizeFilters[3] = reader.GetBoolean(3);
                        }
                    }
                }
                string readquery = "SELECT id, szelesseg, magassag, vastagsag, atmero FROM meret ;";

                openConnection();
                using (SqlCommand command = new SqlCommand(readquery, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Rows.Clear();
                        dt.Rows.Add(-1, "<üres>");

                        while (reader.Read())
                        {
                            Meret m = new Meret(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4));
                            
                            bool matchingRequirements = true;
                            if ((sizeFilters[0] && m.getSzelesseg() == 0) || (!sizeFilters[0] && m.getSzelesseg() != 0))
                                matchingRequirements = false;
                            if ((sizeFilters[1] && m.getMagassag() == 0) || (!sizeFilters[1] && m.getMagassag() != 0))
                                matchingRequirements = false;
                            if ((sizeFilters[2] && m.getVastagsag() == 0) || (!sizeFilters[2] && m.getVastagsag() != 0))
                                matchingRequirements = false;
                            if ((sizeFilters[3] && m.getAtmero() == 0) || (!sizeFilters[3] && m.getAtmero() != 0))
                                matchingRequirements = false;

                            if (matchingRequirements)
                                dt.Rows.Add(reader.GetInt32(0), m.getNev());
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
            DataTable dt2 = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nev");

            dt2.Columns.Add("id");
            dt2.Columns.Add("nev");

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
                        dt2.Rows.Clear();
                        dt2.Rows.Add(-1, "<üres>");

                        while (reader.Read())
                        {
                            dt.Rows.Add(reader.GetInt32(0), string.Format("{0} ({1})", reader.GetString(1), reader.GetString(2)));
                            dt2.Rows.Add(reader.GetInt32(0), string.Format("{0} ({1})", reader.GetString(1), reader.GetString(2)));
                        }
                    }
                }

                cbSzuroAnyag.SelectedIndexChanged -= Szuro_SelectedIndexChanged;

                cbAnyag.DataSource = dt;
                cbAnyag.ValueMember = "id";
                cbAnyag.DisplayMember = "nev";

                cbSzuroAnyag.DataSource = dt2;
                cbSzuroAnyag.ValueMember = "id";
                cbSzuroAnyag.DisplayMember = "nev";

                cbSzuroAnyag.SelectedIndexChanged += Szuro_SelectedIndexChanged;
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
            DataTable dt2 = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nev");

            dt2.Columns.Add("id");
            dt2.Columns.Add("nev");

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
                        dt2.Rows.Clear();
                        dt2.Rows.Add(-1, "<üres>");

                        while (reader.Read())
                        {
                            dt.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                            dt2.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                }

                cbSzuroMinoseg.SelectedIndexChanged -= Szuro_SelectedIndexChanged;

                cbMinoseg.DataSource = dt;
                cbMinoseg.ValueMember = "id";
                cbMinoseg.DisplayMember = "nev";

                cbSzuroMinoseg.DataSource = dt2;
                cbSzuroMinoseg.ValueMember = "id";
                cbSzuroMinoseg.DisplayMember = "nev";

                cbSzuroMinoseg.SelectedIndexChanged += Szuro_SelectedIndexChanged;
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
            DataTable dt2 = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nev");

            dt2.Columns.Add("id");
            dt2.Columns.Add("nev");

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
                        dt2.Rows.Clear();
                        dt2.Rows.Add(-1, "<üres>");

                        while (reader.Read())
                        {
                            dt.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                            dt2.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                }

                cbSzuroTipus.SelectedIndexChanged -= Szuro_SelectedIndexChanged;
                cbTipus.SelectedIndexChanged -= cbTipus_SelectedIndexChanged;

                cbTipus.DataSource = dt;
                cbTipus.ValueMember = "id";
                cbTipus.DisplayMember = "nev";

                cbSzuroTipus.DataSource = dt2;
                cbSzuroTipus.ValueMember = "id";
                cbSzuroTipus.DisplayMember = "nev";

                cbSzuroTipus.SelectedIndexChanged += Szuro_SelectedIndexChanged;
                cbTipus.SelectedIndexChanged += cbTipus_SelectedIndexChanged;
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
                string filters = "";

                if (cbSzuroMeret.Items.Count > 0 && int.Parse(cbSzuroMeret.SelectedValue.ToString()) != -1)
                {
                    filters += string.Format(" meret.id = {0}", cbSzuroMeret.SelectedValue);
                }

                if (cbSzuroAnyag.Items.Count > 0 && int.Parse(cbSzuroAnyag.SelectedValue.ToString()) != -1)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += " anyag.id = " + cbSzuroAnyag.SelectedValue;
                }

                if (cbSzuroMinoseg.Items.Count > 0 && int.Parse(cbSzuroMinoseg.SelectedValue.ToString()) != -1)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += " anyagminoseg.id = " + cbSzuroMinoseg.SelectedValue;
                }

                if (cbSzuroTipus.Items.Count > 0 && int.Parse(cbSzuroTipus.SelectedValue.ToString()) != -1)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += " tipus.id = " + cbSzuroTipus.SelectedValue;
                }

                string query = string.Format("SELECT meret.szelesseg, meret.magassag, meret.vastagsag, meret.atmero, anyag.nev, anyag.rovid, anyagminoseg.nev, tipus.nev " +
                    "FROM szalanyag " +
                    "INNER JOIN meret ON szalanyag.meret_id = meret.id " +
                    "INNER JOIN anyag ON szalanyag.anyag_id = anyag.id " +
                    "INNER JOIN anyagminoseg ON szalanyag.anyagminoseg_id = anyagminoseg.id " +
                    "INNER JOIN tipus ON szalanyag.tipus_id = tipus.id " + (filters.Length > 0 ? "WHERE " + filters : "") + ";");

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgwSzalanyag.Rows.Clear();
                        while (reader.Read())
                        {
                            Meret m = new Meret(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                            dgwSzalanyag.Rows.Add(m.getNev(), string.Format("{0} ({1})", reader.GetString(4), reader.GetString(5)), reader.GetString(6), reader.GetString(7));
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

        private void Szuro_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTable();
        }

        private void cbTipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cbTipus.SelectedValue.ToString()) != -1)
                fillCbMeret();
        }
    }
}
