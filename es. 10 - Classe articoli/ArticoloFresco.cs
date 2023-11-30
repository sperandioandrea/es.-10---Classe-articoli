using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._10___Classe_articoli
{
    public class ArticoloFresco : ArticoloAlimentare
    {
        private int numerogiorni;
        

        public int NumeroGiorni
        {
            set { numerogiorni = value; }
            get { return numerogiorni; }
        }
        //Costruttore senza parametri
        public ArticoloFresco() : base()
        {
            numerogiorni = 0;
        }

        //Costruttore con parametri
        public ArticoloFresco(int numerogiorni, int anno, int Codice, string Descrizione, int Prezzo, bool Fedeltà) : base(anno, Codice, Descrizione, Prezzo, Fedeltà)
        {
            NumeroGiorni = numerogiorni;
        }

        //Costruttore di coppia
        public ArticoloFresco(ArticoloFresco af, Articolo a, ArticoloAlimentare al) : base(a, al)
        {
            NumeroGiorni = af.NumeroGiorni;
        }

        //funzione sconta
        public override double Sconto()
        {
            // Sconto aggiuntivo in base ai giorni di consumo
            double scontoBase = base.Sconto();
            double scontoGiorni = numerogiorni >= 1 ? (numerogiorni * 2) / 100 : 0;
            return scontoBase - (scontoBase * scontoGiorni);
        }

    }
}
