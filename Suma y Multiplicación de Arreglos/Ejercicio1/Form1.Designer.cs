namespace Ejercicio1
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
            this.btnTirar = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.lbSumas = new System.Windows.Forms.ListBox();
            this.lbMatriz = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTirar
            // 
            this.btnTirar.Location = new System.Drawing.Point(205, 41);
            this.btnTirar.Name = "btnTirar";
            this.btnTirar.Size = new System.Drawing.Size(75, 23);
            this.btnTirar.TabIndex = 4;
            this.btnTirar.Text = "Tirar Dados";
            this.btnTirar.UseVisualStyleBackColor = true;
            this.btnTirar.Click += new System.EventHandler(this.btnTirar_Click);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(90, 99);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(223, 186);
            this.lbLista.TabIndex = 5;
            this.lbLista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbSumas
            // 
            this.lbSumas.FormattingEnabled = true;
            this.lbSumas.Location = new System.Drawing.Point(366, 41);
            this.lbSumas.Name = "lbSumas";
            this.lbSumas.Size = new System.Drawing.Size(157, 251);
            this.lbSumas.TabIndex = 6;
            this.lbSumas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // lbMatriz
            // 
            this.lbMatriz.AutoSize = true;
            this.lbMatriz.Location = new System.Drawing.Point(90, 80);
            this.lbMatriz.Name = "lbMatriz";
            this.lbMatriz.Size = new System.Drawing.Size(86, 13);
            this.lbMatriz.TabIndex = 7;
            this.lbMatriz.Text = "Cantidad por Par";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(363, 25);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(102, 13);
            this.lblSuma.TabIndex = 8;
            this.lblSuma.Text = "Cantidad por Sumas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 432);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lbMatriz);
            this.Controls.Add(this.lbSumas);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnTirar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTirar;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.ListBox lbSumas;
        private System.Windows.Forms.Label lbMatriz;
        private System.Windows.Forms.Label lblSuma;
    }
}

