
namespace szalkezelo
{
    partial class FoAblak
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwRaktar = new System.Windows.Forms.DataGridView();
            this.szalanyag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hossz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmBevetelezes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRendeles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdatok = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSzalanyag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSzalanyagAdatok = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMeret = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAnyag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMinoseg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTipus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSzurok = new System.Windows.Forms.GroupBox();
            this.lblSzalanyag = new System.Windows.Forms.Label();
            this.cbSzuroSzalanyag = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRaktar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbSzurok.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwRaktar
            // 
            this.dgwRaktar.AllowUserToAddRows = false;
            this.dgwRaktar.AllowUserToDeleteRows = false;
            this.dgwRaktar.AllowUserToOrderColumns = true;
            this.dgwRaktar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwRaktar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRaktar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.szalanyag,
            this.mennyiseg,
            this.hossz});
            this.dgwRaktar.Location = new System.Drawing.Point(12, 113);
            this.dgwRaktar.Name = "dgwRaktar";
            this.dgwRaktar.ReadOnly = true;
            this.dgwRaktar.RowHeadersWidth = 51;
            this.dgwRaktar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwRaktar.Size = new System.Drawing.Size(806, 348);
            this.dgwRaktar.TabIndex = 0;
            // 
            // szalanyag
            // 
            this.szalanyag.HeaderText = "Szálanyag";
            this.szalanyag.MinimumWidth = 6;
            this.szalanyag.Name = "szalanyag";
            this.szalanyag.ReadOnly = true;
            this.szalanyag.Width = 105;
            // 
            // mennyiseg
            // 
            this.mennyiseg.HeaderText = "Mennyiség (db)";
            this.mennyiseg.MinimumWidth = 6;
            this.mennyiseg.Name = "mennyiseg";
            this.mennyiseg.ReadOnly = true;
            this.mennyiseg.Width = 141;
            // 
            // hossz
            // 
            this.hossz.HeaderText = "Hossz (m)";
            this.hossz.MinimumWidth = 6;
            this.hossz.Name = "hossz";
            this.hossz.ReadOnly = true;
            this.hossz.Width = 104;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBevetelezes,
            this.tsmRendeles,
            this.tsmAdatok,
            this.tsmKilepes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmBevetelezes
            // 
            this.tsmBevetelezes.Name = "tsmBevetelezes";
            this.tsmBevetelezes.Size = new System.Drawing.Size(101, 24);
            this.tsmBevetelezes.Text = "Bevételezés";
            // 
            // tsmRendeles
            // 
            this.tsmRendeles.Name = "tsmRendeles";
            this.tsmRendeles.Size = new System.Drawing.Size(83, 24);
            this.tsmRendeles.Text = "Rendelés";
            // 
            // tsmAdatok
            // 
            this.tsmAdatok.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSzalanyag,
            this.tsmSzalanyagAdatok});
            this.tsmAdatok.Name = "tsmAdatok";
            this.tsmAdatok.Size = new System.Drawing.Size(71, 24);
            this.tsmAdatok.Text = "Adatok";
            // 
            // tsmSzalanyag
            // 
            this.tsmSzalanyag.Name = "tsmSzalanyag";
            this.tsmSzalanyag.Size = new System.Drawing.Size(209, 26);
            this.tsmSzalanyag.Text = "Szálanyag";
            // 
            // tsmSzalanyagAdatok
            // 
            this.tsmSzalanyagAdatok.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMeret,
            this.tsmAnyag,
            this.tsmMinoseg,
            this.tsmTipus});
            this.tsmSzalanyagAdatok.Name = "tsmSzalanyagAdatok";
            this.tsmSzalanyagAdatok.Size = new System.Drawing.Size(209, 26);
            this.tsmSzalanyagAdatok.Text = "Szálanyag adatok";
            // 
            // tsmMeret
            // 
            this.tsmMeret.Name = "tsmMeret";
            this.tsmMeret.Size = new System.Drawing.Size(191, 26);
            this.tsmMeret.Text = "Méret";
            // 
            // tsmAnyag
            // 
            this.tsmAnyag.Name = "tsmAnyag";
            this.tsmAnyag.Size = new System.Drawing.Size(191, 26);
            this.tsmAnyag.Text = "Anyag";
            // 
            // tsmMinoseg
            // 
            this.tsmMinoseg.Name = "tsmMinoseg";
            this.tsmMinoseg.Size = new System.Drawing.Size(191, 26);
            this.tsmMinoseg.Text = "Anyagminőség";
            // 
            // tsmTipus
            // 
            this.tsmTipus.Name = "tsmTipus";
            this.tsmTipus.Size = new System.Drawing.Size(191, 26);
            this.tsmTipus.Text = "Típus";
            // 
            // tsmKilepes
            // 
            this.tsmKilepes.Name = "tsmKilepes";
            this.tsmKilepes.Size = new System.Drawing.Size(71, 24);
            this.tsmKilepes.Text = "Kilépés";
            // 
            // gbSzurok
            // 
            this.gbSzurok.Controls.Add(this.lblSzalanyag);
            this.gbSzurok.Controls.Add(this.cbSzuroSzalanyag);
            this.gbSzurok.Location = new System.Drawing.Point(12, 31);
            this.gbSzurok.Name = "gbSzurok";
            this.gbSzurok.Size = new System.Drawing.Size(807, 76);
            this.gbSzurok.TabIndex = 2;
            this.gbSzurok.TabStop = false;
            this.gbSzurok.Text = "Szűrők";
            // 
            // lblSzalanyag
            // 
            this.lblSzalanyag.Location = new System.Drawing.Point(26, 25);
            this.lblSzalanyag.Name = "lblSzalanyag";
            this.lblSzalanyag.Size = new System.Drawing.Size(159, 28);
            this.lblSzalanyag.TabIndex = 1;
            this.lblSzalanyag.Text = "Szálanyag:";
            this.lblSzalanyag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSzuroSzalanyag
            // 
            this.cbSzuroSzalanyag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSzuroSzalanyag.FormattingEnabled = true;
            this.cbSzuroSzalanyag.Location = new System.Drawing.Point(191, 26);
            this.cbSzuroSzalanyag.Name = "cbSzuroSzalanyag";
            this.cbSzuroSzalanyag.Size = new System.Drawing.Size(262, 28);
            this.cbSzuroSzalanyag.TabIndex = 0;
            // 
            // FoAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 475);
            this.Controls.Add(this.gbSzurok);
            this.Controls.Add(this.dgwRaktar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FoAblak";
            this.Text = "Raktár";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRaktar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbSzurok.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRaktar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmRendeles;
        private System.Windows.Forms.ToolStripMenuItem tsmKilepes;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyiseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn hossz;
        private System.Windows.Forms.ToolStripMenuItem tsmAdatok;
        private System.Windows.Forms.ToolStripMenuItem tsmSzalanyag;
        private System.Windows.Forms.ToolStripMenuItem tsmSzalanyagAdatok;
        private System.Windows.Forms.ToolStripMenuItem tsmMeret;
        private System.Windows.Forms.ToolStripMenuItem tsmAnyag;
        private System.Windows.Forms.ToolStripMenuItem tsmMinoseg;
        private System.Windows.Forms.ToolStripMenuItem tsmTipus;
        private System.Windows.Forms.ToolStripMenuItem tsmBevetelezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn szalanyag;
        private System.Windows.Forms.GroupBox gbSzurok;
        private System.Windows.Forms.Label lblSzalanyag;
        private System.Windows.Forms.ComboBox cbSzuroSzalanyag;
    }
}

