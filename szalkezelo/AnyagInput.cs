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
    public partial class AnyagInput : BaseForm
    {
        public AnyagInput()
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

                string readquery = string.Format("SELECT id FROM anyag WHERE nev = '{0}' OR rovid = '{1}';", txtNev.Text, txtRovid.Text);

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
                    string insertquery = string.Format("INSERT INTO anyag(nev, rovid) VALUES(N'" + txtNev.Text + "', N'" + txtRovid.Text + "');");

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
                            txtRovid.Text = "";
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
                string query = string.Format("SELECT nev, rovid FROM anyag;");

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgwRaktar.Rows.Clear();
                        while (reader.Read())
                        {
                            dgwRaktar.Rows.Add(reader.GetString(0), reader.GetString(1));
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

    }
}
