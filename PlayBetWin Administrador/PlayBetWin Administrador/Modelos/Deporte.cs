using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayBetWin_Administrador.Modelo
{
    public class Deporte
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public bool activado { get; set; }

        public Deporte (int id, string nombre, bool activado)
        {
            this.id = id;
            this.nombre = nombre;
            this.activado = activado;
        }

        
    }
}
