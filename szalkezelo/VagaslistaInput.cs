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
    public partial class VagaslistaInput : BaseForm
    {
        public VagaslistaInput()
        {
            InitializeComponent();
        }

        private void Bevetelezes_Load(object sender, EventArgs e)
        {
            fillCbSzalanyag();
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

                cbSzalanyag.DataSource = dt;
                cbSzalanyag.ValueMember = "id";
                cbSzalanyag.DisplayMember = "nev";
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
            if (nudDb.Value <= 0 || nudHossz.Value <= 0 || cbSzalanyag.SelectedValue == null || int.Parse(cbSzalanyag.SelectedValue.ToString()) == -1)
            {
                MessageBox.Show("Rossz bemeneti adatok!");
                return;
            }

            Rendeles ren = (Rendeles)this.Owner;

            vagas vagat = new vagas();

            vagat.db = (int)nudDb.Value;
            vagat.hossz = (int)nudHossz.Value;
            vagat.feluletkezeles = chkFeluletkezeles.Checked;
            vagat.szalanyag_id = int.Parse(cbSzalanyag.SelectedValue.ToString());

            ren.addVagas(vagat, cbSzalanyag.Text);

            this.Close();
        }

        private void btnUjSzalanyag_Click(object sender, EventArgs e)
        {
            SzalanyagInput si = new SzalanyagInput();

            si.ShowDialog();

            fillCbSzalanyag();
        }

    }
}
