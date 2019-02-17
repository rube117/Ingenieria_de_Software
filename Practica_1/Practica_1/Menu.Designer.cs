namespace Practica_1
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
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.raiz_cuadrada = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.probar1 = new System.Windows.Forms.Label();
            this.probar2 = new System.Windows.Forms.Label();
            this.elegir_variables = new System.Windows.Forms.Button();
            this.operacion = new System.Windows.Forms.Label();
            this.creador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(245, 31);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(119, 23);
            this.suma.TabIndex = 0;
            this.suma.Text = "1.- Suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(245, 60);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(119, 23);
            this.resta.TabIndex = 1;
            this.resta.Text = "2.- Resta";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(245, 118);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(119, 23);
            this.division.TabIndex = 3;
            this.division.Text = "4.- División";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Location = new System.Drawing.Point(245, 89);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(119, 23);
            this.multiplicacion.TabIndex = 2;
            this.multiplicacion.Text = "3.- Multiplicación";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // raiz_cuadrada
            // 
            this.raiz_cuadrada.Location = new System.Drawing.Point(245, 147);
            this.raiz_cuadrada.Name = "raiz_cuadrada";
            this.raiz_cuadrada.Size = new System.Drawing.Size(119, 23);
            this.raiz_cuadrada.TabIndex = 4;
            this.raiz_cuadrada.Text = "5.- Raíz Cuadrada";
            this.raiz_cuadrada.UseVisualStyleBackColor = true;
            this.raiz_cuadrada.Click += new System.EventHandler(this.raiz_cuadrada_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(245, 176);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(119, 23);
            this.salir.TabIndex = 5;
            this.salir.Text = "6.- Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // probar1
            // 
            this.probar1.AutoSize = true;
            this.probar1.Location = new System.Drawing.Point(45, 34);
            this.probar1.Name = "probar1";
            this.probar1.Size = new System.Drawing.Size(35, 13);
            this.probar1.TabIndex = 6;
            this.probar1.Text = "label1";
            // 
            // probar2
            // 
            this.probar2.AutoSize = true;
            this.probar2.Location = new System.Drawing.Point(45, 65);
            this.probar2.Name = "probar2";
            this.probar2.Size = new System.Drawing.Size(35, 13);
            this.probar2.TabIndex = 7;
            this.probar2.Text = "label1";
            // 
            // elegir_variables
            // 
            this.elegir_variables.Location = new System.Drawing.Point(48, 96);
            this.elegir_variables.Name = "elegir_variables";
            this.elegir_variables.Size = new System.Drawing.Size(134, 23);
            this.elegir_variables.TabIndex = 8;
            this.elegir_variables.Text = "botoncito";
            this.elegir_variables.UseVisualStyleBackColor = true;
            this.elegir_variables.Click += new System.EventHandler(this.elegir_variables_Click);
            // 
            // operacion
            // 
            this.operacion.AutoSize = true;
            this.operacion.Location = new System.Drawing.Point(45, 154);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(63, 13);
            this.operacion.TabIndex = 9;
            this.operacion.Text = "Resultados:";
            // 
            // creador
            // 
            this.creador.AutoSize = true;
            this.creador.Location = new System.Drawing.Point(45, 201);
            this.creador.Name = "creador";
            this.creador.Size = new System.Drawing.Size(35, 13);
            this.creador.TabIndex = 10;
            this.creador.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 262);
            this.Controls.Add(this.creador);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.elegir_variables);
            this.Controls.Add(this.probar2);
            this.Controls.Add(this.probar1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.raiz_cuadrada);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Menu";
            this.Text = "Menú Usuario";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button raiz_cuadrada;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label probar1;
        private System.Windows.Forms.Label probar2;
        private System.Windows.Forms.Button elegir_variables;
        private System.Windows.Forms.Label operacion;
        private System.Windows.Forms.Label creador;
    }
}

