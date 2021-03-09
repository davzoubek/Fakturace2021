namespace Fakturace2021
{
    partial class ZakaznikUpravy
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.hId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hJmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hPrijmeni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsHledat = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hId,
            this.hJmeno,
            this.hPrijmeni,
            this.hTyp,
            this.hAdresa,
            this.hIco,
            this.hEmail,
            this.hTelefon});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 76);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 374);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // hId
            // 
            this.hId.Text = "ID";
            // 
            // hJmeno
            // 
            this.hJmeno.Text = "Jméno";
            // 
            // hPrijmeni
            // 
            this.hPrijmeni.Text = "Přijmení";
            // 
            // hTyp
            // 
            this.hTyp.Text = "Typ zákazníka";
            // 
            // hAdresa
            // 
            this.hAdresa.Text = "Adresa";
            // 
            // hIco
            // 
            this.hIco.Text = "IČO";
            // 
            // hEmail
            // 
            this.hEmail.Text = "Email";
            // 
            // hTelefon
            // 
            this.hTelefon.Text = "Telefon";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHledat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsHledat
            // 
            this.tsHledat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsHledat.Name = "tsHledat";
            this.tsHledat.Size = new System.Drawing.Size(100, 25);
            // 
            // ZakaznikUpravy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView1);
            this.Name = "ZakaznikUpravy";
            this.Text = "ZakaznikUpravy";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader hId;
        private System.Windows.Forms.ColumnHeader hJmeno;
        private System.Windows.Forms.ColumnHeader hPrijmeni;
        private System.Windows.Forms.ColumnHeader hTyp;
        private System.Windows.Forms.ColumnHeader hAdresa;
        private System.Windows.Forms.ColumnHeader hIco;
        private System.Windows.Forms.ColumnHeader hEmail;
        private System.Windows.Forms.ColumnHeader hTelefon;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tsHledat;
    }
}