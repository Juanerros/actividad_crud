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
    public partial class formLogin : Form
    {
        string tipoUsuario;
        public formLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tboxUsuario.Clear();
            tboxClave.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formRegistrar aux = new formRegistrar();
            aux.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crud logear = new crud();
            tipoUsuario =logear.login(tboxUsuario.Text, tboxClave.Text);

            switch (tipoUsuario)
            {
                case "admin":
                    Form1 aux = new Form1();
                    aux.Show();
                    break;
                case "cliente":
                    formTabla aux2 = new formTabla();
                    aux2.Show();
                    break;
                default:
                    MessageBox.Show(tipoUsuario);
                    break;
            }
            this.Hide();
        }
    }
}
