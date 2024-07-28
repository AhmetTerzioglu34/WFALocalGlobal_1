namespace WFALocalGlobal_1
{
    partial class Form1
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
            this.btnDeneme = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeneme
            // 
            this.btnDeneme.Location = new System.Drawing.Point(466, 86);
            this.btnDeneme.Name = "btnDeneme";
            this.btnDeneme.Size = new System.Drawing.Size(75, 23);
            this.btnDeneme.TabIndex = 0;
            this.btnDeneme.Text = "Arttır";
            this.btnDeneme.UseVisualStyleBackColor = true;
            this.btnDeneme.Click += new System.EventHandler(this.btnDeneme_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(471, 158);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(75, 23);
            this.btnAzalt.TabIndex = 1;
            this.btnAzalt.Text = "Azalt";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnDeneme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeneme;
        private System.Windows.Forms.Button btnAzalt;
    }
}

