using PlayBetWin_Administrador.Conexiones;
using PlayBetWin_Administrador.Formularios;
using PlayBetWin_Administrador.Modelo;
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

namespace PlayBetWin_Administrador
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
            rellenarTablaDeportes();
            rellenarTablaCompeticiones();
            rellenarTablaParticipantes();
            rellenarTablaEventos();
            botonesCompe();
            botonesPart();


        }


        /*********************************
         *          Paginación
         * ******************************/

        
        private int pagCompe = 20;
        public void botonesCompe()
        {
            // Competición
            if (pagCompe == 20)
            {
                btMenosCompe.Enabled = false;
            } else
            {
                btMenosCompe.Enabled = true;
            }
        }

        private int pagPar = 20;

        public void botonesPart()
        {
            // participante
            if (pagPar == 20)
            {
                btmenosPart.Enabled = false;
            }
            else
            {
                btmenosPart.Enabled = true;
            }
        }
        /*********************************
         *          DEPORTES
         ********************************/
        public void rellenarTablaDeportes()
        {
            BaseDatos b = new BaseDatos();
            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                List<List<String>> deportes = b.cogerLista("SELECT id, nombre, activado FROM deportes");

                DataTable dt = new DataTable();
                dt.Columns.Add("ID").ReadOnly = true;
                dt.Columns.Add("Nombre").ReadOnly = true;
                dt.Columns.Add("Activado").ReadOnly = true;

                

                tablaDeportes.DataSource = dt;
                for (int i = 0; i < deportes.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = deportes[i][0];
                    row["Nombre"] = deportes[i][1];
                    row["Activado"] = deportes[i][2];
                    dt.Rows.Add(row);
                }
            }

            b.Desconectar();
            
        }

        //Cuando se da dos click en una misma celda, se habre una ventana donde se podra ver la información
        //del deporte, editar o borrar.
        private void tablaDeportes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Int32.Parse(tablaDeportes.CurrentRow.Cells[0].Value.ToString());
            string nombre = tablaDeportes.CurrentRow.Cells[1].Value.ToString();
            bool activado = Boolean.Parse(tablaDeportes.CurrentRow.Cells[2].Value.ToString());

            Deporte depor = new Deporte(id, nombre, activado);

            new frmAbrirDeporte(this, depor).Show();
        }

        //Abre una ventana donde se podra añadir un deporte
        private void btAnadirDeporte_Click(object sender, EventArgs e)
        {

            frmAnadirDeporte frm = new frmAnadirDeporte(this);
            frm.ShowDialog(this);
        }

        private void btAbrirDeporte_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tablaDeportes.CurrentRow.Cells[0].Value.ToString());
            string nombre = tablaDeportes.CurrentRow.Cells[1].Value.ToString();
            bool activado = Boolean.Parse(tablaDeportes.CurrentRow.Cells[2].Value.ToString());

            Deporte depor = new Deporte(id, nombre,activado);

            frmAbrirDeporte frm = new frmAbrirDeporte(this, depor);
            frm.ShowDialog(this);


        }


        /*********************************
         *          Competiciones
         ********************************/
        public void rellenarTablaCompeticiones()
        {
            BaseDatos b = new BaseDatos();
            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                
                DataTable dt = new DataTable();
                List<String> check = new List<string>();
                String where = " ";

                if (checkVerDesactivados.Checked)
                {
                    where = " where true ";
                } else
                {
                    where = " where activado=true ";
                }

                if (!checkTodos.Checked)
                {
                    
                    
                    if (checkFut.Checked)
                        check.Add(" deporte='Fútbol' ");
                    if (checkBal.Checked)
                        check.Add(" deporte='Baloncesto' ");
                    if (checkTen.Checked)
                        check.Add(" deporte='Tenis' ");
                    if (checkSpo.Checked)
                        check.Add(" deporte='E-sport' ");
                    if (checkMas.Checked)
                        check.Add(" deporte='Mas deportes' ");

                    where += " and (";
                    for (int i = 0; i < check.Count; i++)
                    {
                        where += check[i];

                        if (i< check.Count - 1)
                        {
                            where += " or ";
                        }
                    }
                    where += " ) ";

                   
                }

                if (textNombre.Text != "")
                    where += " and nombre LIKE '%" + textNombre.Text + "%' ";

                if (textID.Text != "")
                    where += " and id=" + textID.Text + " ";


                List<List<String>> deportes = b.cogerLista("SELECT id, nombre, deporte, activado FROM v_competiciones" + where + " LIMIT " + (pagCompe-20) + " , " + pagCompe );



                dt.Columns.Add("ID").ReadOnly = true;
                dt.Columns.Add("Nombre").ReadOnly = true;
                dt.Columns.Add("Deporte").ReadOnly = true;
                dt.Columns.Add("Activado").ReadOnly = true;



                tablaCompeticion.DataSource = dt;
                for (int i = 0; i < deportes.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = deportes[i][0];
                    row["Nombre"] = deportes[i][1];
                    row["Activado"] = deportes[i][2];
                    row["Deporte"] = deportes[i][3];
                    dt.Rows.Add(row);
                }
            }

            b.Desconectar();

        }

        private void btAnadirCompeticion_Click(object sender, EventArgs e)
        {
            new frmAnadirCompeticion(this).ShowDialog();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrircompe()
        {
            int id = Int32.Parse(tablaCompeticion.CurrentRow.Cells[0].Value.ToString());
            int id_deporte = 0;
            String nombre = "";
            bool check = true; ;
            BaseDatos b = new BaseDatos();
            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                List<List<String>> deportes = b.cogerLista("SELECT id, nombre,  id_deporte, activado FROM competiciones where id=" + id + ";");


                for (int i = 0; i < deportes.Count; i++)
                {
                    nombre = deportes[i][1];
                    id_deporte = Int16.Parse(deportes[i][2]);
                    check = Boolean.Parse(deportes[i][3]);
                }

                Competicion cp = new Competicion(id, nombre, id_deporte, check);

                frmAbrirCompeticion frm = new frmAbrirCompeticion(this, cp);
                frm.ShowDialog(this);
            }

            b.Desconectar();
        }

        private void btAbrirCompeticion_Click(object sender, EventArgs e)
        {

            abrircompe();

        }

        private void tablaCompeticion_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            abrircompe();
        }

        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked == true)
            {
                checkFut.Checked = false;
                checkBal.Checked = false;
                checkTen.Checked = false;
                checkSpo.Checked = false;
                checkMas.Checked = false;
            }

        }


        private void marcadoCompeticion(object sender, EventArgs e)
        {
            if (checkFut.Checked)
                checkTodos.Checked = false;
            if (checkBal.Checked)
                checkTodos.Checked = false;
            if (checkTen.Checked)
                checkTodos.Checked = false;
            if (checkSpo.Checked)
                checkTodos.Checked = false;
            if (checkMas.Checked)
                checkTodos.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rellenarTablaCompeticiones();
        }

        private void btMenosCompe_Click(object sender, EventArgs e)
        {
            pagCompe -= 20;
            botonesCompe();
            rellenarTablaCompeticiones();
        }

        private void btMasCompe_Click(object sender, EventArgs e)
        {
            pagCompe += 20;
            botonesCompe();
            rellenarTablaCompeticiones();
        }

        /*********************************
         *          Participantes
         ********************************/
        public void rellenarTablaParticipantes()
        {
            BaseDatos b = new BaseDatos();
            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {

                DataTable dt = new DataTable();
                List<String> check = new List<string>();
                String where = " ";

                if (desactPart.Checked)
                {
                    where = " where true ";
                }
                else
                {
                    where = " where activado=true ";
                }

                if (!todosPart.Checked)
                {


                    if (btFuPar.Checked)
                        check.Add(" deporte='Fútbol' ");
                    if (btBaPar.Checked)
                        check.Add(" deporte='Baloncesto' ");
                    if (btTePar.Checked)
                        check.Add(" deporte='Tenis' ");
                    if (btESPar.Checked)
                        check.Add(" deporte='E-sport' ");
                    if (btMasPar.Checked)
                        check.Add(" deporte='Mas deportes' ");

                    where += " and (";
                    for (int i = 0; i < check.Count; i++)
                    {
                        where += check[i];

                        if (i < check.Count - 1)
                        {
                            where += " or ";
                        }
                    }
                    where += " ) ";


                }

                if (textNompar.Text != "")
                    where += " and participante LIKE '%" + textNompar.Text + "%' ";

                if (textIDPar.Text != "")
                    where += " and id=" + textIDPar.Text + " ";


                List<List<String>> deportes = b.cogerLista("SELECT id, participante , deporte, activado FROM v_participantes " + where + " LIMIT " + (pagPar - 20) + " , " + pagPar);



                dt.Columns.Add("ID").ReadOnly = true;
                dt.Columns.Add("Nombre").ReadOnly = true;
                dt.Columns.Add("Deporte").ReadOnly = true;
                dt.Columns.Add("Activado").ReadOnly = true;


                tablaParticipante.DataSource = dt;
                for (int i = 0; i < deportes.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = deportes[i][0];
                    row["Nombre"] = deportes[i][1];
                    row["Activado"] = deportes[i][3];
                    row["Deporte"] = deportes[i][2];
                    dt.Rows.Add(row);
                }
            }

            b.Desconectar();

        }

        private void btAnadirParticipante_Click(object sender, EventArgs e)
        {
            new frmAnadirParticipante(this).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirParticipante();
        }

        private void tablaParticipante_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            abrirParticipante();
        }
        private void abrirParticipante()
        {
            
            int id = Int32.Parse(tablaParticipante.CurrentRow.Cells[0].Value.ToString());
            int id_deporte = 0;
            String nombre = "";
            bool check = true; ;
            BaseDatos b = new BaseDatos();
            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                List<List<String>> deportes = b.cogerLista("SELECT id, nombre,  id_deporte, activado FROM participantes where id=" + id + ";");


                for (int i = 0; i < deportes.Count; i++)
                {
                    nombre = deportes[i][1];
                    id_deporte = Int16.Parse(deportes[i][2]);
                    check = Boolean.Parse(deportes[i][3]);
                }

                Participante cp = new Participante(id, nombre, id_deporte, check);

                frmAbrirParticipante frm = new frmAbrirParticipante(this, cp);
                frm.ShowDialog(this);
            }

            b.Desconectar();
        }

        private void todosPart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked)
            {
                btFuPar.Checked = false;
                btTePar.Checked = false;
                btBaPar.Checked = false;
                btESPar.Checked = false;
                btMasPar.Checked = false;
            }
        }

        private void marcarParticipante(object sender, EventArgs e)
        {
            if (btFuPar.Checked)
                todosPart.Checked = false;

            if (btTePar.Checked)
                todosPart.Checked = false;

            if (btBaPar.Checked)
                todosPart.Checked = false;

            if (btESPar.Checked)
                todosPart.Checked = false;

            if (btMasPar.Checked)
                todosPart.Checked = false;

        }

        private void btEliminarFiltroComp_Click(object sender, EventArgs e)
        {
            checkFut.Checked = false;
            checkBal.Checked = false;
            checkTen.Checked = false;
            checkMas.Checked = false;
            checkSpo.Checked = false;
            checkTodos.Checked = true;
            textNombre.Text = "";
            textID.Text = "";
            checkVerDesactivados.Checked = false;
        }

        private void btBuscarParti_Click(object sender, EventArgs e)
        {
            rellenarTablaParticipantes();

        }

        private void btBorrarParti_Click(object sender, EventArgs e)
        {
            checkTodos.Checked = true;
            btFuPar.Checked = false;
            btTePar.Checked = false;
            btBaPar.Checked = false;
            btESPar.Checked = false;
            btMasPar.Checked = false;
            textNompar.Text = "";
            textIDPar.Text = "";
            desactPart.Checked = false;
        }

        private void btmenosPart_Click(object sender, EventArgs e)
        {
            pagPar-= 20;
            botonesPart();
            rellenarTablaParticipantes();
        }

        private void btMasPart_Click(object sender, EventArgs e)
        {
            pagPar += 20;
            botonesPart();
            rellenarTablaParticipantes();
        }

        private void tabEventos_Click(object sender, EventArgs e)
        {

        }

        /*********************************
        *             Eventos
        ********************************/
        public void rellenarTablaEventos()
        {
            BaseDatos b = new BaseDatos();
            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {

                DataTable dt = new DataTable();
                List<String> check = new List<string>();
                String where = " ";

                if (desactPart.Checked)
                {
                    where = " where true ";
                }
                else
                {
                    where = " where activado=true ";
                }

                if (!todosPart.Checked)
                {


                    if (btFuPar.Checked)
                        check.Add(" deporte='Fútbol' ");
                    if (btBaPar.Checked)
                        check.Add(" deporte='Baloncesto' ");
                    if (btTePar.Checked)
                        check.Add(" deporte='Tenis' ");
                    if (btESPar.Checked)
                        check.Add(" deporte='E-sport' ");
                    if (btMasPar.Checked)
                        check.Add(" deporte='Mas deportes' ");

                    where += " and (";
                    for (int i = 0; i < check.Count; i++)
                    {
                        where += check[i];

                        if (i < check.Count - 1)
                        {
                            where += " or ";
                        }
                    }
                    where += " ) ";


                }

                //if (textNompar.Text != "")
                //    where += " and participante LIKE '%" + textNompar.Text + "%' ";

                //if (textIDPar.Text != "")
                //    where += " and id=" + textIDPar.Text + " ";


                List<List<String>> deportes = b.cogerLista("SELECT id, participante_casa, participante_visitante, ifNull(resultado_casa,'') as resultado_casa , ifNull(resultado_visitante, '') as resultado_visitante , fecha_hora, apuesta_1, apuesta_2, ifNull(apuesta_x, '') as apuesta_x , deporte ,pagado , competicion  FROM v_eventos_participantes ");// + where + " LIMIT " + (pagPar - 20) + " , " + pagPar);



                dt.Columns.Add("ID").ReadOnly = true;
                dt.Columns.Add("Participante en casa").ReadOnly = true;
                dt.Columns.Add("Participante en visitante").ReadOnly = true; 
                dt.Columns.Add("competicion").ReadOnly = true;
                dt.Columns.Add("Resultado de casa").ReadOnly = true;
                dt.Columns.Add("Resultado de visitante").ReadOnly = true;
                dt.Columns.Add("fecha y hora").ReadOnly = true;
                dt.Columns.Add("1").ReadOnly = true;
                dt.Columns.Add("X").ReadOnly = true;
                dt.Columns.Add("2").ReadOnly = true;
                dt.Columns.Add("Deporte").ReadOnly = true;
                dt.Columns.Add("Pagado").ReadOnly = true;

               
                tablaEventos.DataSource = dt;
                for (int i = 0; i < deportes.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = deportes[i][0];
                    row["Participante en casa"] = deportes[i][1];
                    row["Participante en visitante"] = deportes[i][2];
                    row["competicion"] = deportes[i][11];
                    row["Resultado de casa"] = deportes[i][3];
                    row["Resultado de visitante"] = deportes[i][4];
                    row["fecha y hora"] = deportes[i][5];
                    row["1"] = deportes[i][6];
                    row["2"] = deportes[i][7];
                    row["X"] = deportes[i][8];
                    row["Deporte"] = deportes[i][9];
                    row["Pagado"] = deportes[i][10];
                    dt.Rows.Add(row);
                }
            }

            b.Desconectar();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            abrirEvento();
        }

        private void abrirEvento()
        {
            int id = Int32.Parse(tablaEventos.CurrentRow.Cells[0].Value.ToString());
            int id_casa;
            int id_visitante;
            string marcador_casa;
            string marcador_visitante;
            int id_competicion;
            string apuesta1;
            string apuestaX;
            string apuesta2;
            DateTime fecha;
            bool activado;
            bool pagado;
            BaseDatos b = new BaseDatos();
            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                List<List<String>> deportes =  b.cogerLista("SELECT id, id_participante_casa, id_participante_visitante, id_competicion, ifNULL(resultado_casa, '') , ifNULL(resultado_visitante, ''), apuesta_1, ifNULL(apuesta_X, ''), apuesta_2, fecha_hora, activado, pagado FROM playbetwin.eventos where id="+ id +";");

                Evento cp = null;
                for (int i = 0; i < deportes.Count; i++)
                {

                    id_casa = Int16.Parse(deportes[i][1]);
                    id_visitante = Int16.Parse(deportes[i][2]); 
                    marcador_casa = deportes[i][4];
                    marcador_visitante = deportes[i][5];
                    id_competicion = Int16.Parse(deportes[i][3]);
                    apuesta1 = deportes[i][6];
                    apuestaX = deportes[i][7];
                    apuesta2 = deportes[i][8];
                    fecha = Convert.ToDateTime((deportes[i][9]));
                    activado = bool.Parse(deportes[i][10]);
                    pagado = bool.Parse(deportes[i][10]);
                    cp = new Evento(id, id_casa, id_visitante, marcador_casa, marcador_visitante, id_competicion, apuesta1, apuestaX, apuesta2, fecha, activado, pagado);
                }

                if(cp != null)
                {
                    frmAbrirEvento frm = new frmAbrirEvento(this, cp);
                    frm.ShowDialog(this);
                } else
                {
                    rellenarTablaEventos();
                }

            }

            b.Desconectar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            new frmAnadirEvento(this).ShowDialog();
        }

        private void tablaEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            abrirEvento();
        }

        private void btDarApostado_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tablaEventos.CurrentRow.Cells[0].Value.ToString());
            int id_casa;
            int id_visitante;
            string marcador_casa;
            string marcador_visitante;
            int id_competicion;
            string apuesta1;
            string apuestaX;
            string apuesta2;
            DateTime fecha;
            bool activado;
            bool pagado;
            BaseDatos b = new BaseDatos();
            int r = b.Conectar();

            if (r == -1)
            {
                MessageBox.Show("No se ha podido establecer conexión con la BD");
            }
            else
            {
                List<List<String>> deportes = b.cogerLista("SELECT id, id_participante_casa, id_participante_visitante, id_competicion, ifNULL(resultado_casa, '') , ifNULL(resultado_visitante, ''), apuesta_1, ifNULL(apuesta_X, ''), apuesta_2, fecha_hora, activado, pagado FROM playbetwin.eventos where id=" + id + ";");

                Evento cp = null;
                for (int i = 0; i < deportes.Count; i++)
                {

                    id_casa = Int16.Parse(deportes[i][1]);
                    id_visitante = Int16.Parse(deportes[i][2]);
                    marcador_casa = deportes[i][4];
                    marcador_visitante = deportes[i][5];
                    id_competicion = Int16.Parse(deportes[i][3]);
                    apuesta1 = deportes[i][6];
                    apuestaX = deportes[i][7];
                    apuesta2 = deportes[i][8];
                    fecha = Convert.ToDateTime((deportes[i][9]));
                    activado = bool.Parse(deportes[i][10]);
                    pagado = bool.Parse(deportes[i][10]);
                    cp = new Evento(id, id_casa, id_visitante, marcador_casa, marcador_visitante, id_competicion, apuesta1, apuestaX, apuesta2, fecha, activado, pagado);
                }

                if (cp != null)
                {
                    frmRealizarPagos frm = new frmRealizarPagos(this, cp);
                    frm.ShowDialog(this);
                }
                else
                {
                    rellenarTablaEventos();
                }

            }

            b.Desconectar();
        }
    }


    


}

