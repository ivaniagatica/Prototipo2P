﻿
namespace CapaVista
{
    partial class frmMIDSeguridad
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAplicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsignacionDeAplicacionAUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.informeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCambioContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mantenimientosToolStripMenuItem,
            this.asignacionesToolStripMenuItem1,
            this.btnCambioContraseña,
            this.btnBitacora});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrarSesion});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(28, 24);
            this.inicioToolStripMenuItem.Text = "x";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(109, 24);
            this.btnCerrarSesion.Text = "Salir";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 24);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAplicacion,
            this.btnPerfiles});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimiento";
            // 
            // btnAplicacion
            // 
            this.btnAplicacion.Name = "btnAplicacion";
            this.btnAplicacion.Size = new System.Drawing.Size(188, 24);
            this.btnAplicacion.Text = "Asignar alumno";
            this.btnAplicacion.Click += new System.EventHandler(this.btnAplicacion_Click);
            // 
            // btnPerfiles
            // 
            this.btnPerfiles.Name = "btnPerfiles";
            this.btnPerfiles.Size = new System.Drawing.Size(188, 24);
            this.btnPerfiles.Text = "Alumnos";
            this.btnPerfiles.Click += new System.EventHandler(this.btnPerfiles_Click);
            // 
            // asignacionesToolStripMenuItem1
            // 
            this.asignacionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAsignacionDeAplicacionAUsuarios,
            this.informeProveedoresToolStripMenuItem});
            this.asignacionesToolStripMenuItem1.Name = "asignacionesToolStripMenuItem1";
            this.asignacionesToolStripMenuItem1.Size = new System.Drawing.Size(84, 24);
            this.asignacionesToolStripMenuItem1.Text = "Informes";
            // 
            // btnAsignacionDeAplicacionAUsuarios
            // 
            this.btnAsignacionDeAplicacionAUsuarios.Name = "btnAsignacionDeAplicacionAUsuarios";
            this.btnAsignacionDeAplicacionAUsuarios.Size = new System.Drawing.Size(228, 24);
            this.btnAsignacionDeAplicacionAUsuarios.Text = "Informe alumno";
            // 
            // informeProveedoresToolStripMenuItem
            // 
            this.informeProveedoresToolStripMenuItem.Name = "informeProveedoresToolStripMenuItem";
            this.informeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.informeProveedoresToolStripMenuItem.Text = "informe asignaciones";
            // 
            // btnCambioContraseña
            // 
            this.btnCambioContraseña.Name = "btnCambioContraseña";
            this.btnCambioContraseña.Size = new System.Drawing.Size(136, 24);
            this.btnCambioContraseña.Text = "Configuraciones";
            // 
            // btnBitacora
            // 
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(66, 24);
            this.btnBitacora.Text = "Ayuda";
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // frmMIDSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "frmMIDSeguridad";
            this.Text = "frmMIDIvania0901-18-19828";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAplicacion;
        private System.Windows.Forms.ToolStripMenuItem btnPerfiles;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnAsignacionDeAplicacionAUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnCambioContraseña;
        private System.Windows.Forms.ToolStripMenuItem btnBitacora;
        private System.Windows.Forms.ToolStripMenuItem informeProveedoresToolStripMenuItem;
    }
}