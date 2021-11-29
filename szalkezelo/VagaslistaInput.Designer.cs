
namespace szalkezelo
{
    partial class VagaslistaInput
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
            this.gbFelvitel = new System.Windows.Forms.GroupBox();
            this.nudHossz = new System.Windows.Forms.NumericUpDown();
            this.lblHossz = new System.Windows.Forms.Label();
            this.lblDb = new System.Windows.Forms.Label();
            this.btnUjSzalanyag = new System.Windows.Forms.Button();
            this.cbSzalanyag = new System.Windows.Forms.ComboBox();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.nudDb = new System.Windows.Forms.NumericUpDown();
            this.chkFeluletkezeles = new System.Windows.Forms.CheckBox();
            this.gbFelvitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHossz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMeret
            // 
            this.lblMeret.Location = new System.Drawing.Point(6, 123);
            this.lblMeret.Name = "lblMeret";
            this.lblMeret.Size = new System.Drawing.Size(119, 25);
            this.lblMeret.TabIndex = 1;
            this.lblMeret.Text = "Szálanyag:";
            this.lblMeret.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbFelvitel
            // 
            this.gbFelvitel.Controls.Add(this.chkFeluletkezeles);
            this.gbFelvitel.Controls.Add(this.nudDb);
            this.gbFelvitel.Controls.Add(this.nudHossz);
            this.gbFelvitel.Controls.Add(this.lblHossz);
            this.gbFelvitel.Controls.Add(this.lblDb);
            this.gbFelvitel.Controls.Add(this.btnUjSzalanyag);
            this.gbFelvitel.Controls.Add(this.cbSzalanyag);
            this.gbFelvitel.Controls.Add(this.btnFelvitel);
            this.gbFelvitel.Controls.Add(this.lblMeret);
            this.gbFelvitel.Location = new System.Drawing.Point(12, 12);
            this.gbFelvitel.Name = "gbFelvitel";
            this.gbFelvitel.Size = new System.Drawing.Size(481, 227);
            this.gbFelvitel.TabIndex = 3;
            this.gbFelvitel.TabStop = false;
            this.gbFelvitel.Text = "Új elem felvitele";
            // 
            // nudHossz
            // 
            this.nudHossz.Location = new System.Drawing.Point(131, 54);
            this.nudHossz.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHossz.Name = "nudHossz";
            this.nudHossz.Size = new System.Drawing.Size(282, 27);
            this.nudHossz.TabIndex = 7;
            // 
            // lblHossz
            // 
            this.lblHossz.Location = new System.Drawing.Point(6, 56);
            this.lblHossz.Name = "lblHossz";
            this.lblHossz.Size = new System.Drawing.Size(119, 25);
            this.lblHossz.TabIndex = 6;
            this.lblHossz.Text = "Hossz:";
            this.lblHossz.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDb
            // 
            this.lblDb.Location = new System.Drawing.Point(6, 23);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(119, 25);
            this.lblDb.TabIndex = 6;
            this.lblDb.Text = "Mennyiség:";
            this.lblDb.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnUjSzalanyag
            // 
            this.btnUjSzalanyag.Location = new System.Drawing.Point(419, 119);
            this.btnUjSzalanyag.Name = "btnUjSzalanyag";
            this.btnUjSzalanyag.Size = new System.Drawing.Size(53, 29);
            this.btnUjSzalanyag.TabIndex = 4;
            this.btnUjSzalanyag.Text = "Új";
            this.btnUjSzalanyag.UseVisualStyleBackColor = true;
            this.btnUjSzalanyag.Click += new System.EventHandler(this.btnUjSzalanyag_Click);
            // 
            // cbSzalanyag
            // 
            this.cbSzalanyag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSzalanyag.FormattingEnabled = true;
            this.cbSzalanyag.Location = new System.Drawing.Point(131, 120);
            this.cbSzalanyag.Name = "cbSzalanyag";
            this.cbSzalanyag.Size = new System.Drawing.Size(282, 28);
            this.cbSzalanyag.TabIndex = 3;
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(319, 181);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(94, 29);
            this.btnFelvitel.TabIndex = 2;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // nudDb
            // 
            this.nudDb.Location = new System.Drawing.Point(131, 21);
            this.nudDb.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDb.Name = "nudDb";
            this.nudDb.Size = new System.Drawing.Size(282, 27);
            this.nudDb.TabIndex = 7;
            // 
            // chkFeluletkezeles
            // 
            this.chkFeluletkezeles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFeluletkezeles.Location = new System.Drawing.Point(6, 87);
            this.chkFeluletkezeles.Name = "chkFeluletkezeles";
            this.chkFeluletkezeles.Size = new System.Drawing.Size(142, 30);
            this.chkFeluletkezeles.TabIndex = 11;
            this.chkFeluletkezeles.Text = "Felületkezelés:";
            this.chkFeluletkezeles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFeluletkezeles.UseVisualStyleBackColor = true;
            // 
            // VagaslistaInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 249);
            this.Controls.Add(this.gbFelvitel);
            this.Name = "VagaslistaInput";
            this.Text = "Bevételezés";
            this.Load += new System.EventHandler(this.Bevetelezes_Load);
            this.gbFelvitel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHossz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMeret;
        private System.Windows.Forms.GroupBox gbFelvitel;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.ComboBox cbSzalanyag;
        private System.Windows.Forms.Button btnUjSzalanyag;
        private System.Windows.Forms.NumericUpDown nudHossz;
        private System.Windows.Forms.Label lblHossz;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.CheckBox chkFeluletkezeles;
        private System.Windows.Forms.NumericUpDown nudDb;
    }
}