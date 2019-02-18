namespace Practica_2
{
    partial class Mostrar_Empleados
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
            this.b_cerrar = new System.Windows.Forms.Button();
            this.mostrar_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_cerrar
            // 
            this.b_cerrar.Location = new System.Drawing.Point(330, 415);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(75, 23);
            this.b_cerrar.TabIndex = 0;
            this.b_cerrar.Text = "button1";
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // mostrar_txt
            // 
            this.mostrar_txt.AutoSize = true;
            this.mostrar_txt.Location = new System.Drawing.Point(37, 48);
            this.mostrar_txt.Name = "mostrar_txt";
            this.mostrar_txt.Size = new System.Drawing.Size(35, 13);
            this.mostrar_txt.TabIndex = 1;
            this.mostrar_txt.Text = "label1";
            // 
            // Mostrar_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostrar_txt);
            this.Controls.Add(this.b_cerrar);
            this.Name = "Mostrar_Empleados";
            this.Text = "Mostrar Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Label mostrar_txt;
    }
}