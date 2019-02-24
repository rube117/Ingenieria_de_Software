namespace Practica_4A
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
            this.txt_nombre = new System.Windows.Forms.Label();
            this.txt_calificacion = new System.Windows.Forms.Label();
            this.txt_mostrar = new System.Windows.Forms.Label();
            this.b_mostrar = new System.Windows.Forms.Button();
            this.b_ordenar = new System.Windows.Forms.Button();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_calificacion = new System.Windows.Forms.TextBox();
            this.txt_alumnos = new System.Windows.Forms.Label();
            this.b_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoSize = true;
            this.txt_nombre.Location = new System.Drawing.Point(46, 49);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(35, 13);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "label1";
            // 
            // txt_calificacion
            // 
            this.txt_calificacion.AutoSize = true;
            this.txt_calificacion.Location = new System.Drawing.Point(46, 80);
            this.txt_calificacion.Name = "txt_calificacion";
            this.txt_calificacion.Size = new System.Drawing.Size(35, 13);
            this.txt_calificacion.TabIndex = 2;
            this.txt_calificacion.Text = "label2";
            // 
            // txt_mostrar
            // 
            this.txt_mostrar.AutoSize = true;
            this.txt_mostrar.Location = new System.Drawing.Point(475, 37);
            this.txt_mostrar.Name = "txt_mostrar";
            this.txt_mostrar.Size = new System.Drawing.Size(35, 13);
            this.txt_mostrar.TabIndex = 3;
            this.txt_mostrar.Text = "label3";
            // 
            // b_mostrar
            // 
            this.b_mostrar.Location = new System.Drawing.Point(130, 144);
            this.b_mostrar.Name = "b_mostrar";
            this.b_mostrar.Size = new System.Drawing.Size(75, 23);
            this.b_mostrar.TabIndex = 5;
            this.b_mostrar.Text = "button1";
            this.b_mostrar.UseVisualStyleBackColor = true;
            this.b_mostrar.Click += new System.EventHandler(this.b_mostrar_Click);
            // 
            // b_ordenar
            // 
            this.b_ordenar.Location = new System.Drawing.Point(211, 144);
            this.b_ordenar.Name = "b_ordenar";
            this.b_ordenar.Size = new System.Drawing.Size(75, 23);
            this.b_ordenar.TabIndex = 6;
            this.b_ordenar.Text = "button1";
            this.b_ordenar.UseVisualStyleBackColor = true;
            this.b_ordenar.Click += new System.EventHandler(this.b_ordenar_Click);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(145, 46);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre.TabIndex = 7;
            // 
            // tb_calificacion
            // 
            this.tb_calificacion.Location = new System.Drawing.Point(145, 77);
            this.tb_calificacion.Name = "tb_calificacion";
            this.tb_calificacion.Size = new System.Drawing.Size(100, 20);
            this.tb_calificacion.TabIndex = 8;
            // 
            // txt_alumnos
            // 
            this.txt_alumnos.AutoSize = true;
            this.txt_alumnos.Location = new System.Drawing.Point(46, 22);
            this.txt_alumnos.Name = "txt_alumnos";
            this.txt_alumnos.Size = new System.Drawing.Size(35, 13);
            this.txt_alumnos.TabIndex = 9;
            this.txt_alumnos.Text = "label1";
            // 
            // b_guardar
            // 
            this.b_guardar.Location = new System.Drawing.Point(49, 144);
            this.b_guardar.Name = "b_guardar";
            this.b_guardar.Size = new System.Drawing.Size(75, 23);
            this.b_guardar.TabIndex = 10;
            this.b_guardar.Text = "button1";
            this.b_guardar.UseVisualStyleBackColor = true;
            this.b_guardar.Click += new System.EventHandler(this.b_guardar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 274);
            this.Controls.Add(this.b_guardar);
            this.Controls.Add(this.txt_alumnos);
            this.Controls.Add(this.tb_calificacion);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.b_ordenar);
            this.Controls.Add(this.b_mostrar);
            this.Controls.Add(this.txt_mostrar);
            this.Controls.Add(this.txt_calificacion);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Menu";
            this.Text = "Menú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_nombre;
        private System.Windows.Forms.Label txt_calificacion;
        private System.Windows.Forms.Label txt_mostrar;
        private System.Windows.Forms.Button b_mostrar;
        private System.Windows.Forms.Button b_ordenar;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_calificacion;
        private System.Windows.Forms.Label txt_alumnos;
        private System.Windows.Forms.Button b_guardar;
    }
}

