using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace capa_datos
{
    public class crud
    {
        conexion cn = new conexion();
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        public void logear(string usu, string clave)
        {
            cmd.Connection = cn.conect();
            cmd.CommandText = "logear";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", usu);
            cmd.Parameters.AddWithValue("@clave", clave);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd.Connection.Close();
        }

        public void create(string nom, int stock, float precio)
        {
            cmd.Connection = cn.conect();
            cmd.CommandText = "insertar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nom);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd.Connection.Close();
        }

        public void edit(int id, string nom, int stock, float precio)
        {
            using(con = cn.conect())
            {
                cmd.Connection = con;

                cmd.CommandText = "editar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id);
                cmd.Parameters.AddWithValue("@nombre", nom);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.Connection.Close();
            }
        }

        public void delete(int id)
        {
            cmd.Connection = cn.conect();
            cmd.CommandText = "borrar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd.Connection.Close();
        }

    }
}
