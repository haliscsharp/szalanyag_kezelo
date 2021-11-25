
namespace szalkezelo
{
    partial class SimpleNameInput
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
            this.gbFelvitel = new System.Windows.Forms.GroupBox();
            this.btnFelvitel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInput)).BeginInit();
            this.gbFelvitel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(121, 33);
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
            // dgwInput
            // 
            this.dgwInput.AllowUserToAddRows = false;
            this.dgwInput.AllowUserToDeleteRows = false;
            this.dgwInput.AllowUserToOrderColumns = true;
            this.dgwInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev});
            this.dgwInput.Location = new System.Drawing.Point(12, 12);
            this.dgwInput.Name = "dgwInput";
            this.dgwInput.ReadOnly = true;
            this.dgwInput.RowHeadersWidth = 51;
            this.dgwInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwInput.Size = new System.Drawing.Size(332, 314);
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
            // gbFelvitel
            // 
            this.gbFelvitel.Controls.Add(this.btnFelvitel);
            this.gbFelvitel.Controls.Add(this.lblNev);
            this.gbFelvitel.Controls.Add(this.txtNev);
            this.gbFelvitel.Location = new System.Drawing.Point(350, 12);
            this.gbFelvitel.Name = "gbFelvitel";
            this.gbFelvitel.Size = new System.Drawing.Size(302, 157);
            this.gbFelvitel.TabIndex = 3;
            this.gbFelvitel.TabStop = false;
            this.gbFelvitel.Text = "Új elem felvitele";
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(186, 106);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(94, 29);
            this.btnFelvitel.TabIndex = 2;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // SimpleNameInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 338);
            this.Controls.Add(this.gbFelvitel);
            this.Controls.Add(this.dgwInput);
            this.Name = "SimpleNameInput";
            this.Text = "SimpleInput";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.GroupBox gbFelvitel;
        private System.Windows.Forms.Button btnFelvitel;
    }
}