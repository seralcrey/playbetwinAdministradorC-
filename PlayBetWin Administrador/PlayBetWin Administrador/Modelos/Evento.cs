using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayBetWin_Administrador.Modelos
{
    public class Evento
    {
        public int id;
        public int id_casa;
        public int id_visitante;
        public string marcador_casa;
        public string marcador_visitante;
        public int id_competicion;
        public string apuesta1;
        public string apuestaX;
        public string apuesta2;
        public DateTime fecha;
        public bool activado;
        public bool pagado;


        public Evento( int id,
                 int id_casa,
                 int id_visitante,
                 string marcador_casa,
                 string marcador_visitante,
                 int id_competicion,
                 string apuesta1,
                 string apuestaX,
                 string apuesta2,
                 DateTime fecha,
                 bool activado,
                 bool pagado){
            this.id = id;
            this.id_casa = id_casa;
            this.id_visitante = id_visitante;
            this.marcador_casa = marcador_casa;
            this.marcador_visitante = marcador_visitante;
            this.id_competicion = id_competicion;
            this.apuesta1 = apuesta1;
            this.apuestaX = apuestaX;
            this.apuesta2 = apuesta2;
            this.fecha = fecha;
            this.activado = activado;
            this.pagado = pagado;
        }

    }
}
