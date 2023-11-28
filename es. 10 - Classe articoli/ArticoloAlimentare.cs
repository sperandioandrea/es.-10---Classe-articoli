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
        public ArticoloAlimentare(int anno, int AnnoScadenza, int Codice, string Descrizione, int Prezzo, bool Fedeltà) : base(Codice, Descrizione, Prezzo, Fedeltà)
        {
            Anno = AnnoScadenza;
        }
        //costruttore di coppia
        public ArticoloAlimentare(ArticoloAlimentare al, Articolo a) : base(a)
        {
            anno = al.Anno;
        }
        //funzione sconto
         public override double Sconto()
         {
            double scontoBase = base.Sconto();
            return DateTime.Now.Year == Anno ? scontoBase * 20 / 100 : scontoBase;
         }
              
    }
}

