using PlayBetWin_Administrador.Conexiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayBetWin_Administrador.Formularios
{
    public partial class frmAnadirDeporte : Form
    {
        public frmPrincipal padre;
        public frmAnadirDeporte(frmPrincipal padre)
        {
            this.padre = padre;
            InitializeComponent();
            CenterToScreen();
        }

        //Cierra la ventana
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Guarda el deporte y cierra la ventana
        private void btGuradar_Click(object sender, EventArgs e)
        {
            BaseDatos b = new BaseDatos();
              
            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                if (b.existe("Select * from deportes where nombre = '" + textNombre.Text +"'"))
                {
                    Regex exp = new Regex(@"^[a-zA-ZñÑ\s-]{2,50}$");
                    if (exp.IsMatch(textNombre.Text))
                    {
                        b.modificarTablas("INSERT deportes (nombre, Activado) VALUES ('" + textNombre.Text + "', " + checkActivado.Checked + " )");
                    }
                    else
                    {
                        MessageBox.Show("no Vale");
                    }
                    b.Desconectar();
                    padre.rellenarTablaDeportes();
                }
                else
                {
                    MessageBox.Show("Ya existe");
                }
            }

        }

        private void frmAnadirDeporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
