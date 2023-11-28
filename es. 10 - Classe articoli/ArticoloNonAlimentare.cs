using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._10___Classe_articoli
{
    public class ArticoloNonAlimentare : Articolo
    {
        private bool riciclabile;
        private string materiale;

        public bool Riciclabile
        {
            set { riciclabile = value; }
            get { return riciclabile; }
        }

        //costruttore senza parametri
        public ArticoNonAlimetare() : base()
        {
            riciclabile = false;
            materiale = string.Empty;
        }
        //costruttore con parametri

        //costruttore di coppia

    }
}
