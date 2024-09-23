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
    public partial class formBorrar : Form
    {
        public formBorrar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tboxId.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 aux = new Form1();
            aux.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crud borrar = new crud();
            try
            {
                borrar.delete(int.Parse(tboxId.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta " + ex.ToString());
            }
            MessageBox.Show("Producto borrado");
        }
    }
}
