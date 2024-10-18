namespace Ejercicio2
{
    partial class Form2
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
            this.lbSmoking = new System.Windows.Forms.ListBox();
            this.lbNonSmoking = new System.Windows.Forms.ListBox();
            this.lblSmoking = new System.Windows.Forms.Label();
            this.lblNonSmoking = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSmoking
            // 
            this.lbSmoking.FormattingEnabled = true;
            this.lbSmoking.Location = new System.Drawing.Point(157, 82);
            this.lbSmoking.Name = "lbSmoking";
            this.lbSmoking.Size = new System.Drawing.Size(212, 316);
            this.lbSmoking.TabIndex = 0;
            // 
            // lbNonSmoking
            // 
            this.lbNonSmoking.FormattingEnabled = true;
            this.lbNonSmoking.Location = new System.Drawing.Point(431, 82);
            this.lbNonSmoking.Name = "lbNonSmoking";
            this.lbNonSmoking.Size = new System.Drawing.Size(212, 316);
            this.lbNonSmoking.TabIndex = 1;
            // 
            // lblSmoking
            // 
            this.lblSmoking.AutoSize = true;
            this.lblSmoking.Location = new System.Drawing.Point(154, 55);
            this.lblSmoking.Name = "lblSmoking";
            this.lblSmoking.Size = new System.Drawing.Size(94, 13);
            this.lblSmoking.TabIndex = 2;
            this.lblSmoking.Text = "Asientos Smoking:";
            this.lblSmoking.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNonSmoking
            // 
            this.lblNonSmoking.AutoSize = true;
            this.lblNonSmoking.Location = new System.Drawing.Point(428, 55);
            this.lblNonSmoking.Name = "lblNonSmoking";
            this.lblNonSmoking.Size = new System.Drawing.Size(117, 13);
            this.lblNonSmoking.TabIndex = 3;
            this.lblNonSmoking.Text = "Asientos Non-Smoking:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNonSmoking);
            this.Controls.Add(this.lblSmoking);
            this.Controls.Add(this.lbNonSmoking);
            this.Controls.Add(this.lbSmoking);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSmoking;
        private System.Windows.Forms.ListBox lbNonSmoking;
        private System.Windows.Forms.Label lblSmoking;
        private System.Windows.Forms.Label lblNonSmoking;
    }
}