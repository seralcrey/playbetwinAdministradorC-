using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayBetWin_Administrador
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            string usuario = textUsuario.Text;
            string pass = textPass.Text;

            if(usuario != "" && pass != "")
            {
                
            } else {
                if (usuario == "")
                {
                    MessageBox.Show("El campo usuario no esta relleno", "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUsuario.Focus();
                } else  if ( pass == "")
                {
                    MessageBox.Show("El campo contraseña no esta relleno", "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textPass.Focus();
                }
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
