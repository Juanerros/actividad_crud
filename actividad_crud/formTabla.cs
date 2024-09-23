using capa_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actividad_crud
{
    public partial class formTabla : Form
    {
        string query;

        SqlConnection con;

        public formTabla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        public void actualizar()
        {
            using (conexion cn = new conexion())
            {
                try
                {
                    query = "SELECT * FROM productos";
                    SqlDataAdapter sd = new SqlDataAdapter(query, cn.conect());
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    tabla.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la consulta " + ex);
                }
                Console.WriteLine("Todo bien");
            }
        }

        private void formTabla_Load(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
