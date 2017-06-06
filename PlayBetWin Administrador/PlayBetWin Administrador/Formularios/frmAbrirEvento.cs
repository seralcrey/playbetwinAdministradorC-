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
    public partial class frmAbrirEvento : Form
    {
        public frmPrincipal padre;
        public Evento evento;

        public frmAbrirEvento(frmPrincipal padre, Evento evento)
        {
            this.evento = evento;
            this.padre = padre;
            InitializeComponent();
            CenterToScreen();
            fecha.CustomFormat = "dd/MM/yyyy HH:mm ";
            fecha.ShowUpDown = true;

            rellanarComboxCompe();
            rellanarComboxDeportes();

            for (int i = 0; i < equipoCasa.Items.Count; i++)
            {
                if (((Participante)equipoCasa.Items[i]).id == evento.id_casa)
                {
                    equipoCasa.SelectedItem = equipoCasa.Items[i];
                }
                if (((Participante)equipoVisi.Items[i]).id == evento.id_visitante)
                {
                    equipoVisi.SelectedItem = equipoVisi.Items[i];
                }
            }

            for (int i = 0; i < combCompeticion.Items.Count; i++)
            {
                if (((Competicion)combCompeticion.Items[i]).id == evento.id_competicion)
                {
                    combCompeticion.SelectedItem = combCompeticion.Items[i];
                }
            }

                fecha.Text = evento.fecha.Day + "/" + evento.fecha.Month + "/" + evento.fecha.Year + " " + evento.fecha.Hour +":" + evento.fecha.Minute;
            combCompeticion.SelectedItem = evento.id_competicion;
            text1.Text = evento.apuesta1+"";
            text2.Text = evento.apuesta2 + "";
            textX.Text = evento.apuestaX + "";
            resCasa.Text = evento.marcador_casa;
            resVisi.Text = evento.marcador_visitante;
            checkActivado.Checked = evento.activado;

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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            btGuardar.Enabled = true;
            equipoCasa.Enabled = true;
            equipoVisi.Enabled = true;
            fecha.Enabled = true;
            combCompeticion.Enabled = true;
            text1.Enabled = true;
            text2.Enabled = true;
            textX.Enabled = true;
            resCasa.Enabled = true;
            resVisi.Enabled = true;
            checkActivado.Enabled = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            BaseDatos b = new BaseDatos();

            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {

                if (double.Parse(text1.Text) > 0 && double.Parse(text2.Text) > 0 && double.Parse(textX.Text) > 0)
                {
                    Participante parC = (Participante)equipoCasa.SelectedItem;
                    Participante parV = (Participante)equipoVisi.SelectedItem;
                    Competicion comp = (Competicion)combCompeticion.SelectedItem;

                    DateTime dt = Convert.ToDateTime(fecha.Value);

                    String fechaHora = dt.Year + "-" + dt.Month + "-" + dt.Day + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second;

                    b.modificarTablas("UPDATE eventos SET id_participante_casa="+parC.id+", id_participante_visitante="+ parV.id + ",id_competicion="+comp.id+
                        ",resultado_casa="+((resCasa.Text.ToString().Length>0)? resCasa.Text : "NULL" )+",resultado_visitante="+ ((resVisi.Text.ToString().Length > 0) ? resVisi.Text : "NULL") + ", apuesta_1="+ text1.Text.Replace(",", ".") + ", apuesta_X="+ (( Double.Parse(textX.Text)> 0) ? textX.Text.Replace(",",".") : "NULL") + ",apuesta_2="+ text2.Text.Replace(",", ".") + ",fecha_hora='"+fechaHora+"',activado="+ checkActivado.Checked+" WHERE id="+evento.id+";");
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar este evento?", "Eliminar", MessageBoxButtons.YesNo);

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
                    

                    b.modificarTablas("DELETE FROM eventos WHERE id=" + evento.id);
                    padre.rellenarTablaEventos();
                    this.Close();
                    
                    
                }
                b.Desconectar();
            }
        }

        private void resCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void resVisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
