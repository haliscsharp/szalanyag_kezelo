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
    public partial class SimpleNameInput : BaseForm
    {
        private string tableName;

        public SimpleNameInput(string _tableName)
        {
            InitializeComponent();

            this.tableName = _tableName;
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

                string readquery = string.Format("SELECT id FROM {0} WHERE nev = '{1}';", tableName, txtNev.Text);

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
                            string insertquery = string.Format("INSERT INTO {0}(nev) VALUES(N'" + txtNev.Text + "');", tableName);

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
                string query = string.Format("SELECT nev FROM {0};", tableName);

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgwInput.Rows.Clear();
                        while (reader.Read())
                        {
                            dgwInput.Rows.Add(reader.GetString(0));
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
