﻿namespace Fakturace2021
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Zakaznik = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Zakaznik
            // 
            this.btn_Zakaznik.Location = new System.Drawing.Point(13, 31);
            this.btn_Zakaznik.Name = "btn_Zakaznik";
            this.btn_Zakaznik.Size = new System.Drawing.Size(238, 188);
            this.btn_Zakaznik.TabIndex = 0;
            this.btn_Zakaznik.Text = "Zákazníci";
            this.btn_Zakaznik.UseVisualStyleBackColor = true;
            this.btn_Zakaznik.Click += new System.EventHandler(this.Btn_Zakaznik_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 188);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zboží";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 188);
            this.button3.TabIndex = 2;
            this.button3.Text = "Faktury";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 249);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Zakaznik);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Zakaznik;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

