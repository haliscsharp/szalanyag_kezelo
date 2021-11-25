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
    public partial class BaseForm : Form
    {
        protected SqlConnection conn;
        private bool isInitialized;

        public BaseForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            isInitialized = false;
        }

        protected void openConnection()
        {
            if (isInitialized && conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            else
            {
                try
                {
                    string connectionString = @"Server=localhost\SQLEXPRESS;Database=szalanyag_kezelo;Trusted_Connection=True;";
                    conn = new SqlConnection(connectionString);
                    conn.Open();

                    isInitialized = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt az adatbázishoz való csatlakozáskor!\n\n" + ex.Message);
                }
            }
        }
    }
}
