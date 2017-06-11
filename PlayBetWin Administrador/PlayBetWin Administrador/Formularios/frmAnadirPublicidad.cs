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
    public partial class frmAnadirPublicidad : Form
    {
        private frmPrincipal p;

        public frmAnadirPublicidad(frmPrincipal p)
        {
            this.p = p;
            InitializeComponent();
            abrirImagen.Filter = "JPG Files (*.jpg)|*.jpg";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (abrirImagen.FileName != "openFileDialog1")
            {
                if (textNombre.Text.ToString().Trim() != "" && textCoins.Text.ToString().Trim() != "" && textURL.Text.ToString().Trim() != "")
                {
                    BaseDatos b = new BaseDatos();

                    int r = b.Conectar();

                    if (r == -1)
                    {
                        MessageBox.Show("No se ha podido establecer conexión con la BD");
                    }
                    else
                    {
                        if (b.existe("Select * from publicidades where nombre = '" + textNombre.Text + "'"))
                        {

                            b.modificarTablas("INSERT publicidades (nombre, Activado, url , coins,imagen) VALUES ('" + textNombre.Text + "', " + true + " , '" + textURL.Text +  "' , " + textCoins.Text + ", true)");

                            List<List<String>> premio = b.cogerLista("Select id from publicidades where nombre='" + textNombre.Text + "'");

                            for (int i = 0; i < premio.Count; i++)
                            {
                                string destino = @"C:\xampp\htdocs\publicidad\" + premio[i][0] + ".jpg";
                                System.IO.File.Copy(abrirImagen.FileName, destino);
                            }

                            b.Desconectar();
                            p.rellenarTablaPublicidad();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
