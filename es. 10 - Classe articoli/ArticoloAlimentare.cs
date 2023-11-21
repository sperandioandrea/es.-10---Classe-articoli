using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace es._10___Classe_articoli
{
    class ArticoloAlimentare : Articolo
    {
        private int anno;

        public int Anno
        {
            set { anno = value; }
            get { return anno; }
        }

        public ArticoloAlimentare(int Codice, string Descrizione, int Prezzo) : base(Codice, Descrizione, Prezzo)
        {

        }
    
    }
    
}
