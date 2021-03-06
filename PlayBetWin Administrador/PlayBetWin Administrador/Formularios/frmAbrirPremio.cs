﻿using PlayBetWin_Administrador.Conexiones;
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
    public partial class frmAbrirPremio : Form
    {
        frmPrincipal padre;
        Premio p;

        public frmAbrirPremio(frmPrincipal padre, Premio p )
        {
            this.padre = padre;
            this.p = p;
            InitializeComponent();
            CenterToScreen();
            abrirImagen.Filter = "PNG Files (*.png)|*.png";

            textNombre.Text = p.nombre;
            textCoins.Text = p.coins+"";
            checkActivado.Checked = p.activado;
            if (p.imagen)
            {
                nombreImagen.Text = "Tiene ya una imagen";
            } else
            {
                nombreImagen.Text = "No tiene imagen";
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
            btGuardar.Enabled = true;
            checkActivado.Enabled = true;
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar el premio, se perderan todo los datos relacionado con estre premio?", "Eliminar", MessageBoxButtons.YesNo);

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
                    if (!b.existe("Select * from premios where id = " + p.id + ""))
                    {

                        b.modificarTablas("DELETE FROM premios WHERE id=" + p.id);
                        padre.rellenarTablaPremios();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("no existe");
                    }
                }
                b.Desconectar();
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (p.imagen  ||  abrirImagen.FileName != "openFileDialog1" )
            {
                if (textNombre.Text.ToString().Trim() != "" && textCoins.Text.ToString().Trim() != "")
                {
                    BaseDatos b = new BaseDatos();

                    int r = b.Conectar();

                    if (r == -1)
                    {
                        MessageBox.Show("No se ha podido establecer conexión con la BD");
                    }
                    else
                    {
                        if (p.nombre == textNombre.Text || b.existe("Select * from premios where nombre = '" + textNombre.Text + "'"))
                        {

                            b.modificarTablas("UPDATE premios SET coins = " + textCoins.Text + ", nombre = '" + textNombre.Text + "' , activado = " + checkActivado.Checked + " WHERE id = " + p.id);


                            if (abrirImagen.FileName != "openFileDialog1")
                            { 
                                string destino = @"C:\xampp\htdocs\premios\" + p.id + ".png";
                                System.IO.File.Replace(abrirImagen.FileName, destino, abrirImagen.FileName+"2");
                            }

                            b.Desconectar();
                            padre.rellenarTablaPremios();
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

        private void textCoins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
