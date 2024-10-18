namespace Ejercicio2
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbSmoking = new System.Windows.Forms.CheckBox();
            this.cbNonSmoking = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTicket = new System.Windows.Forms.ListBox();
            this.btnListaAsiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(321, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // cbSmoking
            // 
            this.cbSmoking.AutoSize = true;
            this.cbSmoking.Location = new System.Drawing.Point(331, 90);
            this.cbSmoking.Name = "cbSmoking";
            this.cbSmoking.Size = new System.Drawing.Size(67, 17);
            this.cbSmoking.TabIndex = 1;
            this.cbSmoking.Text = "Smoking";
            this.cbSmoking.UseVisualStyleBackColor = true;
            this.cbSmoking.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbNonSmoking
            // 
            this.cbNonSmoking.AutoSize = true;
            this.cbNonSmoking.Location = new System.Drawing.Point(331, 126);
            this.cbNonSmoking.Name = "cbNonSmoking";
            this.cbNonSmoking.Size = new System.Drawing.Size(90, 17);
            this.cbNonSmoking.TabIndex = 2;
            this.cbNonSmoking.Text = "Non-Smoking";
            this.cbNonSmoking.UseVisualStyleBackColor = true;
            this.cbNonSmoking.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(321, 169);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(268, 58);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Nombre:";
            // 
            // lbTicket
            // 
            this.lbTicket.FormattingEnabled = true;
            this.lbTicket.Location = new System.Drawing.Point(271, 214);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(173, 121);
            this.lbTicket.TabIndex = 5;
            // 
            // btnListaAsiento
            // 
            this.btnListaAsiento.Location = new System.Drawing.Point(286, 365);
            this.btnListaAsiento.Name = "btnListaAsiento";
            this.btnListaAsiento.Size = new System.Drawing.Size(158, 23);
            this.btnListaAsiento.TabIndex = 6;
            this.btnListaAsiento.Text = "Ver Asignación de Asientos";
            this.btnListaAsiento.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListaAsiento);
            this.Controls.Add(this.lbTicket);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbNonSmoking);
            this.Controls.Add(this.cbSmoking);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "z";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox cbSmoking;
        private System.Windows.Forms.CheckBox cbNonSmoking;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ListBox lbTicket;
        private System.Windows.Forms.Button btnListaAsiento;
    }
}

