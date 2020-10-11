namespace AplicacionForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSecreto = new System.Windows.Forms.Button();
            this.btnAutoLlenar = new System.Windows.Forms.Button();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxSeguro = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnBasura = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chbEvento = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSecreto);
            this.groupBox1.Controls.Add(this.btnAutoLlenar);
            this.groupBox1.Controls.Add(this.cmbPuesto);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtInicial);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cbxSeguro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empledo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSecreto
            // 
            this.btnSecreto.Enabled = false;
            this.btnSecreto.Location = new System.Drawing.Point(351, 189);
            this.btnSecreto.Name = "btnSecreto";
            this.btnSecreto.Size = new System.Drawing.Size(36, 23);
            this.btnSecreto.TabIndex = 22;
            this.btnSecreto.Text = "n°";
            this.btnSecreto.UseVisualStyleBackColor = true;
            this.btnSecreto.Visible = false;
            this.btnSecreto.Click += new System.EventHandler(this.btnSecreto_Click);
            // 
            // btnAutoLlenar
            // 
            this.btnAutoLlenar.Location = new System.Drawing.Point(351, 99);
            this.btnAutoLlenar.Name = "btnAutoLlenar";
            this.btnAutoLlenar.Size = new System.Drawing.Size(23, 23);
            this.btnAutoLlenar.TabIndex = 21;
            this.btnAutoLlenar.Text = "?";
            this.btnAutoLlenar.UseVisualStyleBackColor = true;
            this.btnAutoLlenar.Click += new System.EventHandler(this.btnAutoLlenar_Click);
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "Maquiladora",
            "Transp. de Mercancia",
            "Trans. de Materia prima",
            "Supervisor",
            "Contador"});
            this.cmbPuesto.Location = new System.Drawing.Point(137, 168);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(146, 21);
            this.cmbPuesto.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbMujer);
            this.groupBox2.Controls.Add(this.rdbHombre);
            this.groupBox2.Location = new System.Drawing.Point(269, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 76);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo del empleado/a";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Location = new System.Drawing.Point(6, 42);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(71, 17);
            this.rdbMujer.TabIndex = 1;
            this.rdbMujer.TabStop = true;
            this.rdbMujer.Text = "Femenino";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Location = new System.Drawing.Point(6, 19);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(73, 17);
            this.rdbHombre.TabIndex = 0;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Masculino";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(102, 120);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 18;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(256, 143);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 20);
            this.txtCantidad.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(137, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 14;
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(112, 96);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(25, 20);
            this.txtInicial.TabIndex = 13;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(84, 70);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // cbxSeguro
            // 
            this.cbxSeguro.AutoSize = true;
            this.cbxSeguro.Location = new System.Drawing.Point(112, 200);
            this.cbxSeguro.Name = "cbxSeguro";
            this.cbxSeguro.Size = new System.Drawing.Size(35, 17);
            this.cbxSeguro.TabIndex = 9;
            this.cbxSeguro.Text = "Si";
            this.cbxSeguro.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "¿Tiene seguro?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Puesto en el que labora";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad de productos curtidos  terminados al mes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de ingreso";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de identificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inicial del empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo al año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // pcbImagen
            // 
            this.pcbImagen.ImageLocation = "C:\\Users\\jacco\\source\\repos\\AplicacionForms\\Draw\\Perfil.png";
            this.pcbImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.InitialImage")));
            this.pcbImagen.Location = new System.Drawing.Point(28, 55);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(130, 129);
            this.pcbImagen.TabIndex = 1;
            this.pcbImagen.TabStop = false;
            this.pcbImagen.Click += new System.EventHandler(this.Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(469, 234);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(119, 23);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Numero,
            this.Genero,
            this.Sueldo,
            this.Inicial,
            this.Fecha,
            this.Cantidad,
            this.Puesto,
            this.Seguro,
            this.DireccionPath});
            this.Tabla.Location = new System.Drawing.Point(28, 277);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(680, 150);
            this.Tabla.TabIndex = 3;
            this.Tabla.Click += new System.EventHandler(this.clickData);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero ID";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Sexo";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo Al Año";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // Inicial
            // 
            this.Inicial.HeaderText = "Letra inicial";
            this.Inicial.Name = "Inicial";
            this.Inicial.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de ingreso";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Productos hechos al mes";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto al que elabora";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            // 
            // Seguro
            // 
            this.Seguro.HeaderText = "¿Tiene seguro?";
            this.Seguro.Name = "Seguro";
            this.Seguro.ReadOnly = true;
            // 
            // DireccionPath
            // 
            this.DireccionPath.HeaderText = "Direccion";
            this.DireccionPath.Name = "DireccionPath";
            this.DireccionPath.ReadOnly = true;
            this.DireccionPath.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.pcbImagen);
            this.groupBox3.Location = new System.Drawing.Point(441, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 205);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Foto ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Da click en la imagen";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(13, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 53);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnVaciar);
            this.groupBox4.Controls.Add(this.btnBasura);
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Location = new System.Drawing.Point(628, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(80, 205);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Botones";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Image = ((System.Drawing.Image)(resources.GetObject("btnVaciar.Image")));
            this.btnVaciar.Location = new System.Drawing.Point(13, 146);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(57, 43);
            this.btnVaciar.TabIndex = 24;
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnBasura
            // 
            this.btnBasura.Image = ((System.Drawing.Image)(resources.GetObject("btnBasura.Image")));
            this.btnBasura.Location = new System.Drawing.Point(13, 87);
            this.btnBasura.Name = "btnBasura";
            this.btnBasura.Size = new System.Drawing.Size(57, 53);
            this.btnBasura.TabIndex = 23;
            this.btnBasura.UseVisualStyleBackColor = true;
            this.btnBasura.Click += new System.EventHandler(this.btnBasura_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(628, 233);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chbEvento
            // 
            this.chbEvento.AutoSize = true;
            this.chbEvento.Location = new System.Drawing.Point(76, 254);
            this.chbEvento.Name = "chbEvento";
            this.chbEvento.Size = new System.Drawing.Size(278, 17);
            this.chbEvento.TabIndex = 7;
            this.chbEvento.Text = "¿Desea consultar los datos al hacer click en la tabla?";
            this.chbEvento.UseVisualStyleBackColor = true;
            this.chbEvento.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.chbEvento);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Empresa curtidora de pieles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox cbxSeguro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAutoLlenar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBasura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionPath;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chbEvento;
        private System.Windows.Forms.Button btnSecreto;
    }
}

