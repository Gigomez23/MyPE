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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtLibrosAgregados = new System.Windows.Forms.Label();
            this.lbLibros = new System.Windows.Forms.ListBox();
            this.lbCopia = new System.Windows.Forms.ListBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tituló";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(437, 164);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(295, 26);
            this.tbTitulo.TabIndex = 1;
            this.tbTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTitulo_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(738, 162);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtLibrosAgregados
            // 
            this.txtLibrosAgregados.AutoSize = true;
            this.txtLibrosAgregados.Location = new System.Drawing.Point(262, 227);
            this.txtLibrosAgregados.Name = "txtLibrosAgregados";
            this.txtLibrosAgregados.Size = new System.Drawing.Size(134, 20);
            this.txtLibrosAgregados.TabIndex = 3;
            this.txtLibrosAgregados.Text = "Libros Agregados";
            // 
            // lbLibros
            // 
            this.lbLibros.FormattingEnabled = true;
            this.lbLibros.ItemHeight = 20;
            this.lbLibros.Location = new System.Drawing.Point(266, 250);
            this.lbLibros.Name = "lbLibros";
            this.lbLibros.Size = new System.Drawing.Size(344, 204);
            this.lbLibros.TabIndex = 4;
            this.lbLibros.Click += new System.EventHandler(this.lbLibros_Click);
            // 
            // lbCopia
            // 
            this.lbCopia.FormattingEnabled = true;
            this.lbCopia.ItemHeight = 20;
            this.lbCopia.Location = new System.Drawing.Point(616, 250);
            this.lbCopia.Name = "lbCopia";
            this.lbCopia.Size = new System.Drawing.Size(344, 204);
            this.lbCopia.TabIndex = 5;
            this.lbCopia.Click += new System.EventHandler(this.lbCopia_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(524, 203);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(86, 34);
            this.btnCopiar.TabIndex = 6;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnMover
            // 
            this.btnMover.Enabled = false;
            this.btnMover.Location = new System.Drawing.Point(655, 203);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(77, 34);
            this.btnMover.TabIndex = 7;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Enabled = false;
            this.btnRegresar.Location = new System.Drawing.Point(776, 203);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(90, 34);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.lbCopia);
            this.Controls.Add(this.lbLibros);
            this.Controls.Add(this.txtLibrosAgregados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Libros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label txtLibrosAgregados;
        private System.Windows.Forms.ListBox lbLibros;
        private System.Windows.Forms.ListBox lbCopia;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnRegresar;
    }
}

