namespace Sesion5_ejercicio1
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
            this.Numero1 = new System.Windows.Forms.Label();
            this.Numero2 = new System.Windows.Forms.Label();
            this.tBNumbre1 = new System.Windows.Forms.TextBox();
            this.tBNumber2 = new System.Windows.Forms.TextBox();
            this.bTNMayor = new System.Windows.Forms.Button();
            this.lBLAnswer = new System.Windows.Forms.Label();
            this.bTNMenor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShowDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numero1
            // 
            this.Numero1.AutoSize = true;
            this.Numero1.Location = new System.Drawing.Point(83, 52);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(56, 13);
            this.Numero1.TabIndex = 0;
            this.Numero1.Text = "Numero 1:";
            this.Numero1.Click += new System.EventHandler(this.Numero1_Click);
            // 
            // Numero2
            // 
            this.Numero2.AutoSize = true;
            this.Numero2.Location = new System.Drawing.Point(83, 94);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(56, 13);
            this.Numero2.TabIndex = 1;
            this.Numero2.Text = "Numero 2:";
            // 
            // tBNumbre1
            // 
            this.tBNumbre1.Location = new System.Drawing.Point(141, 49);
            this.tBNumbre1.Name = "tBNumbre1";
            this.tBNumbre1.Size = new System.Drawing.Size(100, 20);
            this.tBNumbre1.TabIndex = 2;
            this.tBNumbre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBNumbre1.TextChanged += new System.EventHandler(this.tBNumbre1_TextChanged);
            // 
            // tBNumber2
            // 
            this.tBNumber2.Location = new System.Drawing.Point(142, 91);
            this.tBNumber2.Name = "tBNumber2";
            this.tBNumber2.Size = new System.Drawing.Size(100, 20);
            this.tBNumber2.TabIndex = 3;
            this.tBNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bTNMayor
            // 
            this.bTNMayor.Location = new System.Drawing.Point(107, 156);
            this.bTNMayor.Name = "bTNMayor";
            this.bTNMayor.Size = new System.Drawing.Size(134, 23);
            this.bTNMayor.TabIndex = 4;
            this.bTNMayor.Text = "Evaluar Mayor";
            this.bTNMayor.UseVisualStyleBackColor = true;
            this.bTNMayor.Click += new System.EventHandler(this.bTNMayor_Click);
            // 
            // lBLAnswer
            // 
            this.lBLAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lBLAnswer.Location = new System.Drawing.Point(86, 262);
            this.lBLAnswer.Name = "lBLAnswer";
            this.lBLAnswer.Size = new System.Drawing.Size(156, 44);
            this.lBLAnswer.TabIndex = 5;
            this.lBLAnswer.Click += new System.EventHandler(this.lBLAnswer_Click);
            // 
            // bTNMenor
            // 
            this.bTNMenor.Location = new System.Drawing.Point(107, 197);
            this.bTNMenor.Name = "bTNMenor";
            this.bTNMenor.Size = new System.Drawing.Size(135, 23);
            this.bTNMenor.TabIndex = 6;
            this.bTNMenor.Text = "Evaluar Menor";
            this.bTNMenor.UseVisualStyleBackColor = true;
            this.bTNMenor.Click += new System.EventHandler(this.bTNMenor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Evaluar Menor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Evaluar Mayor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowDay
            // 
            this.btnShowDay.Location = new System.Drawing.Point(271, 52);
            this.btnShowDay.Name = "btnShowDay";
            this.btnShowDay.Size = new System.Drawing.Size(134, 23);
            this.btnShowDay.TabIndex = 9;
            this.btnShowDay.Text = "Evaluar Día";
            this.btnShowDay.UseVisualStyleBackColor = true;
            this.btnShowDay.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 337);
            this.Controls.Add(this.btnShowDay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bTNMenor);
            this.Controls.Add(this.lBLAnswer);
            this.Controls.Add(this.bTNMayor);
            this.Controls.Add(this.tBNumber2);
            this.Controls.Add(this.tBNumbre1);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesión 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numero1;
        private System.Windows.Forms.Label Numero2;
        private System.Windows.Forms.TextBox tBNumbre1;
        private System.Windows.Forms.TextBox tBNumber2;
        private System.Windows.Forms.Button bTNMayor;
        private System.Windows.Forms.Label lBLAnswer;
        private System.Windows.Forms.Button bTNMenor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShowDay;
    }
}

