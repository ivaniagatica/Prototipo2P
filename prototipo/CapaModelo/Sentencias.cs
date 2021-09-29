using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Sentencias
    {


        Conexion cn = new Conexion();
        OdbcCommand Comm;
        //frmLogin
        public int funIniciarSesion(string Usuario, string Contraseña, int validar)
        {
            try
            {
                string con = "";

                string Query = "select * from `componenteseguridad`.`Usuario` where nombre='" + Usuario + "';";

                OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();

                if (busqueda.Read())
                {
                    con = busqueda["contraseña"].ToString();
                }

                validar = Contraseña.CompareTo(con);


            }
            catch
            {

            }

            return validar;


        }


        //frmMantenimientoAplicacion -----------------------------------------------------------------------------------------------------------------------------------
        public void funInsertar(string carnet_alumno, string codigo_jornada, string codigo_seccion, string codigo_aula, string codigo_curso, string codigo_carrrera, float nota_asignacioncursoalumnos)
        {

            string cadena = "INSERT INTO" +
            " `siu`.`asignacioncursosalumnos` VALUES (" + "'" + carnet_alumno + "', '" + codigo_jornada + "' , " + codigo_seccion + ", '" + codigo_aula + "', '" + codigo_curso + "', '" + codigo_carrrera + "', '" + nota_asignacioncursoalumnos + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();


        }


        public void funModificar(string carnet_alumno, string codigo_jornada, string codigo_seccion, string codigo_aula, string codigo_curso, string codigo_carrrera, float nota_asignacioncursoalumnos)
        {

            string cadena = "UPDATE siu.asignacioncursosalumnos set carnet_alumno ='" + carnet_alumno
              + "',codigo_jornada ='" + codigo_jornada + "',codigo_seccion = " + codigo_seccion + ", codigo_aula = '" + codigo_aula + ", codigo_curso = '" + codigo_curso + ", codigo_carrrera = '" + codigo_carrrera + ", nota_asignacioncursoalumnos = '" + nota_asignacioncursoalumnos + "'  where carnet_alumno= '" + carnet_alumno + "';";


            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();




        }

        public void funEliminar(string carnet_alumno)
        {

            string cadena = "delete from siu.asignacioncursosalumnos where carnet_alumno ='" + carnet_alumno + "';";


            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }




        public (string, string, string,string,string,float) funBuscar(string carnet_alumno, string codigo_jornada, string codigo_seccion, string codigo_aula, string codigo_curso, string codigo_carrrera, float nota_asignacioncursoalumnos)
        {


            string Query = "select * from `siu`.`asignacioncursosalumnos` where carnet_alumno='" + carnet_alumno + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                codigo_jornada = busqueda["codigo_jornada"].ToString();
                codigo_seccion = busqueda["codigo_seccion"].ToString();
                codigo_aula = busqueda["codigo_aula"].ToString();
                codigo_curso = busqueda["codigo_curso"].ToString();
                codigo_carrrera = busqueda["codigo_carrrera"].ToString();
                nota_asignacioncursoalumnos = float.Parse(busqueda["nota_asignacioncursoalumnos"].ToString());
            }


            return (codigo_jornada, codigo_seccion, codigo_aula, codigo_curso, codigo_carrrera, nota_asignacioncursoalumnos);


        }

        //frmPerfiles

        public OdbcDataAdapter PerfilllenarTbl(string tabla2)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT pkid, nombre FROM " + tabla2 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter PerfilllenarTblPersonal(string tabla2, string condicion)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT perfil.pkid, perfil.nombre FROM " + tabla2 + "  LEFT JOIN usuarioperfil ON perfil.pkid = usuarioperfil.fkidperfil LEFT JOIN usuario ON usuarioperfil.fkidusuario = usuario.pkid WHERE usuario.pkid = " + condicion + " ORDER BY perfil.pkid;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter PerfilllenarNombre(string tabla, string condicion)// metodo  que obtinene el contenido
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT nombre FROM " + tabla + " WHERE pkid = " + condicion + "  ;";
            OdbcDataAdapter dataName = new OdbcDataAdapter(sql, cn.conexion());
            return dataName;
        }

        public void Perfilagregar(string tabla3, string valor1, string valor2)
        {
            string sql = "INSERT INTO " + tabla3 + " (fkidUsuario, fkidPerfil) Values( '" + valor1 + "', '" + valor2 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void Perfileliminar(string tabla3, string valor1, string valor2)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkidUsuario = '" + valor1 + "' AND  fkidperfil='" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void Perfileliminartodo(string tabla3, string valor1)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkidUsuario = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void Perfilagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            string sql = "INSERT INTO usuarioperfil (fkidUsuario, fkidPerfil) SELECT NULL, pkid FROM perfil;";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();

            string sql2 = "UPDATE usuarioperfil SET " + tabla3 + " = '" + valor1 + "' WHERE fkidUsuario = '';";
            OdbcCommand consulta2 = new OdbcCommand(sql2, cn.conexion());
            consulta2.ExecuteNonQuery();
        }

        //frmAplicaciones
        public OdbcDataAdapter aplicacionllenarTbl(string tabla2)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT pkid, nombre FROM " + tabla2 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter aplicacionllenarTblPerfil(string tabla4)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT pkid, nombre FROM " + tabla4 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter aplicacionllenarTblPersonal(string tabla2, string condicion)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT aplicacion.pkid, aplicacion.nombre FROM " + tabla2 + "  LEFT JOIN UsuarioAplicacionAsignados ON aplicacion.pkid = UsuarioAplicacionAsignados.fkidaplicacion LEFT JOIN usuario ON UsuarioAplicacionAsignados.fkidusuario = usuario.pkid WHERE usuario.pkid = " + condicion + " ORDER BY aplicacion.pkid;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter aplicacionllenarNombre(string tabla, string condicion)// metodo  que obtinene el contenido
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT nombre FROM " + tabla + " WHERE pkid = " + condicion + "  ;";
            OdbcDataAdapter dataName = new OdbcDataAdapter(sql, cn.conexion());
            return dataName;
        }

        public void aplicacionagregar(string tabla3, string valor1, string valor2)
        {
            string sql = "INSERT INTO " + tabla3 + " (fkidUsuario, fkidaplicacion) Values( '" + valor1 + "', '" + valor2 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void aplicacioneliminar(string tabla3, string valor1, string valor2)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkidUsuario = '" + valor1 + "' AND  fkidaplicacion='" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void aplicacioneliminartodo(string tabla3, string valor1)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkidUsuario = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void aplicacionagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            string sql = "INSERT INTO UsuarioAplicacionAsignados (fkidUsuario, fkidaplicacion) SELECT NULL, pkid FROM aplicacion;";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();

            string sql2 = "UPDATE UsuarioAplicacionAsignados SET " + tabla3 + " = '" + valor1 + "' WHERE fkidUsuario = '';";
            OdbcCommand consulta2 = new OdbcCommand(sql2, cn.conexion());
            consulta2.ExecuteNonQuery();
        }

        //frmRecuperarContraseña
        public OdbcDataReader funcModificarContraseña(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader mostrar = Comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo-modificar ", Error);
                return null;
            }
        }
        public void funRecuperar(string Usuario, string Contraseña)
        {
            try
            {
                string cadena = "UPDATE" +
                " `componenteseguridad`.`Usuario` SET contraseña=" + Contraseña + "WHERE nombre=" + Usuario + "';";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo-modificar ", Error);
            }
        }

        public OdbcDataReader llenarcbxUsuario(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        //mantenimiento Perfil---------------------------------------------------------------------------------------------------------------

        public void funInsertar(string carnet_alumno, string nombre_alumno, string direccion_alumno, string telefono_alumno, string email_alumno, string estatus_alumno)
        {

            string cadena = "INSERT INTO" +
            " `siu`.`alumnos` VALUES (" + "'" + carnet_alumno + "', '" + nombre_alumno + "' , '" + direccion_alumno + "', '" + telefono_alumno + "', '" + email_alumno + "', '" + estatus_alumno + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();


        }


        public void funModificar(string carnet_alumno, string nombre_alumno, string direccion_alumno, string telefono_alumno, string email_alumno, string estatus_alumno)
        {

            string cadena = "UPDATE siu.alumnos set carnet_alumno ='" + carnet_alumno
              + "',nombre_alumno ='" + nombre_alumno + "',direccion_alumno = '" + direccion_alumno + "', telefono_alumno = '" + telefono_alumno + "' , email_alumno = '" + email_alumno + "' , estatus_alumno = '" + estatus_alumno + "'  where carnet_alumno= '" + carnet_alumno + "';";


            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();




        }

        public void funEliminarPerfil(string carnet_alumno)
        {

            string cadena = "delete from siu.alumnos where carnet_alumno ='" + carnet_alumno + "';";


            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }




        public (string, string, string, string,string) funBuscar(string carnet_alumno, string nombre_alumno, string direccion_alumno, string telefono_alumno, string email_alumno, string estatus_alumno)
        {


            string Query = "select * from `siu`.`alumnos` where carnet_alumno='" + carnet_alumno + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                nombre_alumno = busqueda["nombre_alumno"].ToString();
                direccion_alumno = busqueda["direccion_alumno"].ToString();
                telefono_alumno = busqueda["telefono_alumno"].ToString();
                email_alumno = busqueda["email_alumno"].ToString();
                estatus_alumno = busqueda["estatus_alumno"].ToString();
            }


            return (nombre_alumno, direccion_alumno, telefono_alumno, email_alumno, estatus_alumno);


        }




    }
}
