namespace CapaVista
{
    partial class frmAsignacionAlumnos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignacionAlumnos));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNombreaplicacion = new System.Windows.Forms.Label();
            this.labelIdaplicacion = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.siuDataSet = new CapaVista.siuDataSet();
            this.asignacioncursosalumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignacioncursosalumnosTableAdapter = new CapaVista.siuDataSetTableAdapters.asignacioncursosalumnosTableAdapter();
            this.codigocarreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigojornadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoseccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoaulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigocursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnetalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaasignacioncursoalumnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacioncursosalumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(787, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(27, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(451, 68);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 10;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 0;
            // 
            // labelNombreaplicacion
            // 
            this.labelNombreaplicacion.AutoSize = true;
            this.labelNombreaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreaplicacion.Location = new System.Drawing.Point(38, 68);
            this.labelNombreaplicacion.Name = "labelNombreaplicacion";
            this.labelNombreaplicacion.Size = new System.Drawing.Size(84, 13);
            this.labelNombreaplicacion.TabIndex = 17;
            this.labelNombreaplicacion.Text = "Codigo Jornada:";
            // 
            // labelIdaplicacion
            // 
            this.labelIdaplicacion.AutoSize = true;
            this.labelIdaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelIdaplicacion.Location = new System.Drawing.Point(44, 23);
            this.labelIdaplicacion.Name = "labelIdaplicacion";
            this.labelIdaplicacion.Size = new System.Drawing.Size(78, 13);
            this.labelIdaplicacion.TabIndex = 16;
            this.labelIdaplicacion.Text = "codigo carrera:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(551, 66);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(451, 106);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(551, 106);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigocarreraDataGridViewTextBoxColumn,
            this.codigojornadaDataGridViewTextBoxColumn,
            this.codigoseccionDataGridViewTextBoxColumn,
            this.codigoaulaDataGridViewTextBoxColumn,
            this.codigocursoDataGridViewTextBoxColumn,
            this.carnetalumnoDataGridViewTextBoxColumn,
            this.notaasignacioncursoalumnosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asignacioncursosalumnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 192);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(143, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 20);
            this.textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(143, 103);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 20);
            this.textBox5.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(55, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Codigo Aula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Codigo seccion:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(143, 183);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(212, 20);
            this.textBox6.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(44, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Codigo Curso:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(143, 253);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(212, 20);
            this.textBox7.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(88, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "nota";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(143, 218);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(212, 20);
            this.textBox8.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(38, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Carnet alumno";
            // 
            // siuDataSet
            // 
            this.siuDataSet.DataSetName = "siuDataSet";
            this.siuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignacioncursosalumnosBindingSource
            // 
            this.asignacioncursosalumnosBindingSource.DataMember = "asignacioncursosalumnos";
            this.asignacioncursosalumnosBindingSource.DataSource = this.siuDataSet;
            // 
            // asignacioncursosalumnosTableAdapter
            // 
            this.asignacioncursosalumnosTableAdapter.ClearBeforeFill = true;
            // 
            // codigocarreraDataGridViewTextBoxColumn
            // 
            this.codigocarreraDataGridViewTextBoxColumn.DataPropertyName = "codigo_carrera";
            this.codigocarreraDataGridViewTextBoxColumn.HeaderText = "codigo_carrera";
            this.codigocarreraDataGridViewTextBoxColumn.Name = "codigocarreraDataGridViewTextBoxColumn";
            // 
            // codigojornadaDataGridViewTextBoxColumn
            // 
            this.codigojornadaDataGridViewTextBoxColumn.DataPropertyName = "codigo_jornada";
            this.codigojornadaDataGridViewTextBoxColumn.HeaderText = "codigo_jornada";
            this.codigojornadaDataGridViewTextBoxColumn.Name = "codigojornadaDataGridViewTextBoxColumn";
            // 
            // codigoseccionDataGridViewTextBoxColumn
            // 
            this.codigoseccionDataGridViewTextBoxColumn.DataPropertyName = "codigo_seccion";
            this.codigoseccionDataGridViewTextBoxColumn.HeaderText = "codigo_seccion";
            this.codigoseccionDataGridViewTextBoxColumn.Name = "codigoseccionDataGridViewTextBoxColumn";
            // 
            // codigoaulaDataGridViewTextBoxColumn
            // 
            this.codigoaulaDataGridViewTextBoxColumn.DataPropertyName = "codigo_aula";
            this.codigoaulaDataGridViewTextBoxColumn.HeaderText = "codigo_aula";
            this.codigoaulaDataGridViewTextBoxColumn.Name = "codigoaulaDataGridViewTextBoxColumn";
            // 
            // codigocursoDataGridViewTextBoxColumn
            // 
            this.codigocursoDataGridViewTextBoxColumn.DataPropertyName = "codigo_curso";
            this.codigocursoDataGridViewTextBoxColumn.HeaderText = "codigo_curso";
            this.codigocursoDataGridViewTextBoxColumn.Name = "codigocursoDataGridViewTextBoxColumn";
            // 
            // carnetalumnoDataGridViewTextBoxColumn
            // 
            this.carnetalumnoDataGridViewTextBoxColumn.DataPropertyName = "carnet_alumno";
            this.carnetalumnoDataGridViewTextBoxColumn.HeaderText = "carnet_alumno";
            this.carnetalumnoDataGridViewTextBoxColumn.Name = "carnetalumnoDataGridViewTextBoxColumn";
            // 
            // notaasignacioncursoalumnosDataGridViewTextBoxColumn
            // 
            this.notaasignacioncursoalumnosDataGridViewTextBoxColumn.DataPropertyName = "nota_asignacioncursoalumnos";
            this.notaasignacioncursoalumnosDataGridViewTextBoxColumn.HeaderText = "nota_asignacioncursoalumnos";
            this.notaasignacioncursoalumnosDataGridViewTextBoxColumn.Name = "notaasignacioncursoalumnosDataGridViewTextBoxColumn";
            // 
            // frmAsignacionAlumnos
            // 
            this.AcceptButton = this.btnInsertar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(658, 491);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNombreaplicacion);
            this.Controls.Add(this.labelIdaplicacion);
            this.Name = "frmAsignacionAlumnos";
            this.Text = "FrmAdignacionAlumno";
            this.Load += new System.EventHandler(this.frmMantenimientoAplicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacioncursosalumnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNombreaplicacion;
        private System.Windows.Forms.Label labelIdaplicacion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label5;
        private siuDataSet siuDataSet;
        private System.Windows.Forms.BindingSource asignacioncursosalumnosBindingSource;
        private siuDataSetTableAdapters.asignacioncursosalumnosTableAdapter asignacioncursosalumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigocarreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigojornadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoseccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoaulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigocursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnetalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaasignacioncursoalumnosDataGridViewTextBoxColumn;
    }
}