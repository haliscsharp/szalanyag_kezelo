
namespace szalkezelo
{
    partial class Bevetelezes
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
            this.lblMeret = new System.Windows.Forms.Label();
            this.dgwBevetelezes = new System.Windows.Forms.DataGridView();
            this.beszallito_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hossz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szalanyag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFelvitel = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudHossz = new System.Windows.Forms.NumericUpDown();
            this.nudDb = new System.Windows.Forms.NumericUpDown();
            this.lblHossz = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblDb = new System.Windows.Forms.Label();
            this.lblNev = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.btnUjSzalanyag = new System.Windows.Forms.Button();
            this.cbSzalanyag = new System.Windows.Forms.ComboBox();
            this.btnFelvitel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBevetelezes)).BeginInit();
            this.gbFelvitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHossz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMeret
            // 
            this.lblMeret.Location = new System.Drawing.Point(6, 123);
            this.lblMeret.Name = "lblMeret";
            this.lblMeret.Size = new System.Drawing.Size(91, 25);
            this.lblMeret.TabIndex = 1;
            this.lblMeret.Text = "Szálanyag:";
            this.lblMeret.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgwBevetelezes
            // 
            this.dgwBevetelezes.AllowUserToAddRows = false;
            this.dgwBevetelezes.AllowUserToDeleteRows = false;
            this.dgwBevetelezes.AllowUserToOrderColumns = true;
            this.dgwBevetelezes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwBevetelezes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBevetelezes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beszallito_nev,
            this.db,
            this.date,
            this.hossz,
            this.szalanyag});
            this.dgwBevetelezes.Location = new System.Drawing.Point(12, 12);
            this.dgwBevetelezes.Name = "dgwBevetelezes";
            this.dgwBevetelezes.ReadOnly = true;
            this.dgwBevetelezes.RowHeadersWidth = 51;
            this.dgwBevetelezes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBevetelezes.Size = new System.Drawing.Size(856, 314);
            this.dgwBevetelezes.TabIndex = 2;
            // 
            // beszallito_nev
            // 
            this.beszallito_nev.HeaderText = "Beszállító név";
            this.beszallito_nev.MinimumWidth = 6;
            this.beszallito_nev.Name = "beszallito_nev";
            this.beszallito_nev.ReadOnly = true;
            this.beszallito_nev.Width = 119;
            // 
            // db
            // 
            this.db.HeaderText = "Mennyiség (db)";
            this.db.MinimumWidth = 6;
            this.db.Name = "db";
            this.db.ReadOnly = true;
            this.db.Width = 129;
            // 
            // date
            // 
            this.date.HeaderText = "Dátum";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 83;
            // 
            // hossz
            // 
            this.hossz.HeaderText = "Szálanyag hossz (mm)";
            this.hossz.MinimumWidth = 6;
            this.hossz.Name = "hossz";
            this.hossz.ReadOnly = true;
            this.hossz.Width = 137;
            // 
            // szalanyag
            // 
            this.szalanyag.HeaderText = "Szálanyag";
            this.szalanyag.MinimumWidth = 6;
            this.szalanyag.Name = "szalanyag";
            this.szalanyag.ReadOnly = true;
            this.szalanyag.Width = 105;
            // 
            // gbFelvitel
            // 
            this.gbFelvitel.Controls.Add(this.dtpDate);
            this.gbFelvitel.Controls.Add(this.nudHossz);
            this.gbFelvitel.Controls.Add(this.nudDb);
            this.gbFelvitel.Controls.Add(this.lblHossz);
            this.gbFelvitel.Controls.Add(this.lblDatum);
            this.gbFelvitel.Controls.Add(this.lblDb);
            this.gbFelvitel.Controls.Add(this.lblNev);
            this.gbFelvitel.Controls.Add(this.txtNev);
            this.gbFelvitel.Controls.Add(this.btnUjSzalanyag);
            this.gbFelvitel.Controls.Add(this.cbSzalanyag);
            this.gbFelvitel.Controls.Add(this.btnFelvitel);
            this.gbFelvitel.Controls.Add(this.lblMeret);
            this.gbFelvitel.Location = new System.Drawing.Point(874, 12);
            this.gbFelvitel.Name = "gbFelvitel";
            this.gbFelvitel.Size = new System.Drawing.Size(498, 251);
            this.gbFelvitel.TabIndex = 3;
            this.gbFelvitel.TabStop = false;
            this.gbFelvitel.Text = "Új elem felvitele";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy. MM. dd. HH:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(103, 87);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(329, 27);
            this.dtpDate.TabIndex = 8;
            // 
            // nudHossz
            // 
            this.nudHossz.Location = new System.Drawing.Point(103, 154);
            this.nudHossz.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudHossz.Name = "nudHossz";
            this.nudHossz.Size = new System.Drawing.Size(329, 27);
            this.nudHossz.TabIndex = 7;
            // 
            // nudDb
            // 
            this.nudDb.Location = new System.Drawing.Point(103, 54);
            this.nudDb.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDb.Name = "nudDb";
            this.nudDb.Size = new System.Drawing.Size(329, 27);
            this.nudDb.TabIndex = 7;
            // 
            // lblHossz
            // 
            this.lblHossz.Location = new System.Drawing.Point(6, 156);
            this.lblHossz.Name = "lblHossz";
            this.lblHossz.Size = new System.Drawing.Size(91, 25);
            this.lblHossz.TabIndex = 6;
            this.lblHossz.Text = "Hossz (mm)";
            this.lblHossz.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDatum
            // 
            this.lblDatum.Location = new System.Drawing.Point(6, 89);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(91, 25);
            this.lblDatum.TabIndex = 6;
            this.lblDatum.Text = "Dátum:";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDb
            // 
            this.lblDb.Location = new System.Drawing.Point(6, 56);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(91, 25);
            this.lblDb.TabIndex = 6;
            this.lblDb.Text = "Mennyiség:";
            this.lblDb.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(329, 27);
            this.txtNev.TabIndex = 5;
            // 
            // btnUjSzalanyag
            // 
            this.btnUjSzalanyag.Location = new System.Drawing.Point(438, 119);
            this.btnUjSzalanyag.Name = "btnUjSzalanyag";
            this.btnUjSzalanyag.Size = new System.Drawing.Size(53, 29);
            this.btnUjSzalanyag.TabIndex = 4;
            this.btnUjSzalanyag.Text = "Új";
            this.btnUjSzalanyag.UseVisualStyleBackColor = true;
            this.btnUjSzalanyag.Click += new System.EventHandler(this.btnUjSzalanyag_Click);
            // 
            // cbSzalanyag
            // 
            this.cbSzalanyag.FormattingEnabled = true;
            this.cbSzalanyag.Location = new System.Drawing.Point(103, 120);
            this.cbSzalanyag.Name = "cbSzalanyag";
            this.cbSzalanyag.Size = new System.Drawing.Size(329, 28);
            this.cbSzalanyag.TabIndex = 3;
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(338, 200);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(94, 29);
            this.btnFelvitel.TabIndex = 2;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // Bevetelezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 338);
            this.Controls.Add(this.gbFelvitel);
            this.Controls.Add(this.dgwBevetelezes);
            this.Name = "Bevetelezes";
            this.Text = "Bevételezés";
            this.Load += new System.EventHandler(this.SimpleInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBevetelezes)).EndInit();
            this.gbFelvitel.ResumeLayout(false);
            this.gbFelvitel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHossz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMeret;
        private System.Windows.Forms.DataGridView dgwBevetelezes;
        private System.Windows.Forms.GroupBox gbFelvitel;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.ComboBox cbSzalanyag;
        private System.Windows.Forms.Button btnUjSzalanyag;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown nudDb;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn beszallito_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn db;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn hossz;
        private System.Windows.Forms.DataGridViewTextBoxColumn szalanyag;
        private System.Windows.Forms.NumericUpDown nudHossz;
        private System.Windows.Forms.Label lblHossz;
    }
}