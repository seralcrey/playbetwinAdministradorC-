using PlayBetWin_Administrador.Conexiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayBetWin_Administrador.Formularios
{
    public partial class frmAnadirProducto : Form
    {
        frmPrincipal p;
        public frmAnadirProducto(frmPrincipal p)
        {
            this.p = p;
            InitializeComponent();
            CenterToScreen();
            abrirImagen.Filter = "PNG Files (*.jpg)|*.jpg";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelecionarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (abrirImagen.ShowDialog() == DialogResult.OK)
                {

                    nombreImagen.Text = abrirImagen.SafeFileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (abrirImagen.FileName != "openFileDialog1")
            {
                if (textNombre.Text.ToString().Trim() != "" && textCoins.Text.ToString().Trim() != "" && textPrecio.Text.ToString().Trim() != "" && textStock.Text.ToString().Trim() != "")
                {
                    BaseDatos b = new BaseDatos();

                    int r = b.Conectar();

                    if (r == -1)
                    {
                        MessageBox.Show("No se ha podido establecer conexión con la BD");
                    }
                    else
                    {
                        if (b.existe("Select * from productos where nombre = '" + textNombre.Text + "'"))
                        {

                            b.modificarTablas("INSERT productos (nombre, Activado, coins, precio , stock ,image) VALUES ('" + textNombre.Text + "', " + true + " , " + textCoins.Text + ","+  textPrecio.Text  +"," + textStock.Text +  ",  true)");

                            List<List<String>> premio = b.cogerLista("Select id from productos where nombre='" + textNombre.Text + "'");

                            for (int i = 0; i < premio.Count; i++)
                            {
                                string destino = @"C:\xampp\htdocs\tienda\" + premio[i][0] + ".jpg";
                                System.IO.File.Copy(abrirImagen.FileName, destino);
                            }

                            b.Desconectar();
                            p.rellenarTablaProducto();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ya existe");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Faltan campos por rellenar");
                }

            }
            else
            {
                MessageBox.Show("Añade una imagen");
            }
        }

        private void textPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
        }

        private void textCoins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {
                e.Handled = true;
                return;
            }
        }
    }
}
