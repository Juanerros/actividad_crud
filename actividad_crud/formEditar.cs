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
    }
}
