using PlayBetWin_Administrador.Conexiones;
using PlayBetWin_Administrador.Modelos;
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
    public partial class frmAnadirEvento : Form
    {
        public frmPrincipal padre;

        public frmAnadirEvento(frmPrincipal padre)
        {
            this.padre = padre;
            InitializeComponent();
            CenterToScreen();
            rellanarComboxDeportes();
            rellanarComboxCompe();
            fecha.CustomFormat = "dd/MM/yyyy HH:mm";
            fecha.ShowUpDown = true;
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
                List<List<String>> deportes = b.cogerLista("SELECT id, nombre, id_deporte, activado FROM participantes; ");

                for (int i = 0; i < deportes.Count; i++)
                {
                    int id = int.Parse(deportes[i][0]);
                    string nombre = deportes[i][1];
                    int id_deporte = int.Parse(deportes[i][2]);
                    bool activado = bool.Parse(deportes[i][3]);
                    equipoCasa.Items.Add(new Participante(id, nombre, id_deporte, activado));
                    equipoVisi.Items.Add(new Participante(id, nombre, id_deporte, activado));
                }

                
                equipoCasa.Sorted = true;
                equipoCasa.SelectedIndex = 0;
                equipoVisi.Sorted = true;
                equipoVisi.SelectedIndex = 0;

            }

            b.Desconectar();
        }

        public void rellanarComboxCompe()
        {
            BaseDatos b = new BaseDatos();

            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                List<List<String>> deportes = b.cogerLista("SELECT id, nombre, id_deporte, activado FROM competiciones; ");

                for (int i = 0; i < deportes.Count; i++)
                {
                    int id = int.Parse(deportes[i][0]);
                    string nombre = deportes[i][1];
                    int id_deporte = int.Parse(deportes[i][2]);
                    bool activado = bool.Parse(deportes[i][3]);
                    combCompeticion.Items.Add(new Competicion(id, nombre, id_deporte, activado));
                    
                }


                combCompeticion.Sorted = true;
                combCompeticion.SelectedIndex = 0;
                

            }

            b.Desconectar();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
        }

        private void textX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
        }

        private void text2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            BaseDatos b = new BaseDatos();

            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                



                if (double.Parse(text1.Text)>0 && double.Parse(text2.Text) > 0 )
                {
                    Participante parC = (Participante)equipoCasa.SelectedItem;
                    Participante parV = (Participante)equipoVisi.SelectedItem;
                    Competicion comp = (Competicion)combCompeticion.SelectedItem;

                    DateTime dt = Convert.ToDateTime(fecha.Value);

                    String fechaHora = dt.Year + "-" +  dt.Month + "-" + dt.Day + " " + dt.Hour + ":" + dt.Minute +":" + dt.Second ;

                    b.modificarTablas("insert playbetwin.eventos (id_participante_casa,id_participante_visitante, id_competicion, apuesta_1, apuesta_2, apuesta_X, fecha_hora, activado, pagado)"+
                                                        "values("+parC.id+ " , " + parV.id + ", " + comp.id + " , " + text1.Text + ", " + text2.Text + " , " + ((double.Parse(textX.Text) > 0) ? textX.Text : "NULL")  + ", '" + fechaHora + "', 1, 0)");
                    padre.rellenarTablaEventos();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Alguna de las apuestas no es correctas");
                }
                b.Desconectar();

            }
        }

        private void combCompeticion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void equipoVisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void equipoCasa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
