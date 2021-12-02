
namespace szalkezelo
{
    partial class MeretInput
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
            this.dgwInput = new System.Windows.Forms.DataGridView();
            this.szelesseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magassag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vastagsag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atmero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFelvitel = new System.Windows.Forms.GroupBox();
            this.nudAtmero = new System.Windows.Forms.NumericUpDown();
            this.nudMagassag = new System.Windows.Forms.NumericUpDown();
            this.nudVastagsag = new System.Windows.Forms.NumericUpDown();
            this.nudSzelesseg = new System.Windows.Forms.NumericUpDown();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSzelesseg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInput)).BeginInit();
            this.gbFelvitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtmero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagassag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVastagsag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzelesseg)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwInput
            // 
            this.dgwInput.AllowUserToAddRows = false;
            this.dgwInput.AllowUserToDeleteRows = false;
            this.dgwInput.AllowUserToOrderColumns = true;
            this.dgwInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.szelesseg,
            this.magassag,
            this.vastagsag,
            this.atmero});
            this.dgwInput.Location = new System.Drawing.Point(12, 12);
            this.dgwInput.MultiSelect = false;
            this.dgwInput.Name = "dgwInput";
            this.dgwInput.ReadOnly = true;
            this.dgwInput.RowHeadersWidth = 51;
            this.dgwInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwInput.Size = new System.Drawing.Size(621, 314);
            this.dgwInput.TabIndex = 2;
            // 
            // szelesseg
            // 
            this.szelesseg.HeaderText = "Szélesség";
            this.szelesseg.MinimumWidth = 6;
            this.szelesseg.Name = "szelesseg";
            this.szelesseg.ReadOnly = true;
            this.szelesseg.Width = 102;
            // 
            // magassag
            // 
            this.magassag.HeaderText = "Magasság";
            this.magassag.MinimumWidth = 6;
            this.magassag.Name = "magassag";
            this.magassag.ReadOnly = true;
            this.magassag.Width = 105;
            // 
            // vastagsag
            // 
            this.vastagsag.HeaderText = "Vastagság";
            this.vastagsag.MinimumWidth = 6;
            this.vastagsag.Name = "vastagsag";
            this.vastagsag.ReadOnly = true;
            this.vastagsag.Width = 105;
            // 
            // atmero
            // 
            this.atmero.HeaderText = "Átmérő";
            this.atmero.MinimumWidth = 6;
            this.atmero.Name = "atmero";
            this.atmero.ReadOnly = true;
            this.atmero.Width = 88;
            // 
            // gbFelvitel
            // 
            this.gbFelvitel.Controls.Add(this.nudAtmero);
            this.gbFelvitel.Controls.Add(this.nudMagassag);
            this.gbFelvitel.Controls.Add(this.nudVastagsag);
            this.gbFelvitel.Controls.Add(this.nudSzelesseg);
            this.gbFelvitel.Controls.Add(this.btnFelvitel);
            this.gbFelvitel.Controls.Add(this.label4);
            this.gbFelvitel.Controls.Add(this.label2);
            this.gbFelvitel.Controls.Add(this.label3);
            this.gbFelvitel.Controls.Add(this.lblSzelesseg);
            this.gbFelvitel.Location = new System.Drawing.Point(639, 12);
            this.gbFelvitel.Name = "gbFelvitel";
            this.gbFelvitel.Size = new System.Drawing.Size(302, 229);
            this.gbFelvitel.TabIndex = 3;
            this.gbFelvitel.TabStop = false;
            this.gbFelvitel.Text = "Új elem felvitele";
            // 
            // nudAtmero
            // 
            this.nudAtmero.Location = new System.Drawing.Point(119, 125);
            this.nudAtmero.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAtmero.Name = "nudAtmero";
            this.nudAtmero.Size = new System.Drawing.Size(159, 27);
            this.nudAtmero.TabIndex = 3;
            this.nudAtmero.ValueChanged += new System.EventHandler(this.nudAtmero_ValueChanged);
            // 
            // nudMagassag
            // 
            this.nudMagassag.Location = new System.Drawing.Point(119, 59);
            this.nudMagassag.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMagassag.Name = "nudMagassag";
            this.nudMagassag.Size = new System.Drawing.Size(159, 27);
            this.nudMagassag.TabIndex = 3;
            this.nudMagassag.ValueChanged += new System.EventHandler(this.nudMagassag_ValueChanged);
            // 
            // nudVastagsag
            // 
            this.nudVastagsag.Location = new System.Drawing.Point(119, 92);
            this.nudVastagsag.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudVastagsag.Name = "nudVastagsag";
            this.nudVastagsag.Size = new System.Drawing.Size(159, 27);
            this.nudVastagsag.TabIndex = 3;
            this.nudVastagsag.ValueChanged += new System.EventHandler(this.nudVastagsag_ValueChanged);
            // 
            // nudSzelesseg
            // 
            this.nudSzelesseg.Location = new System.Drawing.Point(119, 26);
            this.nudSzelesseg.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSzelesseg.Name = "nudSzelesseg";
            this.nudSzelesseg.Size = new System.Drawing.Size(159, 27);
            this.nudSzelesseg.TabIndex = 3;
            this.nudSzelesseg.ValueChanged += new System.EventHandler(this.nudSzelesseg_ValueChanged);
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(184, 177);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(94, 29);
            this.btnFelvitel.TabIndex = 2;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Átmérő:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Magasság:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vastagság:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSzelesseg
            // 
            this.lblSzelesseg.Location = new System.Drawing.Point(4, 28);
            this.lblSzelesseg.Name = "lblSzelesseg";
            this.lblSzelesseg.Size = new System.Drawing.Size(109, 25);
            this.lblSzelesseg.TabIndex = 1;
            this.lblSzelesseg.Text = "Szélesség:";
            this.lblSzelesseg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MeretInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 338);
            this.Controls.Add(this.gbFelvitel);
            this.Controls.Add(this.dgwInput);
            this.Name = "MeretInput";
            this.Text = "Adatfelvétel";
            this.Load += new System.EventHandler(this.SimpleInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInput)).EndInit();
            this.gbFelvitel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAtmero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagassag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVastagsag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzelesseg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwInput;
        private System.Windows.Forms.GroupBox gbFelvitel;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.NumericUpDown nudMagassag;
        private System.Windows.Forms.NumericUpDown nudSzelesseg;
        private System.Windows.Forms.NumericUpDown nudAtmero;
        private System.Windows.Forms.NumericUpDown nudVastagsag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSzelesseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn szelesseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn magassag;
        private System.Windows.Forms.DataGridViewTextBoxColumn vastagsag;
        private System.Windows.Forms.DataGridViewTextBoxColumn atmero;
    }
}