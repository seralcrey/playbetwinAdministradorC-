﻿using PlayBetWin_Administrador.Conexiones;
using PlayBetWin_Administrador.Formularios;
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
        BaseDatos b = new BaseDatos();
        public frmPrincipal()
        {
            InitializeComponent();
            rellenarTablaDeportes();
        }


        /*********************************
         *          DEPORTES
         ********************************/
        public void rellenarTablaDeportes()
        {
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
            
            MessageBox.Show(tablaDeportes.CurrentRow.Cells[0].Value.ToString());
        }

        //Abre una ventana donde se podra añadir un deporte
        private void btAnadirDeporte_Click(object sender, EventArgs e)
        {
            new frmAnadirDeporte(this).Show();
        }

        private void btAbrirDeporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tablaDeportes.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
