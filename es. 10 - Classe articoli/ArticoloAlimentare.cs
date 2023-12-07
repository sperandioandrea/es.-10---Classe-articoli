using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace es._10___Classe_articoli
{
    public class ArticoloAlimentare : Articolo
    {
        private int anno;
        private ArticoloAlimentare al;

        public int Anno
        {
            set { anno = value; }
            get { return anno; }
        }
        //costruttore senza parametri
        public ArticoloAlimentare() : base()
        {
            anno = 0;
        }
        //costruttore normale
        public ArticoloAlimentare(int anno, int Codice, string Descrizione, int Prezzo, bool Fedeltà) : base(Codice, Descrizione, Prezzo, Fedeltà)
        {
            Anno = anno;
        }
        //costruttore di coppia
        public ArticoloAlimentare(ArticoloAlimentare al, Articolo a) : base(a)
        {
            Anno = al.Anno;
        }


        //funzione sconto
        public override double Sconto()
        {
            double scontoBase = base.Sconto();
            return DateTime.Now.Year == Anno ? scontoBase * 20 / 100 : scontoBase;
        }

        //metodo Equals 
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            ArticoloAlimentare other = (ArticoloAlimentare)obj;
            return base.Equals(obj) && Anno == other.Anno;
        }
        //metodo ToString
        public override string ToString()
        {
            return $"{base.ToString()}, Scadenza: {Anno}";
        }

    }
}

