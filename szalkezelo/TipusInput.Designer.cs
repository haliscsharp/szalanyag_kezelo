
namespace szalkezelo
{
    partial class TipusInput
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
            this.txtNev = new System.Windows.Forms.TextBox();
            this.lblNev = new System.Windows.Forms.Label();
            this.dgwInput = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kellSzelesseg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kellMagassag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kellVastagsag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kellAtmero = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbFelvitel = new System.Windows.Forms.GroupBox();
            this.chkKellAtmero = new System.Windows.Forms.CheckBox();
            this.chkKellMagassag = new System.Windows.Forms.CheckBox();
            this.chkKellVastagsag = new System.Windows.Forms.CheckBox();
            this.chkKellSzelesseg = new System.Windows.Forms.CheckBox();
            this.btnFelvitel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInput)).BeginInit();
            this.gbFelvitel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(131, 33);
            this.txtNev.MaxLength = 50;
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(149, 27);
            this.txtNev.TabIndex = 0;
            // 
            // lblNev
            // 
            this.lblNev.Location = new System.Drawing.Point(12, 36);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(113, 25);
            this.lblNev.TabIndex = 1;
            this.lblNev.Text = "Név:";
            this.lblNev.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgwInput
            // 
            this.dgwInput.AllowUserToAddRows = false;
            this.dgwInput.AllowUserToDeleteRows = false;
            this.dgwInput.AllowUserToOrderColumns = true;
            this.dgwInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.kellSzelesseg,
            this.kellMagassag,
            this.kellVastagsag,
            this.kellAtmero});
            this.dgwInput.Location = new System.Drawing.Point(12, 12);
            this.dgwInput.Name = "dgwInput";
            this.dgwInput.ReadOnly = true;
            this.dgwInput.RowHeadersVisible = false;
            this.dgwInput.RowHeadersWidth = 51;
            this.dgwInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwInput.Size = new System.Drawing.Size(576, 314);
            this.dgwInput.TabIndex = 2;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.MinimumWidth = 6;
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 64;
            // 
            // kellSzelesseg
            // 
            this.kellSzelesseg.HeaderText = "Kell szélesség";
            this.kellSzelesseg.MinimumWidth = 6;
            this.kellSzelesseg.Name = "kellSzelesseg";
            this.kellSzelesseg.ReadOnly = true;
            this.kellSzelesseg.Width = 106;
            // 
            // kellMagassag
            // 
            this.kellMagassag.HeaderText = "Kell magasság";
            this.kellMagassag.MinimumWidth = 6;
            this.kellMagassag.Name = "kellMagassag";
            this.kellMagassag.ReadOnly = true;
            this.kellMagassag.Width = 111;
            // 
            // kellVastagsag
            // 
            this.kellVastagsag.HeaderText = "Kell vastagság";
            this.kellVastagsag.MinimumWidth = 6;
            this.kellVastagsag.Name = "kellVastagsag";
            this.kellVastagsag.ReadOnly = true;
            this.kellVastagsag.Width = 110;
            // 
            // kellAtmero
            // 
            this.kellAtmero.HeaderText = "Kell átmérő";
            this.kellAtmero.MinimumWidth = 6;
            this.kellAtmero.Name = "kellAtmero";
            this.kellAtmero.ReadOnly = true;
            this.kellAtmero.Width = 92;
            // 
            // gbFelvitel
            // 
            this.gbFelvitel.Controls.Add(this.chkKellAtmero);
            this.gbFelvitel.Controls.Add(this.chkKellMagassag);
            this.gbFelvitel.Controls.Add(this.chkKellVastagsag);
            this.gbFelvitel.Controls.Add(this.chkKellSzelesseg);
            this.gbFelvitel.Controls.Add(this.btnFelvitel);
            this.gbFelvitel.Controls.Add(this.lblNev);
            this.gbFelvitel.Controls.Add(this.txtNev);
            this.gbFelvitel.Location = new System.Drawing.Point(594, 12);
            this.gbFelvitel.Name = "gbFelvitel";
            this.gbFelvitel.Size = new System.Drawing.Size(302, 273);
            this.gbFelvitel.TabIndex = 3;
            this.gbFelvitel.TabStop = false;
            this.gbFelvitel.Text = "Új elem felvitele";
            // 
            // chkKellAtmero
            // 
            this.chkKellAtmero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKellAtmero.Location = new System.Drawing.Point(12, 174);
            this.chkKellAtmero.Name = "chkKellAtmero";
            this.chkKellAtmero.Size = new System.Drawing.Size(136, 30);
            this.chkKellAtmero.TabIndex = 3;
            this.chkKellAtmero.Text = "Kell átmérő:";
            this.chkKellAtmero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKellAtmero.UseVisualStyleBackColor = true;
            this.chkKellAtmero.CheckedChanged += new System.EventHandler(this.chkKellAtmero_CheckedChanged);
            // 
            // chkKellMagassag
            // 
            this.chkKellMagassag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKellMagassag.Location = new System.Drawing.Point(12, 102);
            this.chkKellMagassag.Name = "chkKellMagassag";
            this.chkKellMagassag.Size = new System.Drawing.Size(136, 30);
            this.chkKellMagassag.TabIndex = 3;
            this.chkKellMagassag.Text = "Kell magasság:";
            this.chkKellMagassag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKellMagassag.UseVisualStyleBackColor = true;
            this.chkKellMagassag.CheckedChanged += new System.EventHandler(this.chkKellMagassag_CheckedChanged);
            // 
            // chkKellVastagsag
            // 
            this.chkKellVastagsag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKellVastagsag.Location = new System.Drawing.Point(12, 138);
            this.chkKellVastagsag.Name = "chkKellVastagsag";
            this.chkKellVastagsag.Size = new System.Drawing.Size(136, 30);
            this.chkKellVastagsag.TabIndex = 3;
            this.chkKellVastagsag.Text = "Kell vastagság:";
            this.chkKellVastagsag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKellVastagsag.UseVisualStyleBackColor = true;
            this.chkKellVastagsag.CheckedChanged += new System.EventHandler(this.chkKellVastagsag_CheckedChanged);
            // 
            // chkKellSzelesseg
            // 
            this.chkKellSzelesseg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKellSzelesseg.Location = new System.Drawing.Point(12, 66);
            this.chkKellSzelesseg.Name = "chkKellSzelesseg";
            this.chkKellSzelesseg.Size = new System.Drawing.Size(136, 30);
            this.chkKellSzelesseg.TabIndex = 3;
            this.chkKellSzelesseg.Text = "Kell szélesség:";
            this.chkKellSzelesseg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKellSzelesseg.UseVisualStyleBackColor = true;
            this.chkKellSzelesseg.CheckedChanged += new System.EventHandler(this.chkKellSzelesseg_CheckedChanged);
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(186, 218);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(94, 29);
            this.btnFelvitel.TabIndex = 2;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // TipusInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 338);
            this.Controls.Add(this.gbFelvitel);
            this.Controls.Add(this.dgwInput);
            this.Name = "TipusInput";
            this.Text = "Adatfelvétel";
            this.Load += new System.EventHandler(this.SimpleInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInput)).EndInit();
            this.gbFelvitel.ResumeLayout(false);
            this.gbFelvitel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.DataGridView dgwInput;
        private System.Windows.Forms.GroupBox gbFelvitel;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kellSzelesseg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kellMagassag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kellVastagsag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kellAtmero;
        private System.Windows.Forms.CheckBox chkKellMagassag;
        private System.Windows.Forms.CheckBox chkKellSzelesseg;
        private System.Windows.Forms.CheckBox chkKellAtmero;
        private System.Windows.Forms.CheckBox chkKellVastagsag;
    }
}