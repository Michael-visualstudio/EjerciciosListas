namespace EjerciciosListas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.gridAsignaturas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaxCreditos = new System.Windows.Forms.TextBox();
            this.txtMinCreditos = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Créditos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carrera";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(32, 77);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(81, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Location = new System.Drawing.Point(148, 77);
            this.txtAsignatura.MaxLength = 30;
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(131, 20);
            this.txtAsignatura.TabIndex = 4;
            this.txtAsignatura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(321, 77);
            this.txtCreditos.MaxLength = 2;
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(49, 20);
            this.txtCreditos.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(598, 75);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Sistemas",
            "Tecnologias de la Informacion",
            "Contabilidad y Auditoria",
            "Negocios Internacionales",
            "Enfermeria"});
            this.cmbCarrera.Location = new System.Drawing.Point(431, 77);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(148, 21);
            this.cmbCarrera.TabIndex = 6;
            // 
            // gridAsignaturas
            // 
            this.gridAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsignaturas.Location = new System.Drawing.Point(15, 189);
            this.gridAsignaturas.Name = "gridAsignaturas";
            this.gridAsignaturas.Size = new System.Drawing.Size(658, 249);
            this.gridAsignaturas.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Listado de Asignaturas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Filtrar por Carrera";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(148, 114);
            this.txtCarrera.MaxLength = 30;
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(131, 20);
            this.txtCarrera.TabIndex = 10;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(321, 112);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(61, 23);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Maxima cantidad de creditos\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Minima cantidad de creditos";
            // 
            // txtMaxCreditos
            // 
            this.txtMaxCreditos.Location = new System.Drawing.Point(593, 114);
            this.txtMaxCreditos.Name = "txtMaxCreditos";
            this.txtMaxCreditos.Size = new System.Drawing.Size(80, 20);
            this.txtMaxCreditos.TabIndex = 14;
            // 
            // txtMinCreditos
            // 
            this.txtMinCreditos.Location = new System.Drawing.Point(593, 154);
            this.txtMinCreditos.Name = "txtMinCreditos";
            this.txtMinCreditos.Size = new System.Drawing.Size(80, 20);
            this.txtMinCreditos.TabIndex = 14;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(708, 112);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 60);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtMinCreditos);
            this.Controls.Add(this.txtMaxCreditos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridAsignaturas);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtAsignatura);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Listas genéricas";
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.DataGridView gridAsignaturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaxCreditos;
        private System.Windows.Forms.TextBox txtMinCreditos;
        private System.Windows.Forms.Button btnMostrar;
    }
}

