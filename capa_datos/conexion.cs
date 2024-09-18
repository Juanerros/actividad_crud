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
    public class conexion : IDisposable
    {
        SqlConnection path = new SqlConnection("Data Source=CUANNET\\SQLEXPRESS;Initial Catalog=ferreteria2;Integrated Security=True;Encrypt=False");

        public SqlConnection conect()
        {
            path.Open();
            return path;
        }

        public void Dispose()
        {
            path.Close();
        }
    }
}
