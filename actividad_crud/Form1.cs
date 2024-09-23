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
    public partial class Form1 : Form
    {
        bool click = true;

        List<PictureBox> pics;
        List<Label> labels;

        public Form1()
        {
            InitializeComponent();
            pics = new List<PictureBox> { picAgregar, picBorrar, picEditar, picVer };
            labels = new List<Label> { txtAgregar, txtBorrar, txtEditar, txtVer };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            vistaItems(pics, labels);
        }

        public void vistaItems(List<PictureBox> imgs, List<Label> txts)
        {
            foreach (PictureBox img in imgs)
            {
                img.Enabled = click;
            }
            foreach (Label txt in txts)
            {
                txt.Enabled = click;
            }

            click = !click;
        }

        private void picAgregar_Click(object sender, EventArgs e)
        {
            formAgregar aux = new formAgregar();
            aux.Show();
            this.Hide();
        }

        private void picEditar_Click(object sender, EventArgs e)
        {
            formEditar aux = new formEditar();
            aux.Show();
            this.Hide();
        }

        private void picBorrar_Click(object sender, EventArgs e)
        {
            formBorrar aux = new formBorrar();
            aux.Show();
            this.Hide();
        }

        private void picVer_Click(object sender, EventArgs e)
        {
            formTabla aux = new formTabla();
            aux.Show();
        }
    }
}
