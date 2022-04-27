
namespace Proyecto_Vectores_Codigo
{
    partial class FormVerificacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxcodigoVerificador = new System.Windows.Forms.TextBox();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.labelVerificacion = new System.Windows.Forms.Label();
            this.labelVerificacion1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verificacion de Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Verificador";
            // 
            // textBoxcodigoVerificador
            // 
            this.textBoxcodigoVerificador.Location = new System.Drawing.Point(123, 95);
            this.textBoxcodigoVerificador.Name = "textBoxcodigoVerificador";
            this.textBoxcodigoVerificador.Size = new System.Drawing.Size(100, 20);
            this.textBoxcodigoVerificador.TabIndex = 2;
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Location = new System.Drawing.Point(91, 203);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(132, 57);
            this.buttonVerificar.TabIndex = 3;
            this.buttonVerificar.Text = "Verificar ";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // labelVerificacion
            // 
            this.labelVerificacion.AutoSize = true;
            this.labelVerificacion.BackColor = System.Drawing.SystemColors.Control;
            this.labelVerificacion.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelVerificacion.Location = new System.Drawing.Point(49, 150);
            this.labelVerificacion.Name = "labelVerificacion";
            this.labelVerificacion.Size = new System.Drawing.Size(10, 13);
            this.labelVerificacion.TabIndex = 4;
            this.labelVerificacion.Text = ".";
            // 
            // labelVerificacion1
            // 
            this.labelVerificacion1.AutoSize = true;
            this.labelVerificacion1.ForeColor = System.Drawing.Color.Red;
            this.labelVerificacion1.Location = new System.Drawing.Point(199, 150);
            this.labelVerificacion1.Name = "labelVerificacion1";
            this.labelVerificacion1.Size = new System.Drawing.Size(10, 13);
            this.labelVerificacion1.TabIndex = 5;
            this.labelVerificacion1.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vector de Control: 9999999999";
            // 
            // FormVerificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(307, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelVerificacion1);
            this.Controls.Add(this.labelVerificacion);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.textBoxcodigoVerificador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVerificacion";
            this.Text = "FormVerificacion";
            this.Load += new System.EventHandler(this.FormVerificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxcodigoVerificador;
        private System.Windows.Forms.Button buttonVerificar;
        private System.Windows.Forms.Label labelVerificacion;
        private System.Windows.Forms.Label labelVerificacion1;
        private System.Windows.Forms.Label label3;
    }
}