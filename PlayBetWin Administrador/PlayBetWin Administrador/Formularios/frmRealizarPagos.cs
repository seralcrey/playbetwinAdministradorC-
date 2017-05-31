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
    public partial class frmRealizarPagos : Form
    {
        public frmPrincipal padre;
        public Evento evento;

        public frmRealizarPagos(frmPrincipal padre, Evento evento)
        {
            InitializeComponent();
            this.evento = evento;
            this.padre = padre;
            CenterToScreen();
            resC.Text = evento.marcador_casa;
            resV.Text = evento.marcador_visitante;
            partiCa.Text = cargarEquipo(evento.id_casa);
            partiVi.Text = cargarEquipo(evento.id_visitante);
            totalApostado.Text = "Total aposta: " + totalApuestas(evento.id);
        }

        private String totalApuestas(int id)
        {
            BaseDatos b = new BaseDatos();
            int r = b.Conectar();
            String total = "";
            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                List<List<String>> deportes = b.cogerLista("SELECT count(*) FROM playbetwin.apuestas where id_evento=" + id);


                for (int i = 0; i < deportes.Count; i++)
                {
                    total = deportes[i][0];

                }

            }

            b.Desconectar();
            return total;
        }


        private String cargarEquipo(int id)
        {
            BaseDatos b = new BaseDatos();
            int r = b.Conectar();
            String nombre = "";
            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                List<List<String>> deportes = b.cogerLista("SELECT nombre from participantes where id="+id);

                
                for (int i = 0; i < deportes.Count; i++)
                {
                    nombre = deportes[i][0];
                    
                }

            }

            b.Desconectar();
            return nombre;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void resV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btRepartir_Click(object sender, EventArgs e)
        {
            BaseDatos b = new BaseDatos();

            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {

                if (resC.Text.ToString().Length>0 && resV.Text.ToString().Length>0)
                {

                    int resulC = int.Parse(resC.Text);
                    int resulV = int.Parse(resV.Text);
                    String pronosFinal = "";
                    if (resulC > resulV)
                    {
                        pronosFinal = "1";
                    }
                    else if (resulC < resulV)
                    {
                        pronosFinal = "2";
                    }
                    if (resulC == resulV)
                    {
                        pronosFinal = "X";
                    }

                    b.modificarTablas("UPDATE eventos SET resultado_casa=" + ((resC.Text.ToString().Length > 0) ? resC.Text : "NULL") + ",resultado_visitante=" + ((resV.Text.ToString().Length > 0) ? resV.Text : "NULL") + " , pagado=true WHERE id=" + evento.id + ";");

                    List<List<String>> apuestas = b.cogerLista("SELECT id_usuario,coins,pronostico FROM playbetwin.apuestas where id_evento=" + evento.id + ";");

                    for (int i = 0; i < apuestas.Count; i++)
                    {
                        String id_usu = apuestas[i][0];
                        String coins = apuestas[i][1];
                        String pronos = apuestas[i][2];

                        if (pronos.Equals(pronosFinal))
                        {
                            b.modificarTablas("UPDATE usuarios set coins = coins+"+ coins +" WHERE id=" + id_usu + ";");
                        }
                        
                    }

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
    }
}
