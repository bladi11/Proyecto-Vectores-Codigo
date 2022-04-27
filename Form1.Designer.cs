
namespace Proyecto_Vectores_Codigo
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
            this.buttonCreacion = new System.Windows.Forms.Button();
            this.buttonVerificacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreacion
            // 
            this.buttonCreacion.Location = new System.Drawing.Point(80, 94);
            this.buttonCreacion.Name = "buttonCreacion";
            this.buttonCreacion.Size = new System.Drawing.Size(127, 49);
            this.buttonCreacion.TabIndex = 0;
            this.buttonCreacion.Text = "Creacion Vector";
            this.buttonCreacion.UseVisualStyleBackColor = true;
            this.buttonCreacion.Click += new System.EventHandler(this.buttonCreacion_Click);
            // 
            // buttonVerificacion
            // 
            this.buttonVerificacion.Location = new System.Drawing.Point(80, 191);
            this.buttonVerificacion.Name = "buttonVerificacion";
            this.buttonVerificacion.Size = new System.Drawing.Size(127, 49);
            this.buttonVerificacion.TabIndex = 1;
            this.buttonVerificacion.Text = "Verificacion Vector";
            this.buttonVerificacion.UseVisualStyleBackColor = true;
            this.buttonVerificacion.Click += new System.EventHandler(this.buttonVerificacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(102, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vectores Codigo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(311, 294);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVerificacion);
            this.Controls.Add(this.buttonCreacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreacion;
        private System.Windows.Forms.Button buttonVerificacion;
        private System.Windows.Forms.Label label1;
    }
}

