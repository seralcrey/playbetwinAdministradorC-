using PlayBetWin_Administrador.Conexiones;
using PlayBetWin_Administrador.Modelo;
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
    public partial class frmAbrirDeporte : Form
    {
        Deporte deporte;
        frmPrincipal principal;

        public frmAbrirDeporte(frmPrincipal principal, Deporte d)
        {
            this.principal = principal;
            this.deporte = d;
            InitializeComponent();
            cargar();
            CenterToScreen();
        }

        public void cargar()
        {
            checActivado.Checked = deporte.activado;
            textNombre.Text = deporte.nombre;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            textNombre.Enabled = true;
            checActivado.Enabled = true;
            btGuardar.Enabled = true;
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar el deporte?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                BaseDatos b = new BaseDatos();

                int r = b.Conectar();

                if (r == -1)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la BD");
                }
                else
                {
                    if (!b.existe("Select * from deportes where nombre = '" + deporte.nombre + "'"))
                    {

                        b.modificarTablas("DELETE FROM deportes WHERE id=" + deporte.id);
                        principal.rellenarTablaDeportes();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ya no existe");
                    }
                }
                b.Desconectar();
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea modificar el deporte?", "Modificar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                BaseDatos b = new BaseDatos();

                int r = b.Conectar();

                if (r == -1)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la BD");
                }
                else
                {
                    if (b.existe("Select * from deportes where nombre = '" + textNombre.Text + "'") || deporte.nombre == textNombre.Text)
                    {
                        Regex exp = new Regex(@"^[a-zA-Z0-9ñÑ\s-]{2,50}$");
                        if (exp.IsMatch(textNombre.Text))
                        {
                            b.modificarTablas("UPDATE deportes SET nombre = '" + textNombre.Text + "' , activado = " + checActivado.Checked + " WHERE id = " + deporte.id);
                        }
                        else
                        {
                            MessageBox.Show("El nombre no es correcto");
                        }
                        b.Desconectar();
                        principal.rellenarTablaDeportes();
                    }
                    else
                    {
                        MessageBox.Show("El deporte ya existe");
                    }
                    b.Desconectar();
                }
            }
            
            
            
        }
    }
}
