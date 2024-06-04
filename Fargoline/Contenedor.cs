using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fargoline
{
    public class Contenedor
    {

        /* propiedades */
        public int id { get; set; }
        public string NumeroC { get; set; }
        public string TipoC { get; set; }
        public string TamanoC { get; set; }
        public decimal PesoC { get; set; }
        public decimal TaraC { get; set; }


        public Contenedor() {}

        /* se crea constructor */
        public Contenedor(int id, string NumeroC, string TipoC, string TamanoC, decimal PesoC, decimal TaraC)
        {

            /* accede a las propiedades */
            this.id = id;  
            this.NumeroC = NumeroC;
            this.TipoC = TipoC;
            this.TamanoC = TamanoC;
            this.PesoC = PesoC;
            this.TaraC = TaraC;

        }
    }
}
