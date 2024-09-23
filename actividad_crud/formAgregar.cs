using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capa_datos;

namespace actividad_crud
{
    public partial class formAgregar : Form
    {
        List<TextBox> tboxs;

        public formAgregar()
        {
            InitializeComponent();
            tboxs = new List<TextBox> {tboxNombre, tboxStock, tboxPrecio};
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar(tboxs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 aux = new Form1();
            aux.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crud agregar = new crud();
            try
            {
                agregar.create(tboxNombre.Text, int.Parse(tboxStock.Text), float.Parse(tboxPrecio.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta " + ex.ToString());
            }
            MessageBox.Show("Producto agregado");
        }

        public void limpiar(List<TextBox> campos)
        {
            foreach (TextBox campo in campos)
            {
                campo.Clear();
            }
        }
    }
}
