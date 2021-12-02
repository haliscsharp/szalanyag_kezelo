
namespace szalkezelo
{
    partial class Rendeles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbSzurok = new System.Windows.Forms.GroupBox();
            this.btnSzuro = new System.Windows.Forms.Button();
            this.chkSzuroTeljesitett = new System.Windows.Forms.CheckBox();
            this.chkSzuroNemTeljesitett = new System.Windows.Forms.CheckBox();
            this.chkSzuroDatumIg = new System.Windows.Forms.CheckBox();
            this.chkSzuroDatumTol = new System.Windows.Forms.CheckBox();
            this.dtpSzuroIg = new System.Windows.Forms.DateTimePicker();
            this.dtpSzuroTol = new System.Windows.Forms.DateTimePicker();
            this.txtSzuroNev = new System.Windows.Forms.TextBox();
            this.lblSzuroNev = new System.Windows.Forms.Label();
            this.gbFelvitel = new System.Windows.Forms.GroupBox();
            this.nudSurgosseg = new System.Windows.Forms.NumericUpDown();
            this.lbVagaslista = new System.Windows.Forms.ListBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblVagaslista = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblSurgosseg = new System.Windows.Forms.Label();
            this.lblNev = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.btnVagasEltavolitasa = new System.Windows.Forms.Button();
            this.btnUjVagas = new System.Windows.Forms.Button();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.dgwRendeles = new System.Windows.Forms.DataGridView();
            this.btnRendelesTeljesites = new System.Windows.Forms.Button();
            this.btnRendelesTorles = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teljesitett = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.munkaszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelo_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surgosseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vagaslista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSzurok.SuspendLayout();
            this.gbFelvitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurgosseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRendeles)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSzurok
            // 
            this.gbSzurok.Controls.Add(this.btnSzuro);
            this.gbSzurok.Controls.Add(this.chkSzuroTeljesitett);
            this.gbSzurok.Controls.Add(this.chkSzuroNemTeljesitett);
            this.gbSzurok.Controls.Add(this.chkSzuroDatumIg);
            this.gbSzurok.Controls.Add(this.chkSzuroDatumTol);
            this.gbSzurok.Controls.Add(this.dtpSzuroIg);
            this.gbSzurok.Controls.Add(this.dtpSzuroTol);
            this.gbSzurok.Controls.Add(this.txtSzuroNev);
            this.gbSzurok.Controls.Add(this.lblSzuroNev);
            this.gbSzurok.Location = new System.Drawing.Point(12, 13);
            this.gbSzurok.Name = "gbSzurok";
            this.gbSzurok.Size = new System.Drawing.Size(898, 117);
            this.gbSzurok.TabIndex = 7;
            this.gbSzurok.TabStop = false;
            this.gbSzurok.Text = "Szűrők";
            // 
            // btnSzuro
            // 
            this.btnSzuro.Location = new System.Drawing.Point(762, 67);
            this.btnSzuro.Name = "btnSzuro";
            this.btnSzuro.Size = new System.Drawing.Size(94, 29);
            this.btnSzuro.TabIndex = 11;
            this.btnSzuro.Tag = "";
            this.btnSzuro.Text = "Szűrés";
            this.btnSzuro.UseVisualStyleBackColor = true;
            this.btnSzuro.Click += new System.EventHandler(this.btnSzuro_Click);
            // 
            // chkSzuroTeljesitett
            // 
            this.chkSzuroTeljesitett.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSzuroTeljesitett.Location = new System.Drawing.Point(10, 69);
            this.chkSzuroTeljesitett.Name = "chkSzuroTeljesitett";
            this.chkSzuroTeljesitett.Size = new System.Drawing.Size(126, 30);
            this.chkSzuroTeljesitett.TabIndex = 10;
            this.chkSzuroTeljesitett.Text = "Teljesített";
            this.chkSzuroTeljesitett.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSzuroTeljesitett.UseVisualStyleBackColor = true;
            this.chkSzuroTeljesitett.CheckedChanged += new System.EventHandler(this.TeljesitettSzuro_CheckedChanged);
            // 
            // chkSzuroNemTeljesitett
            // 
            this.chkSzuroNemTeljesitett.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSzuroNemTeljesitett.Checked = true;
            this.chkSzuroNemTeljesitett.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSzuroNemTeljesitett.Location = new System.Drawing.Point(154, 69);
            this.chkSzuroNemTeljesitett.Name = "chkSzuroNemTeljesitett";
            this.chkSzuroNemTeljesitett.Size = new System.Drawing.Size(154, 30);
            this.chkSzuroNemTeljesitett.TabIndex = 10;
            this.chkSzuroNemTeljesitett.Text = "Nem teljesített";
            this.chkSzuroNemTeljesitett.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSzuroNemTeljesitett.UseVisualStyleBackColor = true;
            this.chkSzuroNemTeljesitett.CheckedChanged += new System.EventHandler(this.TeljesitettSzuro_CheckedChanged);
            // 
            // chkSzuroDatumIg
            // 
            this.chkSzuroDatumIg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSzuroDatumIg.Location = new System.Drawing.Point(367, 69);
            this.chkSzuroDatumIg.Name = "chkSzuroDatumIg";
            this.chkSzuroDatumIg.Size = new System.Drawing.Size(126, 30);
            this.chkSzuroDatumIg.TabIndex = 10;
            this.chkSzuroDatumIg.Text = "Dátum ig:";
            this.chkSzuroDatumIg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSzuroDatumIg.UseVisualStyleBackColor = true;
            // 
            // chkSzuroDatumTol
            // 
            this.chkSzuroDatumTol.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSzuroDatumTol.Location = new System.Drawing.Point(367, 25);
            this.chkSzuroDatumTol.Name = "chkSzuroDatumTol";
            this.chkSzuroDatumTol.Size = new System.Drawing.Size(126, 30);
            this.chkSzuroDatumTol.TabIndex = 10;
            this.chkSzuroDatumTol.Text = "Dátum tól:";
            this.chkSzuroDatumTol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSzuroDatumTol.UseVisualStyleBackColor = true;
            // 
            // dtpSzuroIg
            // 
            this.dtpSzuroIg.CustomFormat = "yyyy. MM. dd. HH:mm";
            this.dtpSzuroIg.Enabled = false;
            this.dtpSzuroIg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSzuroIg.Location = new System.Drawing.Point(499, 69);
            this.dtpSzuroIg.Name = "dtpSzuroIg";
            this.dtpSzuroIg.Size = new System.Drawing.Size(221, 27);
            this.dtpSzuroIg.TabIndex = 9;
            // 
            // dtpSzuroTol
            // 
            this.dtpSzuroTol.CustomFormat = "yyyy. MM. dd. HH:mm";
            this.dtpSzuroTol.Enabled = false;
            this.dtpSzuroTol.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSzuroTol.Location = new System.Drawing.Point(499, 27);
            this.dtpSzuroTol.Name = "dtpSzuroTol";
            this.dtpSzuroTol.Size = new System.Drawing.Size(221, 27);
            this.dtpSzuroTol.TabIndex = 9;
            // 
            // txtSzuroNev
            // 
            this.txtSzuroNev.Location = new System.Drawing.Point(119, 26);
            this.txtSzuroNev.Name = "txtSzuroNev";
            this.txtSzuroNev.Size = new System.Drawing.Size(242, 27);
            this.txtSzuroNev.TabIndex = 2;
            // 
            // lblSzuroNev
            // 
            this.lblSzuroNev.Location = new System.Drawing.Point(21, 25);
            this.lblSzuroNev.Name = "lblSzuroNev";
            this.lblSzuroNev.Size = new System.Drawing.Size(92, 28);
            this.lblSzuroNev.TabIndex = 1;
            this.lblSzuroNev.Text = "Név:";
            this.lblSzuroNev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbFelvitel
            // 
            this.gbFelvitel.Controls.Add(this.nudSurgosseg);
            this.gbFelvitel.Controls.Add(this.lbVagaslista);
            this.gbFelvitel.Controls.Add(this.dtpDate);
            this.gbFelvitel.Controls.Add(this.lblVagaslista);
            this.gbFelvitel.Controls.Add(this.lblDatum);
            this.gbFelvitel.Controls.Add(this.lblSurgosseg);
            this.gbFelvitel.Controls.Add(this.lblNev);
            this.gbFelvitel.Controls.Add(this.txtNev);
            this.gbFelvitel.Controls.Add(this.btnVagasEltavolitasa);
            this.gbFelvitel.Controls.Add(this.btnUjVagas);
            this.gbFelvitel.Controls.Add(this.btnFelvitel);
            this.gbFelvitel.Location = new System.Drawing.Point(916, 136);
            this.gbFelvitel.Name = "gbFelvitel";
            this.gbFelvitel.Size = new System.Drawing.Size(428, 349);
            this.gbFelvitel.TabIndex = 6;
            this.gbFelvitel.TabStop = false;
            this.gbFelvitel.Text = "Új elem felvitele";
            // 
            // nudSurgosseg
            // 
            this.nudSurgosseg.Location = new System.Drawing.Point(149, 87);
            this.nudSurgosseg.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSurgosseg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSurgosseg.Name = "nudSurgosseg";
            this.nudSurgosseg.Size = new System.Drawing.Size(67, 27);
            this.nudSurgosseg.TabIndex = 10;
            this.nudSurgosseg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbVagaslista
            // 
            this.lbVagaslista.FormattingEnabled = true;
            this.lbVagaslista.HorizontalScrollbar = true;
            this.lbVagaslista.ItemHeight = 20;
            this.lbVagaslista.Location = new System.Drawing.Point(14, 155);
            this.lbVagaslista.Name = "lbVagaslista";
            this.lbVagaslista.Size = new System.Drawing.Size(399, 124);
            this.lbVagaslista.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy. MM. dd. HH:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(149, 54);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(264, 27);
            this.dtpDate.TabIndex = 8;
            // 
            // lblVagaslista
            // 
            this.lblVagaslista.Location = new System.Drawing.Point(6, 124);
            this.lblVagaslista.Name = "lblVagaslista";
            this.lblVagaslista.Size = new System.Drawing.Size(137, 25);
            this.lblVagaslista.TabIndex = 6;
            this.lblVagaslista.Text = "Vágáslista:";
            this.lblVagaslista.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDatum
            // 
            this.lblDatum.Location = new System.Drawing.Point(6, 56);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(137, 25);
            this.lblDatum.TabIndex = 6;
            this.lblDatum.Text = "Dátum:";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSurgosseg
            // 
            this.lblSurgosseg.Location = new System.Drawing.Point(6, 89);
            this.lblSurgosseg.Name = "lblSurgosseg";
            this.lblSurgosseg.Size = new System.Drawing.Size(137, 25);
            this.lblSurgosseg.TabIndex = 6;
            this.lblSurgosseg.Text = "Sürgősség (1-5):";
            this.lblSurgosseg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNev
            // 
            this.lblNev.Location = new System.Drawing.Point(6, 23);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(137, 25);
            this.lblNev.TabIndex = 6;
            this.lblNev.Text = "Név:";
            this.lblNev.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(149, 21);
            this.txtNev.MaxLength = 50;
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(264, 27);
            this.txtNev.TabIndex = 5;
            // 
            // btnVagasEltavolitasa
            // 
            this.btnVagasEltavolitasa.Location = new System.Drawing.Point(284, 120);
            this.btnVagasEltavolitasa.Name = "btnVagasEltavolitasa";
            this.btnVagasEltavolitasa.Size = new System.Drawing.Size(129, 29);
            this.btnVagasEltavolitasa.TabIndex = 2;
            this.btnVagasEltavolitasa.Text = "Vágás törlése";
            this.btnVagasEltavolitasa.UseVisualStyleBackColor = true;
            this.btnVagasEltavolitasa.Click += new System.EventHandler(this.btnVagasEltavolitasa_Click);
            // 
            // btnUjVagas
            // 
            this.btnUjVagas.Location = new System.Drawing.Point(149, 120);
            this.btnUjVagas.Name = "btnUjVagas";
            this.btnUjVagas.Size = new System.Drawing.Size(129, 29);
            this.btnUjVagas.TabIndex = 2;
            this.btnUjVagas.Text = "Új vágás";
            this.btnUjVagas.UseVisualStyleBackColor = true;
            this.btnUjVagas.Click += new System.EventHandler(this.btnUjVagas_Click);
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(319, 302);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(94, 29);
            this.btnFelvitel.TabIndex = 2;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // dgwRendeles
            // 
            this.dgwRendeles.AllowUserToAddRows = false;
            this.dgwRendeles.AllowUserToDeleteRows = false;
            this.dgwRendeles.AllowUserToOrderColumns = true;
            this.dgwRendeles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwRendeles.ColumnHeadersHeight = 40;
            this.dgwRendeles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.teljesitett,
            this.munkaszam,
            this.rendelo_nev,
            this.datum,
            this.surgosseg,
            this.vagaslista});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwRendeles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwRendeles.Location = new System.Drawing.Point(12, 136);
            this.dgwRendeles.MultiSelect = false;
            this.dgwRendeles.Name = "dgwRendeles";
            this.dgwRendeles.ReadOnly = true;
            this.dgwRendeles.RowHeadersVisible = false;
            this.dgwRendeles.RowHeadersWidth = 51;
            this.dgwRendeles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwRendeles.Size = new System.Drawing.Size(898, 349);
            this.dgwRendeles.TabIndex = 5;
            // 
            // btnRendelesTeljesites
            // 
            this.btnRendelesTeljesites.Location = new System.Drawing.Point(746, 491);
            this.btnRendelesTeljesites.Name = "btnRendelesTeljesites";
            this.btnRendelesTeljesites.Size = new System.Drawing.Size(164, 49);
            this.btnRendelesTeljesites.TabIndex = 2;
            this.btnRendelesTeljesites.Text = "Kijelölt teljesítése";
            this.btnRendelesTeljesites.UseVisualStyleBackColor = true;
            this.btnRendelesTeljesites.Click += new System.EventHandler(this.btnRendelesTeljesites_Click);
            // 
            // btnRendelesTorles
            // 
            this.btnRendelesTorles.Location = new System.Drawing.Point(570, 501);
            this.btnRendelesTorles.Name = "btnRendelesTorles";
            this.btnRendelesTorles.Size = new System.Drawing.Size(130, 29);
            this.btnRendelesTorles.TabIndex = 2;
            this.btnRendelesTorles.Text = "Rendelés törlése";
            this.btnRendelesTorles.UseVisualStyleBackColor = true;
            this.btnRendelesTorles.Click += new System.EventHandler(this.btnRendelesTorles_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 51;
            // 
            // teljesitett
            // 
            this.teljesitett.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.teljesitett.HeaderText = "Teljesített";
            this.teljesitett.MinimumWidth = 6;
            this.teljesitett.Name = "teljesitett";
            this.teljesitett.ReadOnly = true;
            this.teljesitett.Width = 79;
            // 
            // munkaszam
            // 
            this.munkaszam.HeaderText = "Munkaszám";
            this.munkaszam.MinimumWidth = 6;
            this.munkaszam.Name = "munkaszam";
            this.munkaszam.ReadOnly = true;
            this.munkaszam.Width = 125;
            // 
            // rendelo_nev
            // 
            this.rendelo_nev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rendelo_nev.HeaderText = "Rendelő név";
            this.rendelo_nev.MinimumWidth = 6;
            this.rendelo_nev.Name = "rendelo_nev";
            this.rendelo_nev.ReadOnly = true;
            this.rendelo_nev.Width = 120;
            // 
            // datum
            // 
            this.datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datum.HeaderText = "Dátum";
            this.datum.MinimumWidth = 6;
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            this.datum.Width = 83;
            // 
            // surgosseg
            // 
            this.surgosseg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.surgosseg.HeaderText = "Sürgősség";
            this.surgosseg.MinimumWidth = 6;
            this.surgosseg.Name = "surgosseg";
            this.surgosseg.ReadOnly = true;
            this.surgosseg.Width = 106;
            // 
            // vagaslista
            // 
            this.vagaslista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vagaslista.HeaderText = "Vágáslista (db x hossz x szálanyag)";
            this.vagaslista.MinimumWidth = 300;
            this.vagaslista.Name = "vagaslista";
            this.vagaslista.ReadOnly = true;
            // 
            // Rendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 552);
            this.Controls.Add(this.gbSzurok);
            this.Controls.Add(this.gbFelvitel);
            this.Controls.Add(this.dgwRendeles);
            this.Controls.Add(this.btnRendelesTorles);
            this.Controls.Add(this.btnRendelesTeljesites);
            this.Name = "Rendeles";
            this.Text = "Rendelés";
            this.Load += new System.EventHandler(this.Rendeles_Load);
            this.gbSzurok.ResumeLayout(false);
            this.gbSzurok.PerformLayout();
            this.gbFelvitel.ResumeLayout(false);
            this.gbFelvitel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurgosseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRendeles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSzurok;
        private System.Windows.Forms.Button btnSzuro;
        private System.Windows.Forms.CheckBox chkSzuroDatumIg;
        private System.Windows.Forms.CheckBox chkSzuroDatumTol;
        private System.Windows.Forms.DateTimePicker dtpSzuroIg;
        private System.Windows.Forms.DateTimePicker dtpSzuroTol;
        private System.Windows.Forms.TextBox txtSzuroNev;
        private System.Windows.Forms.Label lblSzuroNev;
        private System.Windows.Forms.GroupBox gbFelvitel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.DataGridView dgwRendeles;
        private System.Windows.Forms.ListBox lbVagaslista;
        private System.Windows.Forms.Label lblVagaslista;
        private System.Windows.Forms.Button btnVagasEltavolitasa;
        private System.Windows.Forms.Button btnUjVagas;
        private System.Windows.Forms.CheckBox chkSzuroTeljesitett;
        private System.Windows.Forms.CheckBox chkSzuroNemTeljesitett;
        private System.Windows.Forms.NumericUpDown nudSurgosseg;
        private System.Windows.Forms.Label lblSurgosseg;
        private System.Windows.Forms.Button btnRendelesTeljesites;
        private System.Windows.Forms.Button btnRendelesTorles;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn teljesitett;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkaszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendelo_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn surgosseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn vagaslista;
    }
}