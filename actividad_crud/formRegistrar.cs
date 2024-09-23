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
    public partial class formRegistrar : Form
    {
        public formRegistrar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tboxUsuario.Clear();
            tboxClave.Clear();
            tboxNombre.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formLogin aux = new formLogin();
            aux.Show();
            this.Close();
        }
    }
}
