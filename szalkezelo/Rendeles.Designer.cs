
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
            this.gbSzurok = new System.Windows.Forms.GroupBox();
            this.btnSzuro = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chkSzuroDatumIg = new System.Windows.Forms.CheckBox();
            this.chkSzuroDatumTol = new System.Windows.Forms.CheckBox();
            this.dtpSzuroIg = new System.Windows.Forms.DateTimePicker();
            this.dtpSzuroTol = new System.Windows.Forms.DateTimePicker();
            this.txtSzuroNev = new System.Windows.Forms.TextBox();
            this.lblSzuroNev = new System.Windows.Forms.Label();
            this.gbFelvitel = new System.Windows.Forms.GroupBox();
            this.lbVagaslista = new System.Windows.Forms.ListBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblVagaslista = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblNev = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.btnVagasEltavolitasa = new System.Windows.Forms.Button();
            this.btnUjVagas = new System.Windows.Forms.Button();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.dgwBevetelezes = new System.Windows.Forms.DataGridView();
            this.teljesitett = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rendelo_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surgosseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vagaslista = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gbSzurok.SuspendLayout();
            this.gbFelvitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBevetelezes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSzurok
            // 
            this.gbSzurok.Controls.Add(this.btnSzuro);
            this.gbSzurok.Controls.Add(this.checkBox1);
            this.gbSzurok.Controls.Add(this.checkBox2);
            this.gbSzurok.Controls.Add(this.chkSzuroDatumIg);
            this.gbSzurok.Controls.Add(this.chkSzuroDatumTol);
            this.gbSzurok.Controls.Add(this.dtpSzuroIg);
            this.gbSzurok.Controls.Add(this.dtpSzuroTol);
            this.gbSzurok.Controls.Add(this.txtSzuroNev);
            this.gbSzurok.Controls.Add(this.lblSzuroNev);
            this.gbSzurok.Location = new System.Drawing.Point(12, 13);
            this.gbSzurok.Name = "gbSzurok";
            this.gbSzurok.Size = new System.Drawing.Size(856, 117);
            this.gbSzurok.TabIndex = 7;
            this.gbSzurok.TabStop = false;
            this.gbSzurok.Text = "Szűrők";
            // 
            // btnSzuro
            // 
            this.btnSzuro.Location = new System.Drawing.Point(741, 66);
            this.btnSzuro.Name = "btnSzuro";
            this.btnSzuro.Size = new System.Drawing.Size(94, 29);
            this.btnSzuro.TabIndex = 11;
            this.btnSzuro.Tag = "";
            this.btnSzuro.Text = "Szűrés";
            this.btnSzuro.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(10, 69);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 30);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Teljesített";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(154, 69);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(154, 30);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Nem teljesített";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.UseVisualStyleBackColor = true;
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
            this.gbFelvitel.Controls.Add(this.lbVagaslista);
            this.gbFelvitel.Controls.Add(this.dtpDate);
            this.gbFelvitel.Controls.Add(this.lblVagaslista);
            this.gbFelvitel.Controls.Add(this.lblDatum);
            this.gbFelvitel.Controls.Add(this.lblNev);
            this.gbFelvitel.Controls.Add(this.txtNev);
            this.gbFelvitel.Controls.Add(this.btnVagasEltavolitasa);
            this.gbFelvitel.Controls.Add(this.btnUjVagas);
            this.gbFelvitel.Controls.Add(this.btnFelvitel);
            this.gbFelvitel.Location = new System.Drawing.Point(874, 136);
            this.gbFelvitel.Name = "gbFelvitel";
            this.gbFelvitel.Size = new System.Drawing.Size(428, 314);
            this.gbFelvitel.TabIndex = 6;
            this.gbFelvitel.TabStop = false;
            this.gbFelvitel.Text = "Új elem felvitele";
            // 
            // lbVagaslista
            // 
            this.lbVagaslista.FormattingEnabled = true;
            this.lbVagaslista.ItemHeight = 20;
            this.lbVagaslista.Location = new System.Drawing.Point(103, 127);
            this.lbVagaslista.Name = "lbVagaslista";
            this.lbVagaslista.Size = new System.Drawing.Size(310, 124);
            this.lbVagaslista.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy. MM. dd. HH:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(103, 54);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(310, 27);
            this.dtpDate.TabIndex = 8;
            // 
            // lblVagaslista
            // 
            this.lblVagaslista.Location = new System.Drawing.Point(6, 96);
            this.lblVagaslista.Name = "lblVagaslista";
            this.lblVagaslista.Size = new System.Drawing.Size(91, 25);
            this.lblVagaslista.TabIndex = 6;
            this.lblVagaslista.Text = "Vágáslista:";
            this.lblVagaslista.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDatum
            // 
            this.lblDatum.Location = new System.Drawing.Point(6, 56);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(91, 25);
            this.lblDatum.TabIndex = 6;
            this.lblDatum.Text = "Dátum:";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNev
            // 
            this.lblNev.Location = new System.Drawing.Point(6, 23);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(91, 25);
            this.lblNev.TabIndex = 6;
            this.lblNev.Text = "Név:";
            this.lblNev.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(103, 21);
            this.txtNev.MaxLength = 50;
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(310, 27);
            this.txtNev.TabIndex = 5;
            // 
            // btnVagasEltavolitasa
            // 
            this.btnVagasEltavolitasa.Location = new System.Drawing.Point(261, 92);
            this.btnVagasEltavolitasa.Name = "btnVagasEltavolitasa";
            this.btnVagasEltavolitasa.Size = new System.Drawing.Size(152, 29);
            this.btnVagasEltavolitasa.TabIndex = 2;
            this.btnVagasEltavolitasa.Text = "Vágás eltávolítása";
            this.btnVagasEltavolitasa.UseVisualStyleBackColor = true;
            // 
            // btnUjVagas
            // 
            this.btnUjVagas.Location = new System.Drawing.Point(103, 92);
            this.btnUjVagas.Name = "btnUjVagas";
            this.btnUjVagas.Size = new System.Drawing.Size(152, 29);
            this.btnUjVagas.TabIndex = 2;
            this.btnUjVagas.Text = "Új vágás";
            this.btnUjVagas.UseVisualStyleBackColor = true;
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(319, 267);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(94, 29);
            this.btnFelvitel.TabIndex = 2;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // dgwBevetelezes
            // 
            this.dgwBevetelezes.AllowUserToAddRows = false;
            this.dgwBevetelezes.AllowUserToDeleteRows = false;
            this.dgwBevetelezes.AllowUserToOrderColumns = true;
            this.dgwBevetelezes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwBevetelezes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBevetelezes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teljesitett,
            this.rendelo_nev,
            this.datum,
            this.surgosseg,
            this.vagaslista});
            this.dgwBevetelezes.Location = new System.Drawing.Point(12, 136);
            this.dgwBevetelezes.Name = "dgwBevetelezes";
            this.dgwBevetelezes.ReadOnly = true;
            this.dgwBevetelezes.RowHeadersVisible = false;
            this.dgwBevetelezes.RowHeadersWidth = 51;
            this.dgwBevetelezes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBevetelezes.Size = new System.Drawing.Size(856, 314);
            this.dgwBevetelezes.TabIndex = 5;
            // 
            // teljesitett
            // 
            this.teljesitett.HeaderText = "Teljesített";
            this.teljesitett.MinimumWidth = 6;
            this.teljesitett.Name = "teljesitett";
            this.teljesitett.ReadOnly = true;
            this.teljesitett.Width = 79;
            // 
            // rendelo_nev
            // 
            this.rendelo_nev.HeaderText = "Rendelő név";
            this.rendelo_nev.MinimumWidth = 6;
            this.rendelo_nev.Name = "rendelo_nev";
            this.rendelo_nev.ReadOnly = true;
            this.rendelo_nev.Width = 110;
            // 
            // datum
            // 
            this.datum.HeaderText = "Dátum";
            this.datum.MinimumWidth = 6;
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            this.datum.Width = 83;
            // 
            // surgosseg
            // 
            this.surgosseg.HeaderText = "Sürgősség";
            this.surgosseg.MinimumWidth = 6;
            this.surgosseg.Name = "surgosseg";
            this.surgosseg.ReadOnly = true;
            this.surgosseg.Width = 106;
            // 
            // vagaslista
            // 
            this.vagaslista.HeaderText = "Vágáslista (db x hossz x szálanyag)";
            this.vagaslista.MinimumWidth = 6;
            this.vagaslista.Name = "vagaslista";
            this.vagaslista.ReadOnly = true;
            this.vagaslista.Width = 157;
            // 
            // Rendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 462);
            this.Controls.Add(this.gbSzurok);
            this.Controls.Add(this.gbFelvitel);
            this.Controls.Add(this.dgwBevetelezes);
            this.Name = "Rendeles";
            this.Text = "Rendelés";
            this.gbSzurok.ResumeLayout(false);
            this.gbSzurok.PerformLayout();
            this.gbFelvitel.ResumeLayout(false);
            this.gbFelvitel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBevetelezes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgwBevetelezes;
        private System.Windows.Forms.ListBox lbVagaslista;
        private System.Windows.Forms.Label lblVagaslista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn teljesitett;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendelo_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn surgosseg;
        private System.Windows.Forms.DataGridViewComboBoxColumn vagaslista;
        private System.Windows.Forms.Button btnVagasEltavolitasa;
        private System.Windows.Forms.Button btnUjVagas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}