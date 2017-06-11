using PlayBetWin_Administrador.Conexiones;
using PlayBetWin_Administrador.Modelos;
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
    public partial class frmAbrirProducto : Form
    {

        frmPrincipal padre;
        Producto p;


        public frmAbrirProducto(frmPrincipal padre, Producto p)
        {
            this.padre = padre;
            this.p = p;
            InitializeComponent();
            CenterToScreen();
            abrirImagen.Filter = "PNG Files (*.jpg)|*.jpg";

            textNombre.Text = p.nombre;
            textPrecio.Text = p.precio+"";
            textCoins.Text = p.coins + "";
            textStock.Text = p.stock + "";
            checkActivado.Checked = p.activado;
            if (p.imagen)
            {
                nombreImagen.Text = "Tiene imagen";
            } else
            {
                nombreImagen.Text = "No tiene imagen";
            }

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (nombreImagen.Text != "No tiene imagen")
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
                        if (p.nombre == textNombre.Text || b.existe("Select * from productos where nombre = '" + textNombre.Text + "'"))
                        {

                            b.modificarTablas("update productos set nombre='"+ textNombre.Text.Trim() + "' , precio="+ textPrecio.Text.Trim() + ",coins="+ textCoins.Text.Trim() + ",stock=" + textStock.Text.Trim() + ", activado=" + checkActivado.Checked + " where id=" + p.id + "");

                            List<List<String>> premio = b.cogerLista("Select id from productos where nombre='" + textNombre.Text + "'");

                            if (abrirImagen.FileName != "openFileDialog1")
                            {
                                string destino = @"C:\xampp\htdocs\tienda\" + p.id + ".jpg";
                                System.IO.File.Replace(abrirImagen.FileName, destino, abrirImagen.FileName);
                            }

                            b.Desconectar();
                            padre.rellenarTablaProducto();
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            textCoins.Enabled = true;
            textNombre.Enabled = true;
            btSelecionarImagen.Enabled = true;
            textCoins.Enabled = true;
            textStock.Enabled = true;
            textPrecio.Enabled = true;
            btGuardar.Enabled = true;
            checkActivado.Enabled = true;

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

        

        private void textCoins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {
                e.Handled = true;
                return;
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

        private void textStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
