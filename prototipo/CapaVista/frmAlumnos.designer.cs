namespace CapaVista
{
    partial class frmAlumnos
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.labelNombreaplicacion = new System.Windows.Forms.Label();
            this.labelIdaplicacion = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.perfilTabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siuDataSet1 = new CapaVista.siuDataSet1();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new CapaVista.siuDataSet1TableAdapters.alumnosTableAdapter();
            this.carnetalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrealumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.perfilTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(437, 48);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 10;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // labelNombreaplicacion
            // 
            this.labelNombreaplicacion.AutoSize = true;
            this.labelNombreaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreaplicacion.Location = new System.Drawing.Point(56, 66);
            this.labelNombreaplicacion.Name = "labelNombreaplicacion";
            this.labelNombreaplicacion.Size = new System.Drawing.Size(84, 13);
            this.labelNombreaplicacion.TabIndex = 17;
            this.labelNombreaplicacion.Text = "Nombre alumno:";
            // 
            // labelIdaplicacion
            // 
            this.labelIdaplicacion.AutoSize = true;
            this.labelIdaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelIdaplicacion.Location = new System.Drawing.Point(99, 24);
            this.labelIdaplicacion.Name = "labelIdaplicacion";
            this.labelIdaplicacion.Size = new System.Drawing.Size(41, 13);
            this.labelIdaplicacion.TabIndex = 16;
            this.labelIdaplicacion.Text = "Carnet:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(543, 48);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(437, 94);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(543, 94);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // perfilTabla
            // 
            this.perfilTabla.AutoGenerateColumns = false;
            this.perfilTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.perfilTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perfilTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnetalumnoDataGridViewTextBoxColumn,
            this.nombrealumnoDataGridViewTextBoxColumn,
            this.direccionalumnoDataGridViewTextBoxColumn,
            this.telefonoalumnoDataGridViewTextBoxColumn,
            this.emailalumnoDataGridViewTextBoxColumn,
            this.estatusalumnoDataGridViewTextBoxColumn});
            this.perfilTabla.DataSource = this.alumnosBindingSource;
            this.perfilTabla.Location = new System.Drawing.Point(12, 286);
            this.perfilTabla.Name = "perfilTabla";
            this.perfilTabla.Size = new System.Drawing.Size(623, 183);
            this.perfilTabla.TabIndex = 28;
            this.perfilTabla.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.perfilTabla_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(88, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(88, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(105, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Email:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(156, 197);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(212, 20);
            this.textBox6.TabIndex = 41;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 20);
            this.textBox4.TabIndex = 40;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 109);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 20);
            this.textBox5.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 20);
            this.textBox3.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(97, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Estado:";
            // 
            // siuDataSet1
            // 
            this.siuDataSet1.DataSetName = "siuDataSet1";
            this.siuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "alumnos";
            this.alumnosBindingSource.DataSource = this.siuDataSet1;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // carnetalumnoDataGridViewTextBoxColumn
            // 
            this.carnetalumnoDataGridViewTextBoxColumn.DataPropertyName = "carnet_alumno";
            this.carnetalumnoDataGridViewTextBoxColumn.HeaderText = "carnet_alumno";
            this.carnetalumnoDataGridViewTextBoxColumn.Name = "carnetalumnoDataGridViewTextBoxColumn";
            // 
            // nombrealumnoDataGridViewTextBoxColumn
            // 
            this.nombrealumnoDataGridViewTextBoxColumn.DataPropertyName = "nombre_alumno";
            this.nombrealumnoDataGridViewTextBoxColumn.HeaderText = "nombre_alumno";
            this.nombrealumnoDataGridViewTextBoxColumn.Name = "nombrealumnoDataGridViewTextBoxColumn";
            // 
            // direccionalumnoDataGridViewTextBoxColumn
            // 
            this.direccionalumnoDataGridViewTextBoxColumn.DataPropertyName = "direccion_alumno";
            this.direccionalumnoDataGridViewTextBoxColumn.HeaderText = "direccion_alumno";
            this.direccionalumnoDataGridViewTextBoxColumn.Name = "direccionalumnoDataGridViewTextBoxColumn";
            // 
            // telefonoalumnoDataGridViewTextBoxColumn
            // 
            this.telefonoalumnoDataGridViewTextBoxColumn.DataPropertyName = "telefono_alumno";
            this.telefonoalumnoDataGridViewTextBoxColumn.HeaderText = "telefono_alumno";
            this.telefonoalumnoDataGridViewTextBoxColumn.Name = "telefonoalumnoDataGridViewTextBoxColumn";
            // 
            // emailalumnoDataGridViewTextBoxColumn
            // 
            this.emailalumnoDataGridViewTextBoxColumn.DataPropertyName = "email_alumno";
            this.emailalumnoDataGridViewTextBoxColumn.HeaderText = "email_alumno";
            this.emailalumnoDataGridViewTextBoxColumn.Name = "emailalumnoDataGridViewTextBoxColumn";
            // 
            // estatusalumnoDataGridViewTextBoxColumn
            // 
            this.estatusalumnoDataGridViewTextBoxColumn.DataPropertyName = "estatus_alumno";
            this.estatusalumnoDataGridViewTextBoxColumn.HeaderText = "estatus_alumno";
            this.estatusalumnoDataGridViewTextBoxColumn.Name = "estatusalumnoDataGridViewTextBoxColumn";
            // 
            // frmAlumnos
            // 
            this.AcceptButton = this.btnInsertar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 491);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.perfilTabla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.labelNombreaplicacion);
            this.Controls.Add(this.labelIdaplicacion);
            this.Name = "frmAlumnos";
            this.Text = "frmAlumno";
            this.Load += new System.EventHandler(this.frmMantenimientoPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfilTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label labelNombreaplicacion;
        private System.Windows.Forms.Label labelIdaplicacion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView perfilTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private siuDataSet1 siuDataSet1;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private siuDataSet1TableAdapters.alumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnetalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrealumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusalumnoDataGridViewTextBoxColumn;
    }
}