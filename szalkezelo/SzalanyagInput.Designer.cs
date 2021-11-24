﻿
namespace szalkezelo
{
    partial class SzalanyagInput
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
            this.dgwSzalanyag = new System.Windows.Forms.DataGridView();
            this.gbFelvitel = new System.Windows.Forms.GroupBox();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.meret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anyag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minoseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMeret = new System.Windows.Forms.ComboBox();
            this.lblAnyag = new System.Windows.Forms.Label();
            this.cbAnyag = new System.Windows.Forms.ComboBox();
            this.lblMinoseg = new System.Windows.Forms.Label();
            this.lblTipus = new System.Windows.Forms.Label();
            this.cbMinoseg = new System.Windows.Forms.ComboBox();
            this.cbTipus = new System.Windows.Forms.ComboBox();
            this.btnUjMeret = new System.Windows.Forms.Button();
            this.btnUjAnyag = new System.Windows.Forms.Button();
            this.btnUjMinoseg = new System.Windows.Forms.Button();
            this.btnUjTipus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSzalanyag)).BeginInit();
            this.gbFelvitel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMeret
            // 
            this.lblMeret.Location = new System.Drawing.Point(11, 29);
            this.lblMeret.Name = "lblMeret";
            this.lblMeret.Size = new System.Drawing.Size(109, 25);
            this.lblMeret.TabIndex = 1;
            this.lblMeret.Text = "Méret:";
            this.lblMeret.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgwSzalanyag
            // 
            this.dgwSzalanyag.AllowUserToAddRows = false;
            this.dgwSzalanyag.AllowUserToDeleteRows = false;
            this.dgwSzalanyag.AllowUserToOrderColumns = true;
            this.dgwSzalanyag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSzalanyag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meret,
            this.anyag,
            this.minoseg,
            this.tipus});
            this.dgwSzalanyag.Location = new System.Drawing.Point(12, 12);
            this.dgwSzalanyag.Name = "dgwSzalanyag";
            this.dgwSzalanyag.ReadOnly = true;
            this.dgwSzalanyag.RowHeadersWidth = 51;
            this.dgwSzalanyag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSzalanyag.Size = new System.Drawing.Size(559, 314);
            this.dgwSzalanyag.TabIndex = 2;
            // 
            // gbFelvitel
            // 
            this.gbFelvitel.Controls.Add(this.btnUjTipus);
            this.gbFelvitel.Controls.Add(this.btnUjMinoseg);
            this.gbFelvitel.Controls.Add(this.btnUjAnyag);
            this.gbFelvitel.Controls.Add(this.btnUjMeret);
            this.gbFelvitel.Controls.Add(this.cbTipus);
            this.gbFelvitel.Controls.Add(this.cbAnyag);
            this.gbFelvitel.Controls.Add(this.cbMinoseg);
            this.gbFelvitel.Controls.Add(this.lblTipus);
            this.gbFelvitel.Controls.Add(this.cbMeret);
            this.gbFelvitel.Controls.Add(this.lblAnyag);
            this.gbFelvitel.Controls.Add(this.lblMinoseg);
            this.gbFelvitel.Controls.Add(this.btnFelvitel);
            this.gbFelvitel.Controls.Add(this.lblMeret);
            this.gbFelvitel.Location = new System.Drawing.Point(577, 12);
            this.gbFelvitel.Name = "gbFelvitel";
            this.gbFelvitel.Size = new System.Drawing.Size(412, 218);
            this.gbFelvitel.TabIndex = 3;
            this.gbFelvitel.TabStop = false;
            this.gbFelvitel.Text = "Új elem felvitele";
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(244, 174);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(94, 29);
            this.btnFelvitel.TabIndex = 2;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // meret
            // 
            this.meret.HeaderText = "Méret";
            this.meret.MinimumWidth = 6;
            this.meret.Name = "meret";
            this.meret.ReadOnly = true;
            this.meret.Width = 125;
            // 
            // anyag
            // 
            this.anyag.HeaderText = "Anyag";
            this.anyag.MinimumWidth = 6;
            this.anyag.Name = "anyag";
            this.anyag.ReadOnly = true;
            this.anyag.Width = 125;
            // 
            // minoseg
            // 
            this.minoseg.HeaderText = "Anyagminőség";
            this.minoseg.MinimumWidth = 6;
            this.minoseg.Name = "minoseg";
            this.minoseg.ReadOnly = true;
            this.minoseg.Width = 125;
            // 
            // tipus
            // 
            this.tipus.HeaderText = "Típus";
            this.tipus.MinimumWidth = 6;
            this.tipus.Name = "tipus";
            this.tipus.ReadOnly = true;
            this.tipus.Width = 125;
            // 
            // cbMeret
            // 
            this.cbMeret.FormattingEnabled = true;
            this.cbMeret.Location = new System.Drawing.Point(126, 26);
            this.cbMeret.Name = "cbMeret";
            this.cbMeret.Size = new System.Drawing.Size(212, 28);
            this.cbMeret.TabIndex = 3;
            // 
            // lblAnyag
            // 
            this.lblAnyag.Location = new System.Drawing.Point(11, 63);
            this.lblAnyag.Name = "lblAnyag";
            this.lblAnyag.Size = new System.Drawing.Size(109, 25);
            this.lblAnyag.TabIndex = 1;
            this.lblAnyag.Text = "Anyag:";
            this.lblAnyag.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbAnyag
            // 
            this.cbAnyag.FormattingEnabled = true;
            this.cbAnyag.Location = new System.Drawing.Point(126, 60);
            this.cbAnyag.Name = "cbAnyag";
            this.cbAnyag.Size = new System.Drawing.Size(212, 28);
            this.cbAnyag.TabIndex = 3;
            // 
            // lblMinoseg
            // 
            this.lblMinoseg.Location = new System.Drawing.Point(11, 97);
            this.lblMinoseg.Name = "lblMinoseg";
            this.lblMinoseg.Size = new System.Drawing.Size(109, 25);
            this.lblMinoseg.TabIndex = 1;
            this.lblMinoseg.Text = "Anyagminőség:";
            this.lblMinoseg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTipus
            // 
            this.lblTipus.Location = new System.Drawing.Point(11, 131);
            this.lblTipus.Name = "lblTipus";
            this.lblTipus.Size = new System.Drawing.Size(109, 25);
            this.lblTipus.TabIndex = 1;
            this.lblTipus.Text = "Típus:";
            this.lblTipus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbMinoseg
            // 
            this.cbMinoseg.FormattingEnabled = true;
            this.cbMinoseg.Location = new System.Drawing.Point(126, 94);
            this.cbMinoseg.Name = "cbMinoseg";
            this.cbMinoseg.Size = new System.Drawing.Size(212, 28);
            this.cbMinoseg.TabIndex = 3;
            // 
            // cbTipus
            // 
            this.cbTipus.FormattingEnabled = true;
            this.cbTipus.Location = new System.Drawing.Point(126, 128);
            this.cbTipus.Name = "cbTipus";
            this.cbTipus.Size = new System.Drawing.Size(212, 28);
            this.cbTipus.TabIndex = 3;
            // 
            // btnUjMeret
            // 
            this.btnUjMeret.Location = new System.Drawing.Point(344, 25);
            this.btnUjMeret.Name = "btnUjMeret";
            this.btnUjMeret.Size = new System.Drawing.Size(53, 29);
            this.btnUjMeret.TabIndex = 4;
            this.btnUjMeret.Text = "Új";
            this.btnUjMeret.UseVisualStyleBackColor = true;
            this.btnUjMeret.Click += new System.EventHandler(this.btnUjMeret_Click);
            // 
            // btnUjAnyag
            // 
            this.btnUjAnyag.Location = new System.Drawing.Point(344, 59);
            this.btnUjAnyag.Name = "btnUjAnyag";
            this.btnUjAnyag.Size = new System.Drawing.Size(53, 29);
            this.btnUjAnyag.TabIndex = 4;
            this.btnUjAnyag.Text = "Új";
            this.btnUjAnyag.UseVisualStyleBackColor = true;
            this.btnUjAnyag.Click += new System.EventHandler(this.btnUjAnyag_Click);
            // 
            // btnUjMinoseg
            // 
            this.btnUjMinoseg.Location = new System.Drawing.Point(344, 93);
            this.btnUjMinoseg.Name = "btnUjMinoseg";
            this.btnUjMinoseg.Size = new System.Drawing.Size(53, 29);
            this.btnUjMinoseg.TabIndex = 4;
            this.btnUjMinoseg.Text = "Új";
            this.btnUjMinoseg.UseVisualStyleBackColor = true;
            this.btnUjMinoseg.Click += new System.EventHandler(this.btnUjMinoseg_Click);
            // 
            // btnUjTipus
            // 
            this.btnUjTipus.Location = new System.Drawing.Point(344, 127);
            this.btnUjTipus.Name = "btnUjTipus";
            this.btnUjTipus.Size = new System.Drawing.Size(53, 29);
            this.btnUjTipus.TabIndex = 4;
            this.btnUjTipus.Text = "Új";
            this.btnUjTipus.UseVisualStyleBackColor = true;
            this.btnUjTipus.Click += new System.EventHandler(this.btnUjTipus_Click);
            // 
            // SzalanyagInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 338);
            this.Controls.Add(this.gbFelvitel);
            this.Controls.Add(this.dgwSzalanyag);
            this.Name = "SzalanyagInput";
            this.Text = "SimpleInput";
            this.Load += new System.EventHandler(this.SimpleInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSzalanyag)).EndInit();
            this.gbFelvitel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMeret;
        private System.Windows.Forms.DataGridView dgwSzalanyag;
        private System.Windows.Forms.GroupBox gbFelvitel;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn meret;
        private System.Windows.Forms.DataGridViewTextBoxColumn anyag;
        private System.Windows.Forms.DataGridViewTextBoxColumn minoseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipus;
        private System.Windows.Forms.ComboBox cbMeret;
        private System.Windows.Forms.Button btnUjTipus;
        private System.Windows.Forms.Button btnUjMinoseg;
        private System.Windows.Forms.Button btnUjAnyag;
        private System.Windows.Forms.Button btnUjMeret;
        private System.Windows.Forms.ComboBox cbTipus;
        private System.Windows.Forms.ComboBox cbAnyag;
        private System.Windows.Forms.ComboBox cbMinoseg;
        private System.Windows.Forms.Label lblTipus;
        private System.Windows.Forms.Label lblAnyag;
        private System.Windows.Forms.Label lblMinoseg;
    }
}