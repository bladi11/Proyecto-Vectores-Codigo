
namespace Proyecto_Vectores_Codigo
{
    partial class FormCreacion
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.textBoxNoCarne = new System.Windows.Forms.TextBox();
            this.labelVectorCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creacion de vector codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. de Carne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Su vector codigo es: ";
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(104, 246);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(107, 45);
            this.buttonCrear.TabIndex = 3;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // textBoxNoCarne
            // 
            this.textBoxNoCarne.Location = new System.Drawing.Point(111, 98);
            this.textBoxNoCarne.Name = "textBoxNoCarne";
            this.textBoxNoCarne.Size = new System.Drawing.Size(100, 20);
            this.textBoxNoCarne.TabIndex = 4;
            // 
            // labelVectorCodigo
            // 
            this.labelVectorCodigo.AutoSize = true;
            this.labelVectorCodigo.Location = new System.Drawing.Point(121, 180);
            this.labelVectorCodigo.Name = "labelVectorCodigo";
            this.labelVectorCodigo.Size = new System.Drawing.Size(10, 13);
            this.labelVectorCodigo.TabIndex = 5;
            this.labelVectorCodigo.Text = ".";
            // 
            // FormCreacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(342, 341);
            this.Controls.Add(this.labelVectorCodigo);
            this.Controls.Add(this.textBoxNoCarne);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreacion";
            this.Text = "FormCreacion";
            this.Load += new System.EventHandler(this.FormCreacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.TextBox textBoxNoCarne;
        private System.Windows.Forms.Label labelVectorCodigo;
    }
}