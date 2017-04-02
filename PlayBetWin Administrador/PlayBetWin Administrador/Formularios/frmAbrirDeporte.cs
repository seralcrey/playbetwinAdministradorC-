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
    public partial class frmAbrirDeporte : Form
    {
        Deporte deporte;
        public frmAbrirDeporte(Deporte deporte)
        {
            this.deporte = deporte;
            InitializeComponent();
        }


    }
}
