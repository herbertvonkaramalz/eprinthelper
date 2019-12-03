namespace ePrint_Helper
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
            this.connection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connection
            // 
            this.connection.AutoSize = true;
            this.connection.Location = new System.Drawing.Point(12, 428);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(71, 13);
            this.connection.TabIndex = 0;
            this.connection.Text = "connectedTo";
            this.connection.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "HP ePrint Helper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 36);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(340, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senden Sie Ihre Dokumente von überall auf der Welt an Ihren Drucker";
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.Red;
            this.select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.select.Location = new System.Drawing.Point(134, 158);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(255, 154);
            this.select.TabIndex = 3;
            this.select.Text = "PDF auswählen";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // print
            // 
            this.print.Enabled = false;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Location = new System.Drawing.Point(395, 158);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(255, 154);
            this.print.TabIndex = 4;
            this.print.Text = "An Drucker senden";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Disclaimer und Informationen";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.print);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ePrint Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label connection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
    }
}

