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
    public partial class Bevetelezes : BaseForm
    {
        public Bevetelezes()
        {
            InitializeComponent();
        }

        private void Bevetelezes_Load(object sender, EventArgs e)
        {
            fillTable();

            fillCbSzalanyag();
        }

        private void fillTable()
        {
            try
            {
                string filters = "";

                if (txtSzuroNev.Text != "")
                {
                    filters += string.Format(" b.beszallito_nev  like '%{0}%'", txtSzuroNev.Text);
                }

                if (cbSzuroSzalanyag.Items.Count > 0 && int.Parse(cbSzuroSzalanyag.SelectedValue.ToString()) != -1)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += " szalanyag.id = " + cbSzuroSzalanyag.SelectedValue;
                }

                if (chkSzuroDatumTol.Checked)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += string.Format(" b.datum >= '{0}-{1}-{2} {3}:{4}'", dtpSzuroTol.Value.Year, dtpSzuroTol.Value.Month, dtpSzuroTol.Value.Day, dtpSzuroTol.Value.Hour, dtpSzuroTol.Value.Minute);
                }

                if (chkSzuroDatumIg.Checked)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += string.Format(" b.datum <= '{0}-{1}-{2} {3}:{4}'", dtpSzuroIg.Value.Year, dtpSzuroIg.Value.Month, dtpSzuroIg.Value.Day, dtpSzuroIg.Value.Hour, dtpSzuroIg.Value.Minute);
                }

                string query = string.Format("SELECT b.beszallito_nev, b.datum, b.db, b.hossz, tipus.nev, anyag.rovid, anyagminoseg.nev, meret.szelesseg, meret.magassag, meret.vastagsag, meret.atmero " +
                    "FROM bevetelezes as b " +
                    "INNER JOIN szalanyag ON b.szalanyag_id = szalanyag.id " +
                    "INNER JOIN meret ON szalanyag.meret_id = meret.id " +
                    "INNER JOIN anyag ON szalanyag.anyag_id = anyag.id " +
                    "INNER JOIN anyagminoseg ON szalanyag.anyagminoseg_id = anyagminoseg.id " +
                    "INNER JOIN tipus ON szalanyag.tipus_id = tipus.id " + (filters.Length > 0 ? "WHERE " + filters : "") + ";");

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgwBevetelezes.Rows.Clear();
                        while (reader.Read())
                        {
                            Meret m = new Meret(reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10));
                            dgwBevetelezes.Rows.Add(reader.GetString(0), reader.GetDateTime(1), reader.GetInt32(2), reader.GetInt32(3), string.Format("{0} ({1}, {2}, {3})", reader.GetString(4), reader.GetString(5), reader.GetString(6), m.getNev()));
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

        private void fillCbSzalanyag()
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nev");
            dt2.Columns.Add("id");
            dt2.Columns.Add("nev");

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
                        dt2.Rows.Clear();
                        dt2.Rows.Add(-1, "<üres>");

                        while (reader.Read())
                        {
                            Meret m = new Meret(reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7));
                            dt.Rows.Add(reader.GetInt32(0), string.Format("{0} ({1}, {2}, {3})", reader.GetString(1), reader.GetString(2), reader.GetString(3), m.getNev()));
                            dt2.Rows.Add(reader.GetInt32(0), string.Format("{0} ({1}, {2}, {3})", reader.GetString(1), reader.GetString(2), reader.GetString(3), m.getNev()));
                        }
                    }
                }

                cbSzuroSzalanyag.SelectedIndexChanged -= CbSzuroSzalanyag_SelectedIndexChanged;

                cbSzalanyag.DataSource = dt;
                cbSzalanyag.ValueMember = "id";
                cbSzalanyag.DisplayMember = "nev";

                cbSzuroSzalanyag.DataSource = dt2;
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

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            try
            {
                openConnection();

                string readquery = string.Format("SELECT raktar.id, raktar.db, raktar.hossz, raktar.szalanyag_id " +
                    "FROM raktar " +
                    "WHERE raktar.szalanyag_id = {0} AND raktar.hossz = {1};", cbSzalanyag.SelectedValue, nudHossz.Value);
                
                Dictionary<string, int> storageData = new Dictionary<string, int>(4);

                bool alreadyExists = true;

                using (SqlCommand readCommand = new SqlCommand(readquery, conn))
                {
                    using (SqlDataReader reader = readCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            storageData["id"] = reader.GetInt32(0);
                            storageData["db"] = reader.GetInt32(1);
                            storageData["hossz"] = reader.GetInt32(2);
                            storageData["szalanyag_id"] = reader.GetInt32(3);
                        }
                        else
                        {
                            alreadyExists = false;
                        }
                    }
                }

                string insertquery;

                if (alreadyExists)
                {
                    insertquery = string.Format("UPDATE raktar SET db = {0} WHERE id = {1};",
                        nudDb.Value + storageData["db"],
                        storageData["id"]);

                    using (SqlCommand insertCommand = new SqlCommand(insertquery, conn))
                    {
                        int result = insertCommand.ExecuteNonQuery();

                        if (result < 0)
                        {
                            MessageBox.Show("Hiba adatmódosítás közben!");
                        }
                    }
                }
                else
                {
                    insertquery = string.Format("INSERT INTO raktar(db, hossz, szalanyag_id) VALUES({0}, {1}, {2});",
                        nudDb.Value,
                        nudHossz.Value,
                        cbSzalanyag.SelectedValue);

                    using (SqlCommand insertCommand = new SqlCommand(insertquery, conn))
                    {
                        int result = insertCommand.ExecuteNonQuery();

                        if (result < 0)
                        {
                            MessageBox.Show("Hiba adatbeszúrás közben!");
                        }
                    }
                }

                insertquery = string.Format("INSERT INTO bevetelezes(beszallito_nev, db, datum, hossz, szalanyag_id) VALUES('{0}', {1}, '{2}', {3}, {4});", 
                    txtNev.Text, 
                    nudDb.Value, 
                    string.Format("{0}-{1}-{2} {3}:{4}", dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpDate.Value.Hour, dtpDate.Value.Minute), 
                    nudHossz.Value,
                    cbSzalanyag.SelectedValue);

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

                        txtNev.Text = "";
                        nudDb.Value = 0;
                        dtpDate.Value = DateTime.Now;
                        nudHossz.Value = 0;
                        cbSzalanyag.SelectedIndex = 0;

                        fillTable();
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

        private void btnUjSzalanyag_Click(object sender, EventArgs e)
        {
            SzalanyagInput si = new SzalanyagInput();

            si.ShowDialog();

            fillCbSzalanyag();
        }

        private void CbSzuroSzalanyag_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTable();
        }

        private void txtSzuroNev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter
            {
                fillTable();
            }
        }

        private void btnSzuro_Click(object sender, EventArgs e)
        {
            fillTable();
        }

        private void cbSzuroDatumTol_CheckedChanged(object sender, EventArgs e)
        {
            dtpSzuroTol.Enabled = !dtpSzuroTol.Enabled;
        }

        private void cbSzuroDatumIg_CheckedChanged(object sender, EventArgs e)
        {
            dtpSzuroIg.Enabled = !dtpSzuroIg.Enabled;
        }
    }
}
