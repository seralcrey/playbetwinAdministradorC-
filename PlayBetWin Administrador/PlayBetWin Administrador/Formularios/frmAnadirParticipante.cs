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
    public partial class frmAnadirParticipante : Form
    {
        public frmPrincipal padre;

        public frmAnadirParticipante(frmPrincipal padre)
        {
            this.padre = padre;
            InitializeComponent();
            rellanarComboxDeportes();
            CenterToScreen();
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            BaseDatos b = new BaseDatos();

            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {


                if (b.existe("Select * from participantes where nombre = '" + textNombre.Text + "'"))
                {
                    Regex exp = new Regex(@"^[a-zA-Z0-9ñÑ\s-]{2,50}$");
                    if (exp.IsMatch(textNombre.Text))
                    {
                        Deporte deportSelect = (Deporte)comboDeportes.SelectedItem;
                        b.modificarTablas("INSERT participantes (nombre, Activado, id_deporte) VALUES ('" + textNombre.Text + "', true,  " + deportSelect.id + " )");
                        padre.rellenarTablaParticipantes();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("no Vale");
                    }
                    b.Desconectar();
                    
                }
                else
                {
                    MessageBox.Show("Ya existe");
                }
            }
        }
    }
}
