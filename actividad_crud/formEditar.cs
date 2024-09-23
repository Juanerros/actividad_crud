using capa_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actividad_crud
{
    public partial class formEditar : Form
    {
        List<TextBox> tboxs;

        public formEditar()
        {
            InitializeComponent();
            tboxs = new List<TextBox> { tboxId, tboxNombre, tboxStock, tboxPrecio }; ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar(tboxs);
        }

        public void limpiar(List<TextBox> campos)
        {
            foreach (TextBox campo in campos)
            {
                campo.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 aux = new Form1();
            aux.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crud editar = new crud();
            try
            {
                editar.edit(int.Parse(tboxId.Text), tboxNombre.Text, int.Parse(tboxStock.Text), float.Parse(tboxPrecio.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta " + ex.ToString());
            }
            MessageBox.Show("Producto editado");
        }
    }
}
