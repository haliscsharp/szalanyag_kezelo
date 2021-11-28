
namespace szalkezelo
{
    partial class AnyagInput
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
            this.dgwAnyag = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rovid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFelvitel = new System.Windows.Forms.GroupBox();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.lblRovid = new System.Windows.Forms.Label();
            this.txtRovid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAnyag)).BeginInit();
            this.gbFelvitel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(121, 33);
            this.txtNev.MaxLength = 50;
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(159, 27);
            this.txtNev.TabIndex = 0;
            // 
            // lblNev
            // 
            this.lblNev.Location = new System.Drawing.Point(6, 36);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(109, 25);
            this.lblNev.TabIndex = 1;
            this.lblNev.Text = "Név:";
            this.lblNev.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgwAnyag
            // 
            this.dgwAnyag.AllowUserToAddRows = false;
            this.dgwAnyag.AllowUserToDeleteRows = false;
            this.dgwAnyag.AllowUserToOrderColumns = true;
            this.dgwAnyag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwAnyag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAnyag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.rovid});
            this.dgwAnyag.Location = new System.Drawing.Point(12, 12);
            this.dgwAnyag.Name = "dgwAnyag";
            this.dgwAnyag.ReadOnly = true;
            this.dgwAnyag.RowHeadersWidth = 51;
            this.dgwAnyag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAnyag.Size = new System.Drawing.Size(332, 314);
            this.dgwAnyag.TabIndex = 2;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.MinimumWidth = 6;
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 64;
            // 
            // rovid
            // 
            this.rovid.HeaderText = "Rövidítés";
            this.rovid.MinimumWidth = 6;
            this.rovid.Name = "rovid";
            this.rovid.ReadOnly = true;
            this.rovid.Width = 99;
            // 
            // gbFelvitel
            // 
            this.gbFelvitel.Controls.Add(this.btnFelvitel);
            this.gbFelvitel.Controls.Add(this.lblRovid);
            this.gbFelvitel.Controls.Add(this.lblNev);
            this.gbFelvitel.Controls.Add(this.txtRovid);
            this.gbFelvitel.Controls.Add(this.txtNev);
            this.gbFelvitel.Location = new System.Drawing.Point(350, 12);
            this.gbFelvitel.Name = "gbFelvitel";
            this.gbFelvitel.Size = new System.Drawing.Size(302, 170);
            this.gbFelvitel.TabIndex = 3;
            this.gbFelvitel.TabStop = false;
            this.gbFelvitel.Text = "Új elem felvitele";
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(186, 119);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(94, 29);
            this.btnFelvitel.TabIndex = 2;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // lblRovid
            // 
            this.lblRovid.Location = new System.Drawing.Point(6, 69);
            this.lblRovid.Name = "lblRovid";
            this.lblRovid.Size = new System.Drawing.Size(109, 25);
            this.lblRovid.TabIndex = 1;
            this.lblRovid.Text = "Rövidítés:";
            this.lblRovid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRovid
            // 
            this.txtRovid.Location = new System.Drawing.Point(121, 66);
            this.txtRovid.MaxLength = 10;
            this.txtRovid.Name = "txtRovid";
            this.txtRovid.Size = new System.Drawing.Size(159, 27);
            this.txtRovid.TabIndex = 0;
            // 
            // AnyagInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 338);
            this.Controls.Add(this.gbFelvitel);
            this.Controls.Add(this.dgwAnyag);
            this.Name = "AnyagInput";
            this.Text = "Új anyag felvitele";
            this.Load += new System.EventHandler(this.SimpleInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAnyag)).EndInit();
            this.gbFelvitel.ResumeLayout(false);
            this.gbFelvitel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.DataGridView dgwAnyag;
        private System.Windows.Forms.GroupBox gbFelvitel;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.Label lblRovid;
        private System.Windows.Forms.TextBox txtRovid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn rovid;
    }
}