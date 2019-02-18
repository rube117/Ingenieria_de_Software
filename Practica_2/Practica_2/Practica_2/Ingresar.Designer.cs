namespace Practica_2
{
    partial class Ingresar
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
            this.no_sist = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_saldo = new System.Windows.Forms.TextBox();
            this.txt_saldo = new System.Windows.Forms.Label();
            this.ckb_pension = new System.Windows.Forms.CheckBox();
            this.b_guardar = new System.Windows.Forms.Button();
            this.no_version = new System.Windows.Forms.Label();
            this.creador = new System.Windows.Forms.Label();
            this.b_mostrar = new System.Windows.Forms.Button();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // no_sist
            // 
            this.no_sist.AutoSize = true;
            this.no_sist.Location = new System.Drawing.Point(27, 9);
            this.no_sist.Name = "no_sist";
            this.no_sist.Size = new System.Drawing.Size(35, 13);
            this.no_sist.TabIndex = 0;
            this.no_sist.Text = "label1";
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoSize = true;
            this.txt_nombre.Location = new System.Drawing.Point(27, 40);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(35, 13);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "label2";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(88, 37);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(100, 20);
            this.txb_nombre.TabIndex = 2;
            // 
            // txb_saldo
            // 
            this.txb_saldo.Location = new System.Drawing.Point(88, 63);
            this.txb_saldo.Name = "txb_saldo";
            this.txb_saldo.Size = new System.Drawing.Size(100, 20);
            this.txb_saldo.TabIndex = 4;
            // 
            // txt_saldo
            // 
            this.txt_saldo.AutoSize = true;
            this.txt_saldo.Location = new System.Drawing.Point(27, 66);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(35, 13);
            this.txt_saldo.TabIndex = 3;
            this.txt_saldo.Text = "label3";
            // 
            // ckb_pension
            // 
            this.ckb_pension.AutoSize = true;
            this.ckb_pension.Location = new System.Drawing.Point(34, 108);
            this.ckb_pension.Name = "ckb_pension";
            this.ckb_pension.Size = new System.Drawing.Size(80, 17);
            this.ckb_pension.TabIndex = 5;
            this.ckb_pension.Text = "checkBox1";
            this.ckb_pension.UseVisualStyleBackColor = true;
            // 
            // b_guardar
            // 
            this.b_guardar.Location = new System.Drawing.Point(39, 142);
            this.b_guardar.Name = "b_guardar";
            this.b_guardar.Size = new System.Drawing.Size(75, 23);
            this.b_guardar.TabIndex = 6;
            this.b_guardar.Text = "button1";
            this.b_guardar.UseVisualStyleBackColor = true;
            this.b_guardar.Click += new System.EventHandler(this.b_guardar_Click);
            // 
            // no_version
            // 
            this.no_version.AutoSize = true;
            this.no_version.Location = new System.Drawing.Point(204, 9);
            this.no_version.Name = "no_version";
            this.no_version.Size = new System.Drawing.Size(35, 13);
            this.no_version.TabIndex = 7;
            this.no_version.Text = "label4";
            // 
            // creador
            // 
            this.creador.AutoSize = true;
            this.creador.Location = new System.Drawing.Point(27, 220);
            this.creador.Name = "creador";
            this.creador.Size = new System.Drawing.Size(35, 13);
            this.creador.TabIndex = 8;
            this.creador.Text = "label1";
            // 
            // b_mostrar
            // 
            this.b_mostrar.Location = new System.Drawing.Point(156, 142);
            this.b_mostrar.Name = "b_mostrar";
            this.b_mostrar.Size = new System.Drawing.Size(103, 23);
            this.b_mostrar.TabIndex = 9;
            this.b_mostrar.Text = "button1";
            this.b_mostrar.UseVisualStyleBackColor = true;
            this.b_mostrar.Click += new System.EventHandler(this.b_mostrar_Click);
            // 
            // b_cerrar
            // 
            this.b_cerrar.Location = new System.Drawing.Point(99, 184);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(75, 23);
            this.b_cerrar.TabIndex = 10;
            this.b_cerrar.Text = "button1";
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_mostrar);
            this.Controls.Add(this.creador);
            this.Controls.Add(this.no_version);
            this.Controls.Add(this.b_guardar);
            this.Controls.Add(this.ckb_pension);
            this.Controls.Add(this.txb_saldo);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.no_sist);
            this.Name = "Ingresar";
            this.Text = "Ingresar Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label no_sist;
        private System.Windows.Forms.Label txt_nombre;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_saldo;
        private System.Windows.Forms.Label txt_saldo;
        private System.Windows.Forms.CheckBox ckb_pension;
        private System.Windows.Forms.Button b_guardar;
        private System.Windows.Forms.Label no_version;
        private System.Windows.Forms.Label creador;
        private System.Windows.Forms.Button b_mostrar;
        private System.Windows.Forms.Button b_cerrar;
    }
}

