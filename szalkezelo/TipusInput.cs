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
    public partial class TipusInput : BaseForm
    {
        public TipusInput()
        {
            InitializeComponent();
        }

        private void SimpleInput_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            if (txtNev.Text == "")
            {
                MessageBox.Show("Rossz bemeneti adatok!");
                return;
            }

            try
            {
                openConnection();

                string readquery = string.Format("SELECT id FROM tipus WHERE nev = '{0}';", txtNev.Text);
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
                    string insertquery = string.Format("INSERT INTO tipus(nev, kellSzelesseg, kellMagassag, kellVastagsag, kellAtmero) " +
                                    "VALUES(N'" + txtNev.Text + "', {0}, {1}, {2}, {3});", chkKellSzelesseg.Checked ? 1 : 0, chkKellMagassag.Checked ? 1 : 0, chkKellVastagsag.Checked ? 1 : 0, chkKellAtmero.Checked ? 1 : 0);

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
                string query = "SELECT nev, kellSzelesseg, kellMagassag, kellVastagsag, kellAtmero FROM tipus;";

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgwInput.Rows.Clear();
                        while (reader.Read())
                        {
                            dgwInput.Rows.Add(reader.GetString(0), reader.GetBoolean(1), reader.GetBoolean(2), reader.GetBoolean(3), reader.GetBoolean(4));
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

        private void chkKellAtmero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKellAtmero.Checked)
            {
                chkKellSzelesseg.Checked = false;
                chkKellMagassag.Checked = false;
                chkKellVastagsag.Checked = false;
                chkKellAtmero.Checked = true;
            }
        }

        private void chkKellSzelesseg_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKellSzelesseg.Checked || chkKellMagassag.Checked || chkKellVastagsag.Checked)
            {
                chkKellAtmero.Checked = false;
            }

            if (chkKellSzelesseg.Checked)
                chkKellMagassag.Checked = true;
            else
            {
                chkKellMagassag.Checked = false;
                chkKellVastagsag.Checked = false;
            }
        }

        private void chkKellMagassag_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKellSzelesseg.Checked || chkKellMagassag.Checked || chkKellVastagsag.Checked)
            {
                chkKellAtmero.Checked = false;
            }

            if (chkKellMagassag.Checked)
                chkKellSzelesseg.Checked = true;
            else
            {
                chkKellSzelesseg.Checked = false;
                chkKellVastagsag.Checked = false;
            }
        }

        private void chkKellVastagsag_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKellSzelesseg.Checked || chkKellMagassag.Checked || chkKellVastagsag.Checked)
            {
                chkKellAtmero.Checked = false;
            }

            if (chkKellVastagsag.Checked)
            {
                chkKellSzelesseg.Checked = true;
                chkKellMagassag.Checked = true;
            }
            else
            {
                chkKellSzelesseg.Checked = false;
                chkKellMagassag.Checked = false;
            }
        }
    }
}
