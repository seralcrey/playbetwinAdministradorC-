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
            botonesCompe();


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
            new frmAnadirCompeticion(this).Show();
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
                    where += " and nombre LIKE '%" + textNompar.Text + "%' ";

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
                    row["Activado"] = deportes[i][2];
                    row["Deporte"] = deportes[i][3];
                    dt.Rows.Add(row);
                }
            }

            b.Desconectar();

        }

    }
}
