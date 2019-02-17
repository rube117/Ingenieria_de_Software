namespace Practica_1
{
    partial class Raiz_Cuadrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raiz_Cuadrada));
            this.b_menu = new System.Windows.Forms.Button();
            this.probar1 = new System.Windows.Forms.RadioButton();
            this.probar2 = new System.Windows.Forms.RadioButton();
            this.calcular = new System.Windows.Forms.Button();
            this.operacion = new System.Windows.Forms.Label();
            this.b_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_menu
            // 
            this.b_menu.Location = new System.Drawing.Point(46, 137);
            this.b_menu.Name = "b_menu";
            this.b_menu.Size = new System.Drawing.Size(130, 23);
            this.b_menu.TabIndex = 0;
            this.b_menu.Text = "Volver al Menú ↵";
            this.b_menu.UseVisualStyleBackColor = true;
            this.b_menu.Click += new System.EventHandler(this.b_menu_Click);
            // 
            // probar1
            // 
            this.probar1.AutoSize = true;
            this.probar1.Location = new System.Drawing.Point(46, 34);
            this.probar1.Name = "probar1";
            this.probar1.Size = new System.Drawing.Size(85, 17);
            this.probar1.TabIndex = 3;
            this.probar1.TabStop = true;
            this.probar1.Text = "radioButton1";
            this.probar1.UseVisualStyleBackColor = true;
            // 
            // probar2
            // 
            this.probar2.AutoSize = true;
            this.probar2.Location = new System.Drawing.Point(46, 57);
            this.probar2.Name = "probar2";
            this.probar2.Size = new System.Drawing.Size(85, 17);
            this.probar2.TabIndex = 4;
            this.probar2.TabStop = true;
            this.probar2.Text = "radioButton1";
            this.probar2.UseVisualStyleBackColor = true;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(191, 31);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 5;
            this.calcular.Text = "3. Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // operacion
            // 
            this.operacion.AutoSize = true;
            this.operacion.Location = new System.Drawing.Point(310, 34);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(63, 13);
            this.operacion.TabIndex = 6;
            this.operacion.Text = "Resultados:";
            // 
            // b_ingresar
            // 
            this.b_ingresar.Location = new System.Drawing.Point(46, 97);
            this.b_ingresar.Name = "b_ingresar";
            this.b_ingresar.Size = new System.Drawing.Size(130, 23);
            this.b_ingresar.TabIndex = 7;
            this.b_ingresar.Text = "otro botoncito";
            this.b_ingresar.UseVisualStyleBackColor = true;
            this.b_ingresar.Click += new System.EventHandler(this.b_ingresar_Click);
            // 
            // Raiz_Cuadrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(414, 207);
            this.Controls.Add(this.b_ingresar);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.probar2);
            this.Controls.Add(this.probar1);
            this.Controls.Add(this.b_menu);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Raiz_Cuadrada";
            this.Text = "Raiz_Cuadrada";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Raiz_Cuadrada_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_menu;
        private System.Windows.Forms.RadioButton probar1;
        private System.Windows.Forms.RadioButton probar2;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label operacion;
        private System.Windows.Forms.Button b_ingresar;
    }
}