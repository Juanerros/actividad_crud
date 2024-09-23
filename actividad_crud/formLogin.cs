﻿using capa_datos;
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
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crud logear = new crud();
            string tipoUsuario =logear.login(tboxUsuario.Text, tboxClave.Text);
            if(tipoUsuario == "cliente")
            {
                formTabla aux = new formTabla();
                aux.Show();
                this.Close();
            }
        }
    }
}
