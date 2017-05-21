using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayBetWin_Administrador.Modelos
{
    public class Competicion
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int id_deporte { get; set; }
        public bool activado { get; set; }

        public Competicion (int id, string nombre, int id_deporte, bool activado)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_deporte = id_deporte;
            this.activado = activado;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
