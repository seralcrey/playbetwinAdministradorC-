using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayBetWin_Administrador.Modelos
{
    public class Premio
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public int coins { get; set; }
        public bool activado { get; set; }
        public bool imagen { get; set; }


        public Premio(int id, string nombre, int coins, bool activado, bool imagen)
        {
            this.coins = coins;
            this.id = id;
            this.nombre = nombre;
            this.activado = activado;
            this.imagen = imagen;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
