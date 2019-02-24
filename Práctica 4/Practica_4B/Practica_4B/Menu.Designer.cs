namespace Practica_4B
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.registrados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre_equipo = new System.Windows.Forms.TextBox();
            this.victorias_equipo = new System.Windows.Forms.TextBox();
            this.derrotas_equipo = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrados
            // 
            this.registrados.AutoSize = true;
            this.registrados.Location = new System.Drawing.Point(31, 24);
            this.registrados.Name = "registrados";
            this.registrados.Size = new System.Drawing.Size(35, 13);
            this.registrados.TabIndex = 0;
            this.registrados.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label1";
            // 
            // nombre_equipo
            // 
            this.nombre_equipo.Location = new System.Drawing.Point(144, 63);
            this.nombre_equipo.Name = "nombre_equipo";
            this.nombre_equipo.Size = new System.Drawing.Size(100, 20);
            this.nombre_equipo.TabIndex = 4;
            // 
            // victorias_equipo
            // 
            this.victorias_equipo.Location = new System.Drawing.Point(144, 89);
            this.victorias_equipo.Name = "victorias_equipo";
            this.victorias_equipo.Size = new System.Drawing.Size(100, 20);
            this.victorias_equipo.TabIndex = 5;
            // 
            // derrotas_equipo
            // 
            this.derrotas_equipo.Location = new System.Drawing.Point(144, 114);
            this.derrotas_equipo.Name = "derrotas_equipo";
            this.derrotas_equipo.Size = new System.Drawing.Size(100, 20);
            this.derrotas_equipo.TabIndex = 6;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(49, 152);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 7;
            this.guardar.Text = "button1";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(160, 152);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(75, 23);
            this.mostrar.TabIndex = 8;
            this.mostrar.Text = "button1";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(346, 206);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.derrotas_equipo);
            this.Controls.Add(this.victorias_equipo);
            this.Controls.Add(this.nombre_equipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrados);
            this.Name = "Menu";
            this.Text = "Menú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre_equipo;
        private System.Windows.Forms.TextBox victorias_equipo;
        private System.Windows.Forms.TextBox derrotas_equipo;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button mostrar;
    }
}

