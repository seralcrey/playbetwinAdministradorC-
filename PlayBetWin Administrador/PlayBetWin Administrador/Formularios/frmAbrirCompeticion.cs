using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayBetWin_Administrador.Conexiones;
using PlayBetWin_Administrador.Modelo;
using PlayBetWin_Administrador.Modelos;
using System.Text.RegularExpressions;

namespace PlayBetWin_Administrador.Formularios
{
    public partial class frmAbrirCompeticion : Form
    {
        frmPrincipal padre;
        Competicion cp;
        public frmAbrirCompeticion(frmPrincipal padre, Competicion cp)
        {
            this.cp = cp;
            this.padre = padre;
            InitializeComponent();
            rellanarComboxDeportes();
            CenterToScreen();
            textNombre.Text = cp.nombre;
            comboDeportes.SelectedIndex = cp.id_deporte-1;
            chectActivado.Checked = cp.activado;
        }

        public void rellanarComboxDeportes()
        {
            BaseDatos b = new BaseDatos();

            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                List<List<String>> deportes = b.cogerLista("SELECT id, nombre, activado FROM deportes ");

                for (int i = 0; i < deportes.Count; i++)
                {
                    int id = int.Parse(deportes[i][0]);
                    string nombre = deportes[i][1];
                    bool activado = bool.Parse(deportes[i][2]);
                    comboDeportes.Items.Add(new Deporte(id, nombre, activado));
                }

                comboDeportes.SelectedIndex = 0;

            }

            b.Desconectar();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea modificar esta competicion?", "Modificar", MessageBoxButtons.YesNo);

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
                    if (b.existe("Select * from competiciones where nombre = '" + textNombre.Text + "'") || cp.nombre == textNombre.Text)
                    {
                        Regex exp = new Regex(@"^[a-zA-Z0-9ñÑ\s-]{2,50}$");
                        if (exp.IsMatch(textNombre.Text))
                        {
                            Deporte d = (Deporte)comboDeportes.SelectedItem;
                            b.modificarTablas("UPDATE competiciones SET nombre = '" + textNombre.Text + "' , id_deporte = "+ d.id +" , activado = " + chectActivado.Checked + " WHERE id = " + cp.id);
                        }
                        else
                        {
                            MessageBox.Show("El nombre no es correcto");
                        }
                        b.Desconectar();
                        padre.rellenarTablaCompeticiones();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El deporte ya existe");
                    }
                }
            }


        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar la competicion?", "Eliminar", MessageBoxButtons.YesNo);

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
                    if (!b.existe("Select * from competiciones where nombre = '" + cp.nombre + "'"))
                    {

                        b.modificarTablas("DELETE FROM competiciones WHERE id=" + cp.id);
                        
                        padre.rellenarTablaCompeticiones();
                        MessageBox.Show("Borrado");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                b.Desconectar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textNombre.Enabled = true;
            comboDeportes.Enabled = true;
            chectActivado.Enabled = true;
            btGuardar.Enabled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
