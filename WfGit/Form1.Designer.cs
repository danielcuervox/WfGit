namespace WfGit
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOtro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(227, 153);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 55);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(613, 102);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(55, 16);
            this.lblEtiqueta.TabIndex = 1;
            this.lblEtiqueta.Text = "etiqueta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ETIQUETA PEPE Y JOSE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOtro
            // 
            this.btnOtro.Location = new System.Drawing.Point(577, 264);
            this.btnOtro.Name = "btnOtro";
            this.btnOtro.Size = new System.Drawing.Size(75, 23);
            this.btnOtro.TabIndex = 3;
            this.btnOtro.Text = "OTRO";
            this.btnOtro.UseVisualStyleBackColor = true;
            this.btnOtro.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOtro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = "Formulario de ejemplo MODIFICADO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOtro;
    }
}

