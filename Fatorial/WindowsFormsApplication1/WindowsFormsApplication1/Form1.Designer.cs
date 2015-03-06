namespace WindowsFormsApplication1
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
            this.Iterativa = new System.Windows.Forms.Button();
            this.Recursiva = new System.Windows.Forms.Button();
            this.NumEnter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Iterativa
            // 
            this.Iterativa.Location = new System.Drawing.Point(40, 161);
            this.Iterativa.Name = "Iterativa";
            this.Iterativa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Iterativa.Size = new System.Drawing.Size(75, 23);
            this.Iterativa.TabIndex = 0;
            this.Iterativa.Text = "Iterativa";
            this.Iterativa.UseVisualStyleBackColor = true;
            this.Iterativa.Click += new System.EventHandler(this.Iterativa_Click);
            // 
            // Recursiva
            // 
            this.Recursiva.Location = new System.Drawing.Point(151, 161);
            this.Recursiva.Name = "Recursiva";
            this.Recursiva.Size = new System.Drawing.Size(75, 23);
            this.Recursiva.TabIndex = 1;
            this.Recursiva.Text = "Recursiva";
            this.Recursiva.UseVisualStyleBackColor = true;
            this.Recursiva.Click += new System.EventHandler(this.Recursiva_Click);
            // 
            // NumEnter
            // 
            this.NumEnter.Location = new System.Drawing.Point(87, 89);
            this.NumEnter.Name = "NumEnter";
            this.NumEnter.Size = new System.Drawing.Size(100, 20);
            this.NumEnter.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 261);
            this.Controls.Add(this.NumEnter);
            this.Controls.Add(this.Recursiva);
            this.Controls.Add(this.Iterativa);
            this.Name = "Form1";
            this.Text = "Fatorial DanielOliveira,MateusAmaral e Mauricio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Iterativa;
        private System.Windows.Forms.Button Recursiva;
        private System.Windows.Forms.TextBox NumEnter;
    }
}

