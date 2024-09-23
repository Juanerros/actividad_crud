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
        SqlCommand cmd = new SqlCommand();
        string connectionString = "Data Source=CUANNET\\SQLEXPRESS;Initial Catalog=ferreteria2;Integrated Security=True;Encrypt=False";

        public void register(string usu, string clave, string nom, string tipo)
        {
            using (conexion cn = new conexion())
            {
                cmd.Connection = cn.conect();
                cmd.CommandText = "registrar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usu);
                cmd.Parameters.AddWithValue("@clave", clave);
                cmd.Parameters.AddWithValue("@nombre", nom);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.Connection.Close();
            }
        }

        public string login(string usu, string clave)
        {
            string tipoUsuario;

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("logear", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", usu);
                cmd.Parameters.AddWithValue("@clave", clave);

                try
                {
                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) tipoUsuario = reader["tipo"].ToString();
                        else tipoUsuario = "Usuario y/o clave incorrecto/s";
                    }
                }
                catch (Exception ex)
                {
                    tipoUsuario = "Error: " + ex.Message;
                }
            }

            cmd.Parameters.Clear();
            return tipoUsuario;

            //using (conexion cn = new conexion())
            //{
            //    cmd.Connection = cn.conect();
            //    cmd.CommandText = "logear";
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@usuario", usu);
            //    cmd.Parameters.AddWithValue("@clave", clave);
            //    cmd.ExecuteNonQuery();
            //    cmd.Parameters.Clear();

            //    cmd.Connection.Close();
            //}
        }

        public void create(string nom, int stock, float precio)
        {
            using(conexion cn = new conexion())
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
        }

        public void edit(int id, string nom, int stock, float precio)
        {
            using(conexion cn = new conexion())
            {
                cmd.Connection = cn.conect();

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
            using (conexion cn = new conexion())
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
}
