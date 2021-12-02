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
    public struct vagas
    {
        public int db;
        public int hossz;
        public bool feluletkezeles;
        public int szalanyag_id;
        public string text;
    }

    struct maradek
    {
        public int raktarId;
        public int szalanyagId;
        public int hossz;
    }

    public partial class Rendeles : BaseForm
    {

        List<vagas> vagaslistaFelvetel;

        public Rendeles()
        {
            InitializeComponent();
        }

        public void addVagas(vagas vagat, string szalanyagNev)
        {
            vagaslistaFelvetel.Add(vagat);
            lbVagaslista.Items.Add(string.Format("{0} x {1}mm x {2}; {3}", vagat.db, vagat.hossz, szalanyagNev, (vagat.feluletkezeles?"felületkezelés":"")));
        }

        private void Rendeles_Load(object sender, EventArgs e)
        {
            fillTable();

            vagaslistaFelvetel = new List<vagas>();
        }

        private void fillTable()
        {
            try
            {
                string filters = "";

                if (txtSzuroNev.Text != "")
                {
                    filters += string.Format(" r.beszallito_nev  like '%{0}%'", txtSzuroNev.Text);
                }

                if (chkSzuroDatumTol.Checked)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += string.Format(" r.datum >= '{0}-{1}-{2} {3}:{4}'", dtpSzuroTol.Value.Year, dtpSzuroTol.Value.Month, dtpSzuroTol.Value.Day, dtpSzuroTol.Value.Hour, dtpSzuroTol.Value.Minute);
                }

                if (chkSzuroDatumIg.Checked)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += string.Format(" r.datum <= '{0}-{1}-{2} {3}:{4}'", dtpSzuroIg.Value.Year, dtpSzuroIg.Value.Month, dtpSzuroIg.Value.Day, dtpSzuroIg.Value.Hour, dtpSzuroIg.Value.Minute);
                }

                if (chkSzuroTeljesitett.Checked && !chkSzuroNemTeljesitett.Checked)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += string.Format(" r.teljesitett = 1");
                }

                if (chkSzuroNemTeljesitett.Checked && !chkSzuroTeljesitett.Checked)
                {
                    if (filters.Length > 0)
                        filters += " AND";
                    filters += string.Format(" r.teljesitett = 0");
                }

                string query = string.Format("SELECT r.id, r.teljesitett, r.rendelo_nev, r.datum, r.surgosseg " +
                    "FROM rendeles as r " + (filters.Length > 0 ? "WHERE " + filters : "") + " " +
                    "ORDER BY r.surgosseg DESC;");

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgwRendeles.Rows.Clear();
                        while (reader.Read())
                        {
                            dgwRendeles.Rows.Add(reader.GetInt32(0), reader.GetBoolean(1), reader.GetString(2), reader.GetDateTime(3), reader.GetInt32(4));
                        }
                    }
                }

                for (int i = 0; i < dgwRendeles.Rows.Count; i++)
                {
                    int rendeles_id = Convert.ToInt32(dgwRendeles.Rows[i].Cells[0].Value.ToString());

                    query = string.Format("SELECT v.db, v.hossz, v.feluletkezeles, tipus.nev, anyag.rovid, anyagminoseg.nev, meret.szelesseg, meret.magassag, meret.vastagsag, meret.atmero " +
                        "FROM vagaslista as v " +
                        "INNER JOIN szalanyag ON v.szalanyag_id = szalanyag.id " +
                        "INNER JOIN meret ON szalanyag.meret_id = meret.id " +
                        "INNER JOIN anyag ON szalanyag.anyag_id = anyag.id " +
                        "INNER JOIN anyagminoseg ON szalanyag.anyagminoseg_id = anyagminoseg.id " +
                        "INNER JOIN tipus ON szalanyag.tipus_id = tipus.id " +
                        "WHERE v.rendeles_id = {0};", rendeles_id);

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Meret m = new Meret(reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9));
                                dgwRendeles.Rows[i].Cells[5].Value += string.Format("- {0} x {1} x {2} {3}\n", 
                                    reader.GetInt32(0), 
                                    reader.GetInt32(1), 
                                    string.Format("{0} ({1}, {2}, {3})", reader.GetString(3), reader.GetString(4), reader.GetString(5), m.getNev()),
                                    (reader.GetBoolean(2)?"+ felületkezelés":""));
                            }
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

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            if (txtNev.Text == "" || lbVagaslista.Items.Count <= 0)
            {
                MessageBox.Show("Rossz bemeneti adatok!");
                return;
            }

            try
            {
                int rendelesId = -1;

                string insertquery = string.Format("INSERT INTO rendeles(rendelo_nev, datum, surgosseg, teljesitett) VALUES('{0}', '{1}', {2}, {3});" +
                    " SELECT CAST(scope_identity() AS int)",
                    txtNev.Text,
                    string.Format("{0}-{1}-{2} {3}:{4}", dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpDate.Value.Hour, dtpDate.Value.Minute),
                    nudSurgosseg.Value,
                    "0");

                openConnection();

                using (SqlCommand insertCommand = new SqlCommand(insertquery, conn))
                {
                    rendelesId = Convert.ToInt32(insertCommand.ExecuteScalar());
                }

                int succesfulInserts = 0;

                for (int i = 0; i < vagaslistaFelvetel.Count; i++)
                {
                    insertquery = string.Format("INSERT INTO vagaslista(db, hossz, feluletkezeles, szalanyag_id, rendeles_id) VALUES({0}, {1}, {2}, {3}, {4});",
                        vagaslistaFelvetel[i].db,
                        vagaslistaFelvetel[i].hossz,
                        vagaslistaFelvetel[i].feluletkezeles ? 1 : 0,
                        vagaslistaFelvetel[i].szalanyag_id,
                        rendelesId);

                    using (SqlCommand insertCommand = new SqlCommand(insertquery, conn))
                    {
                        int result = insertCommand.ExecuteNonQuery();

                        if (result >= 0)
                            succesfulInserts++;
                    }
                }

                if (succesfulInserts != vagaslistaFelvetel.Count)
                    MessageBox.Show("Hiba történt az adatbeszúrás közben (vágáslista)!");


                conn.Close();

                txtNev.Text = "";
                dtpDate.Value = DateTime.Now;
                nudSurgosseg.Value = 1;
                lbVagaslista.Items.Clear();
                vagaslistaFelvetel.Clear();

                fillTable();
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

        private void btnUjVagas_Click(object sender, EventArgs e)
        {
            VagaslistaInput vi = new VagaslistaInput();

            vi.ShowDialog(this);
        }

        private void btnVagasEltavolitasa_Click(object sender, EventArgs e)
        {
            if (lbVagaslista.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Biztosan eltávolítja?\n\n" + lbVagaslista.SelectedItem.ToString(), "Vágás törlése", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vagaslistaFelvetel.RemoveAt(lbVagaslista.SelectedIndex);
                    lbVagaslista.Items.RemoveAt(lbVagaslista.SelectedIndex);
                }
            }
        }

        private void TeljesitettSzuro_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSzuroTeljesitett.Checked && !chkSzuroNemTeljesitett.Checked)
            {
                MessageBox.Show("Legalább az egyik teljesített szűrőnek aktívnak kell lennie!");
                chkSzuroNemTeljesitett.Checked = true;
            }
        }

        private void btnSzuro_Click(object sender, EventArgs e)
        {
            fillTable();
        }

        private void btnRendelesTorles_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dgwRendeles.SelectedRows[0].Cells[1].Value) == true)
            {
                MessageBox.Show("Csak olyan rendelést lehet törölni, amely még nem volt teljesítve!");
                return;
            }

            if (MessageBox.Show("Biztosan törli a kiválasztott rendelést?", "Rendelés törlése", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int rendeles_id = Convert.ToInt32(dgwRendeles.SelectedRows[0].Cells[0].Value.ToString());
            try
            {
                string deletequery = string.Format("DELETE FROM rendeles " +
                    "WHERE id = {0};", rendeles_id);

                bool successful = true;
                openConnection();
                using (SqlCommand insertCommand = new SqlCommand(deletequery, conn))
                {
                    int result = insertCommand.ExecuteNonQuery();

                    if (result < 0)
                        successful = false;
                }

                if (successful)
                {
                    deletequery = string.Format("DELETE FROM vagaslista " +
                    "WHERE rendeles_id = {0};", rendeles_id);

                    using (SqlCommand insertCommand = new SqlCommand(deletequery, conn))
                    {
                        int result = insertCommand.ExecuteNonQuery();

                        if (result < 0)
                            successful = false;
                    }

                    if (successful)
                        MessageBox.Show("Sikeres törlés!");
                    else
                        MessageBox.Show("Sikertelen törlés!");

                    fillTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a törlés közben!\n\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRendelesTeljesites_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dgwRendeles.SelectedRows[0].Cells[1].Value) == true)
            {
                MessageBox.Show("Csak olyan rendelést teljesíteni, amely még nem volt teljesítve!");
                return;
            }

            int rendeles_id = Convert.ToInt32(dgwRendeles.SelectedRows[0].Cells[0].Value.ToString());
            string rendelo_datum = dgwRendeles.SelectedRows[0].Cells[3].Value.ToString();
            string rendelo_surgosseg = dgwRendeles.SelectedRows[0].Cells[4].Value.ToString();
            string munkaszam = "SZ";
            for (int i = 0; i < 4 - rendeles_id.ToString().Length; i++)
                munkaszam += "0";
            munkaszam += rendeles_id.ToString();

            double kezelendoFelulet = 0;

            try
            {
                string query = string.Format("SELECT v.db, v.hossz, v.feluletkezeles, v.szalanyag_id, tipus.nev, anyag.rovid, anyagminoseg.nev, meret.szelesseg, meret.magassag, meret.vastagsag, meret.atmero " +
                    "FROM vagaslista as v " +
                    "INNER JOIN szalanyag ON v.szalanyag_id = szalanyag.id " +
                    "INNER JOIN meret ON szalanyag.meret_id = meret.id " +
                    "INNER JOIN anyag ON szalanyag.anyag_id = anyag.id " +
                    "INNER JOIN anyagminoseg ON szalanyag.anyagminoseg_id = anyagminoseg.id " +
                    "INNER JOIN tipus ON szalanyag.tipus_id = tipus.id " +
                    "WHERE rendeles_id = {0} " +
                    "ORDER BY v.hossz DESC;", rendeles_id);

                List<vagas> vagasok = new List<vagas>();

                openConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Meret m = new Meret(reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10));
                            
                            vagas temp;
                            temp.db = reader.GetInt32(0);
                            temp.hossz = reader.GetInt32(1);
                            temp.feluletkezeles = reader.GetBoolean(2);
                            temp.szalanyag_id = reader.GetInt32(3);
                            temp.text = string.Format("{0} x {1} x {2} {3}\n",
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                string.Format("{0} ({1}, {2}, {3})", reader.GetString(4), reader.GetString(5), reader.GetString(6), m.getNev()),
                                (temp.feluletkezeles ? "+ felületkezelés" : ""));
                            vagasok.Add(temp);

                            if (temp.feluletkezeles)
                            {
                                kezelendoFelulet += temp.db * m.getFelulet(temp.hossz);
                            }
                        }
                    }
                }

                Dictionary<int, int> raktarVagat = new Dictionary<int, int>();
                Dictionary<int, int> maradekVagat = new Dictionary<int, int>();
                List<maradek> raktarMaradek = new List<maradek>();
                List<int[]> raktarHiany = new List<int[]>();

                // vágások teljesíthetőségének vizsgálata
                bool success = true;
                for (int i = 0; i < vagasok.Count; i++)
                {
                    for (int j = 0; j < vagasok[i].db; j++)
                    {
                        int m = 0;
                        while (m < raktarMaradek.Count && (raktarMaradek[m].szalanyagId != vagasok[i].szalanyag_id || raktarMaradek[m].hossz < vagasok[i].hossz))
                        {
                            m++;
                        }

                        if (m < raktarMaradek.Count)
                        {
                            if (maradekVagat.ContainsKey(m))
                                maradekVagat[m] += 1;
                            else
                                maradekVagat[m] = 1;

                            maradek tempMaradek;
                            tempMaradek.raktarId = raktarMaradek[m].raktarId;
                            tempMaradek.szalanyagId = raktarMaradek[m].szalanyagId;
                            tempMaradek.hossz = raktarMaradek[m].hossz - vagasok[i].hossz;

                            raktarMaradek[m] = tempMaradek;

                            continue;
                        }

                        query = string.Format("SELECT TOP(1) id, db, hossz " +
                        "FROM raktar " +
                        "WHERE szalanyag_id = {0} AND hossz >= {1} " +
                        "ORDER BY hossz - {1};", vagasok[i].szalanyag_id, vagasok[i].hossz);

                        openConnection();
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    success = false;

                                    int k = 0;
                                    while (k < raktarHiany.Count && (raktarHiany[k][0] != vagasok[i].szalanyag_id || raktarHiany[k][1] != vagasok[i].hossz))
                                        k++;

                                    if (k < raktarHiany.Count)
                                        raktarHiany[k][2]++;
                                    else
                                        raktarHiany.Add(new int[] { vagasok[i].szalanyag_id, vagasok[i].hossz, 1 });

                                    continue;
                                }

                                int raktarId = reader.GetInt32(0);

                                if (raktarVagat.ContainsKey(raktarId))
                                {
                                    if (reader.GetInt32(1) <= raktarVagat[raktarId])
                                    {
                                        success = false;

                                        int k = 0;
                                        while (k < raktarHiany.Count && (raktarHiany[k][0] != vagasok[i].szalanyag_id || raktarHiany[k][1] != vagasok[i].hossz))
                                            k++;

                                        if (k < raktarHiany.Count)
                                            raktarHiany[k][2]++;
                                        else
                                            raktarHiany.Add(new int[] { vagasok[i].szalanyag_id, vagasok[i].hossz, 1 });
                                    }
                                    else
                                    {
                                        raktarVagat[raktarId] += 1;

                                        maradek tempMaradek;
                                        tempMaradek.raktarId = raktarId;
                                        tempMaradek.szalanyagId = vagasok[i].szalanyag_id;
                                        tempMaradek.hossz = reader.GetInt32(2) - vagasok[i].hossz;
                                        raktarMaradek.Add(tempMaradek);
                                    }
                                }
                                else
                                {
                                    raktarVagat[raktarId] = 1;

                                    maradek tempMaradek;
                                    tempMaradek.raktarId = raktarId;
                                    tempMaradek.szalanyagId = vagasok[i].szalanyag_id;
                                    tempMaradek.hossz = reader.GetInt32(2) - vagasok[i].hossz;
                                    raktarMaradek.Add(tempMaradek);
                                }
                            }
                        }
                    }
                }

                // Változtatások végrehajtása
                if (success)
                {
                    //foreach (var v in raktarVagat)
                    //{
                    //    query = string.Format("SELECT db " +
                    //        "FROM raktar " +
                    //        "WHERE id = {0};", v.Key);

                    //    int raktarDb = -1;
                    //    openConnection();
                    //    using (SqlCommand command = new SqlCommand(query, conn))
                    //    {
                    //        using (SqlDataReader reader = command.ExecuteReader())
                    //        {
                    //            reader.Read();

                    //            raktarDb = reader.GetInt32(0);
                    //        }
                    //    }


                    //    if (raktarDb <= v.Value)
                    //    {
                    //        string deletequery = string.Format("DELETE FROM raktar " +
                    //            "WHERE id = {0};", v.Key);

                    //        openConnection();
                    //        using (SqlCommand insertCommand = new SqlCommand(deletequery, conn))
                    //        {
                    //            int result = insertCommand.ExecuteNonQuery();
                    //        }
                    //    }
                    //    else
                    //    {
                    //        string updatequery = string.Format("UPDATE raktar " +
                    //            "SET db = {0}" +
                    //            "WHERE id = {1};", raktarDb - v.Value, v.Key);

                    //        openConnection();
                    //        using (SqlCommand insertCommand = new SqlCommand(updatequery, conn))
                    //        {
                    //            int result = insertCommand.ExecuteNonQuery();
                    //        }
                    //    }
                    //}

                    //query = string.Format("UPDATE rendeles " +
                    //            "SET teljesitett = 1" +
                    //            "WHERE id = {0};", rendeles_id);

                    //openConnection();
                    //using (SqlCommand insertCommand = new SqlCommand(query, conn))
                    //{
                    //    insertCommand.ExecuteNonQuery();
                    //}

                    //// maradék hozzáadása raktárhoz
                    //for (int i = 0; i < raktarMaradek.Count; i++)
                    //{

                    //    string readquery = string.Format("SELECT raktar.id, raktar.db, raktar.hossz, raktar.szalanyag_id " +
                    //        "FROM raktar " +
                    //        "WHERE raktar.szalanyag_id = {0} AND raktar.hossz = {1};", raktarMaradek[i].szalanyagId, raktarMaradek[i].hossz);

                    //    Dictionary<string, int> storageData = new Dictionary<string, int>(4);

                    //    bool alreadyExists = true;

                    //    using (SqlCommand readCommand = new SqlCommand(readquery, conn))
                    //    {
                    //        using (SqlDataReader reader = readCommand.ExecuteReader())
                    //        {
                    //            if (reader.HasRows)
                    //            {
                    //                reader.Read();

                    //                storageData["id"] = reader.GetInt32(0);
                    //                storageData["db"] = reader.GetInt32(1);
                    //                storageData["hossz"] = reader.GetInt32(2);
                    //                storageData["szalanyag_id"] = reader.GetInt32(3);
                    //            }
                    //            else
                    //            {
                    //                alreadyExists = false;
                    //            }
                    //        }
                    //    }

                    //    string insertquery;

                    //    if (alreadyExists)
                    //    {
                    //        insertquery = string.Format("UPDATE raktar SET db = {0} WHERE id = {1};",
                    //            storageData["db"] + 1,
                    //            storageData["id"]);

                    //        using (SqlCommand insertCommand = new SqlCommand(insertquery, conn))
                    //        {
                    //            int result = insertCommand.ExecuteNonQuery();

                    //            if (result < 0)
                    //            {
                    //                MessageBox.Show("Hiba adatmódosítás közben!");
                    //            }
                    //        }
                    //    }
                    //    else
                    //    {
                    //        insertquery = string.Format("INSERT INTO raktar(db, hossz, szalanyag_id) VALUES({0}, {1}, {2});",
                    //            1,
                    //            raktarMaradek[i].hossz,
                    //            raktarMaradek[i].szalanyagId);

                    //        using (SqlCommand insertCommand = new SqlCommand(insertquery, conn))
                    //        {
                    //            int result = insertCommand.ExecuteNonQuery();

                    //            if (result < 0)
                    //            {
                    //                MessageBox.Show("Hiba adatbeszúrás közben!");
                    //            }
                    //        }
                    //    }
                    //}

                    string[,] raktarOutput = new string[raktarVagat.Count, 4];
                    int c = 0;
                    foreach (var x in raktarVagat)
                    {
                        query = string.Format("SELECT r.db, r.hossz, tipus.nev, anyag.rovid, anyagminoseg.nev, meret.szelesseg, meret.magassag, meret.vastagsag, meret.atmero " +
                        "FROM raktar as r " +
                        "INNER JOIN szalanyag ON r.szalanyag_id = szalanyag.id " +
                        "INNER JOIN meret ON szalanyag.meret_id = meret.id " +
                        "INNER JOIN anyag ON szalanyag.anyag_id = anyag.id " +
                        "INNER JOIN anyagminoseg ON szalanyag.anyagminoseg_id = anyagminoseg.id " +
                        "INNER JOIN tipus ON szalanyag.tipus_id = tipus.id " +
                        "WHERE r.id = {0};", x.Key);

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                reader.Read();

                                Meret m = new Meret(reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8));

                                raktarOutput[c, 0] = string.Format("{0} ({1}, {2})", reader.GetString(2), reader.GetString(3), reader.GetString(4));
                                raktarOutput[c, 1] = m.getNev();
                                raktarOutput[c, 2] = reader.GetInt32(1).ToString();
                                raktarOutput[c, 3] = reader.GetInt32(0).ToString();

                                c++;
                            }
                        }
                    }

                    Output.rendelesOutput(munkaszam, rendelo_datum, rendelo_surgosseg, raktarOutput, kezelendoFelulet);

                    MessageBox.Show("Rendelés teljesítve!");
                }
                else
                {
                    if (MessageBox.Show("A rendelés nem teljesíthető! Kíván egy rendelési bizonylatot létrehozni a hiányzó szálanyagokról?", "Hiányzó anyagok", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string[,] raktarhianyOutput = new string[raktarHiany.Count, 4];
                        int c = 0;
                        foreach (var x in raktarHiany)
                        {
                            query = string.Format("SELECT tipus.nev, anyag.rovid, anyagminoseg.nev, meret.szelesseg, meret.magassag, meret.vastagsag, meret.atmero " +
                                "FROM szalanyag " +
                                "INNER JOIN meret ON szalanyag.meret_id = meret.id " +
                                "INNER JOIN anyag ON szalanyag.anyag_id = anyag.id " +
                                "INNER JOIN anyagminoseg ON szalanyag.anyagminoseg_id = anyagminoseg.id " +
                                "INNER JOIN tipus ON szalanyag.tipus_id = tipus.id " +
                                "WHERE szalanyag.id = {0};", x[0]);

                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    reader.Read();

                                    Meret m = new Meret(reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6));

                                    raktarhianyOutput[c, 0] = string.Format("{0} ({1}, {2})", reader.GetString(0), reader.GetString(1), reader.GetString(2));
                                    raktarhianyOutput[c, 1] = m.getNev();
                                    raktarhianyOutput[c, 2] = x[1].ToString();
                                    raktarhianyOutput[c, 3] = x[2].ToString();

                                    c++;
                                }
                            }
                        }

                        Output.hianyOutput(munkaszam, rendelo_datum, rendelo_surgosseg, raktarhianyOutput, kezelendoFelulet);

                        MessageBox.Show("Bizonylat kész!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a rendelés teljesítése során!\n\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
