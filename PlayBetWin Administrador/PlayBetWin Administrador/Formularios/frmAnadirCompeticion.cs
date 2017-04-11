using PlayBetWin_Administrador.Conexiones;
using PlayBetWin_Administrador.Modelo;
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
    public partial class frmAnadirCompeticion : Form
    {
        public frmAnadirCompeticion()
        {
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
            }

            b.Desconectar();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
