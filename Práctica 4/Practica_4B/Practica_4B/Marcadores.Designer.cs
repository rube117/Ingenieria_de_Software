namespace Practica_4B
{
    partial class Marcadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marcadores));
            this.marcador = new System.Windows.Forms.Label();
            this.ordenar = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // marcador
            // 
            this.marcador.AutoSize = true;
            this.marcador.Location = new System.Drawing.Point(33, 27);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(35, 13);
            this.marcador.TabIndex = 0;
            this.marcador.Text = "label1";
            // 
            // ordenar
            // 
            this.ordenar.Location = new System.Drawing.Point(36, 238);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(75, 23);
            this.ordenar.TabIndex = 1;
            this.ordenar.Text = "button1";
            this.ordenar.UseVisualStyleBackColor = true;
            this.ordenar.Click += new System.EventHandler(this.ordenar_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(155, 238);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 2;
            this.volver.Text = "button1";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // Marcadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 290);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.ordenar);
            this.Controls.Add(this.marcador);
            this.Name = "Marcadores";
            this.Text = "Marcadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label marcador;
        private System.Windows.Forms.Button ordenar;
        private System.Windows.Forms.Button volver;
    }
}