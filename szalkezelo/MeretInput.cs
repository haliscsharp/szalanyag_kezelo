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
    public partial class MeretInput : BaseForm
    {
        public MeretInput()
        {
            InitializeComponent();
        }

        private void SimpleInput_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            try
            {
                openConnection();

                string readquery = string.Format("SELECT id FROM meret " +
                    "WHERE szelesseg = {0} " +
                    "AND magassag = {1} " +
                    "AND vastagsag = {2} " +
                    "AND atmero = {3};", nudSzelesseg.Value, nudMagassag.Value, nudVastagsag.Value, nudAtmero.Value);
                
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
                    string insertquery = string.Format("INSERT INTO meret(szelesseg, magassag, vastagsag, atmero) VALUES({0}, {1}, {2}, {3});", nudSzelesseg.Value, nudMagassag.Value, nudVastagsag.Value, nudAtmero.Value);

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
                            nudSzelesseg.Value = 0;
                            nudMagassag.Value = 0;
                            nudVastagsag.Value = 0;
                            nudAtmero.Value = 0;
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
                string query = "SELECT szelesseg, magassag, vastagsag, atmero FROM meret;";

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgwInput.Rows.Clear();
                        while (reader.Read())
                        {
                            dgwInput.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
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

        private void nudAtmero_ValueChanged(object sender, EventArgs e)
        {
            if (nudAtmero.Value != 0)
            {
                nudSzelesseg.Value = 0;
                nudMagassag.Value = 0;
                nudVastagsag.Value = 0;
            }
        }

        private void nudSzelesseg_ValueChanged(object sender, EventArgs e)
        {
            if (nudSzelesseg.Value != 0 || nudMagassag.Value != 0 || nudVastagsag.Value != 0)
            {
                nudAtmero.Value = 0;
            }
        }

        private void nudMagassag_ValueChanged(object sender, EventArgs e)
        {
            if (nudSzelesseg.Value != 0 || nudMagassag.Value != 0 || nudVastagsag.Value != 0)
            {
                nudAtmero.Value = 0;
            }
        }

        private void nudVastagsag_ValueChanged(object sender, EventArgs e)
        {
            if (nudSzelesseg.Value != 0 || nudMagassag.Value != 0 || nudVastagsag.Value != 0)
            {
                nudAtmero.Value = 0;
            }
        }
    }
}
