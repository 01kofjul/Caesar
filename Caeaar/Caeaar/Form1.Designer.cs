namespace Caeaar
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnver = new System.Windows.Forms.Button();
            this.tbin = new System.Windows.Forms.TextBox();
            this.tbout = new System.Windows.Forms.TextBox();
            this.tbs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnentschl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(262, 197);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(86, 23);
            this.btnver.TabIndex = 0;
            this.btnver.Text = "Verschlüsseln";
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // tbin
            // 
            this.tbin.Location = new System.Drawing.Point(46, 77);
            this.tbin.Multiline = true;
            this.tbin.Name = "tbin";
            this.tbin.Size = new System.Drawing.Size(302, 98);
            this.tbin.TabIndex = 1;
            // 
            // tbout
            // 
            this.tbout.Enabled = false;
            this.tbout.Location = new System.Drawing.Point(354, 77);
            this.tbout.Multiline = true;
            this.tbout.Name = "tbout";
            this.tbout.Size = new System.Drawing.Size(302, 98);
            this.tbout.TabIndex = 2;
            // 
            // tbs
            // 
            this.tbs.Location = new System.Drawing.Point(46, 200);
            this.tbs.Name = "tbs";
            this.tbs.Size = new System.Drawing.Size(146, 20);
            this.tbs.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Schlüssel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eingabe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ausgabe";
            // 
            // btnentschl
            // 
            this.btnentschl.Location = new System.Drawing.Point(262, 226);
            this.btnentschl.Name = "btnentschl";
            this.btnentschl.Size = new System.Drawing.Size(86, 35);
            this.btnentschl.TabIndex = 7;
            this.btnentschl.Text = "Ausgabe entschlüsseln";
            this.btnentschl.UseVisualStyleBackColor = true;
            this.btnentschl.Click += new System.EventHandler(this.btnentschl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Caesarverschlüsselung";
            // 
            // tbent
            // 
            this.tbent.Enabled = false;
            this.tbent.Location = new System.Drawing.Point(46, 291);
            this.tbent.Multiline = true;
            this.tbent.Name = "tbent";
            this.tbent.Size = new System.Drawing.Size(302, 98);
            this.tbent.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Entschlüsselt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 479);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnentschl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbs);
            this.Controls.Add(this.tbout);
            this.Controls.Add(this.tbin);
            this.Controls.Add(this.btnver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.TextBox tbin;
        private System.Windows.Forms.TextBox tbout;
        private System.Windows.Forms.TextBox tbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnentschl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbent;
        private System.Windows.Forms.Label label5;
    }
}

