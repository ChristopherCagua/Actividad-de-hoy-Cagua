using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDatos
{
    public static class Persona
    {
        private static string CadenaConex = @"server=MAQUINA-DE-GUER\SQLEXPRESS; database=TI2021; Integrated Security=true";

        public static DataTable getDatos()
        {
            string sql = "select cedula, apellidos, nombres, fechaNacimiento, peso "+ "from personas order by apellidos, nombres";

            SqlConnection conexion = new SqlConnection(CadenaConex);
            SqlCommand comando = new SqlCommand(sql, conexion);
            //cuando se pone el adaptador no es necesario abrir y cerrar la coneccion porque el la abre y cierra para sacar la informacion
            SqlDataAdapter ad = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static int Insertar(string cedula, string apellidos, string nombres, DateTime fechaNacimiento, double peso)
        {
            SqlConnection conexion = new SqlConnection(CadenaConex);
            string sql = "insert into personas(cedula, apellidos, nombres, fechaNacimiento, peso)";
            sql += "values(@cedula, @apellidos, @nombres, @fechaNacimiento, @peso)";
            //3. ejecutar la operacion
            SqlCommand comando = new SqlCommand(sql, conexion);
            //3.1 configurar los parametros @cedula, @apellidos, @nombres, @fechadenacimiento, @peso
            comando.Parameters.Add(new SqlParameter("@cedula", cedula));
            comando.Parameters.Add(new SqlParameter("@apellidos", apellidos));
            comando.Parameters.Add(new SqlParameter("@nombres", nombres));
            comando.Parameters.Add(new SqlParameter("@fechaNacimiento", fechaNacimiento));
            comando.Parameters.Add(new SqlParameter("@peso", peso));
            //3.2 abrir la conexion 
            conexion.Open();
            //3.3 Insertar el registro en la Base de datos
            int res = comando.ExecuteNonQuery();
            //4 Cerrar la conexion
            conexion.Close();
            return res;
        }
    }

}
