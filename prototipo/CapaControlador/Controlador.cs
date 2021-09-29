using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        //frmLogin
        public int InicarSesion(string documento_compraenca, string codigo_producto, int validar)
        {
            validar = sn.funIniciarSesion(documento_compraenca, codigo_producto, validar);

            return validar;
        }

        //frmMantenimientoAplicacion ___________________--------------------------------------------------------------------------------------------------------------
        public void insertarAplicacion(string carnet_alumno, string codigo_jornada, string codigo_seccion, string codigo_aula, string codigo_curso, string codigo_carrrera, float nota_asignacioncursoalumnos)
        {
            sn.funInsertar(carnet_alumno,  codigo_jornada,  codigo_seccion,  codigo_aula, codigo_curso, codigo_carrrera,  nota_asignacioncursoalumnos);
        }

        public void modificarAplicacion(string carnet_alumno, string codigo_jornada, string codigo_seccion, string codigo_aula, string codigo_curso, string codigo_carrrera, float nota_asignacioncursoalumnos)
        {
            sn.funModificar(carnet_alumno,  codigo_jornada,  codigo_seccion,  codigo_aula,  codigo_curso, codigo_carrrera,  nota_asignacioncursoalumnos);


        }

        public (string, string, string, string,string, float) buscarAplicacion(string carnet_alumno, string codigo_jornada, string codigo_seccion, string codigo_aula, string codigo_curso, string codigo_carrrera, float nota_asignacioncursoalumnos)
        {
            sn.funBuscar(carnet_alumno,  codigo_jornada,  codigo_seccion,  codigo_aula,  codigo_curso, codigo_carrrera,  nota_asignacioncursoalumnos);
            return (  codigo_jornada,  codigo_seccion,  codigo_aula,  codigo_curso, codigo_carrrera,  nota_asignacioncursoalumnos);
        }

        public void eliminarAplicacion(string carnet_alumno)
        {
            sn.funEliminar(carnet_alumno);
        }

        //frmPerfiles
        public DataTable PerfilllenarTbl(string tabla2)
        {
            OdbcDataAdapter dt = sn.PerfilllenarTbl(tabla2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public DataTable PerfilllenarTblPersonal(string tabla2, string condicion)
        {
            OdbcDataAdapter dt = sn.PerfilllenarTblPersonal(tabla2, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public DataTable PerfilllenarNombre(string tabla, string condicion)
        {
            OdbcDataAdapter dt = sn.PerfilllenarNombre(tabla, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public void Perfilagregar(string tabla3, string valor1, string valor2)
        {
            sn.Perfilagregar(tabla3, valor1, valor2);
        }

        public void Perfileliminar(string tabla3, string valor1, string valor2)
        {
            sn.Perfileliminar(tabla3, valor1, valor2);
        }

        public void perfilPerfileliminartodo(string tabla3, string valor1)
        {
            sn.Perfileliminartodo(tabla3, valor1);
        }

        public void perfilPerfilagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            sn.Perfilagregartodo(tabla3, valor1, valor2, tabla2);
        }

        



        //frmRecuperarContraseña
        //frmRContraseña
     


        //Mantenimiento Perfil


        public void insertarPerfil(string carnet_alumno, string nombre_alumno, string  direccion_alumno, string telefono_alumno,string email_alumno, string estatus_alumno)
        {
            sn.funInsertar( carnet_alumno,  nombre_alumno,  direccion_alumno,  telefono_alumno, email_alumno,  estatus_alumno);
        }

        public void modificarPerfil(string carnet_alumno, string nombre_alumno, string direccion_alumno, string telefono_alumno, string email_alumno, string estatus_alumno)
        {
            sn.funModificar(carnet_alumno, nombre_alumno, direccion_alumno, telefono_alumno, email_alumno, estatus_alumno);


        }

        public (string, string, string, string, string) buscarPerfil(string carnet_alumno, string nombre_alumno, string direccion_alumno, string telefono_alumno, string email_alumno, string estatus_alumno)
        {
            sn.funBuscar(carnet_alumno, nombre_alumno, direccion_alumno, telefono_alumno, email_alumno, estatus_alumno);
            return (nombre_alumno, direccion_alumno, telefono_alumno, email_alumno, estatus_alumno);
        }

        public void eliminarPerfil(string carnet_alumno)
        {
            sn.funEliminarPerfil(carnet_alumno);
        }

       
    }
}
