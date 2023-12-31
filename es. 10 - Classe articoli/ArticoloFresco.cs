﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._10___Classe_articoli
{
    public class ArticoloFresco : ArticoloAlimentare
    {
        private int numerogiorni;
        
        //get e set
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
        //Costruttore di copia
        public ArticoloFresco(ArticoloFresco af,  ArticoloAlimentare al,Articolo a) : base(al, a)
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

        //metodo Equals 
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            ArticoloFresco other = (ArticoloFresco)obj;
            return base.Equals(obj) && NumeroGiorni == other.NumeroGiorni;
        }
        //metodo ToString
        public override string ToString()
        {
            return $"{base.ToString()}, Giorni di Consumo: {NumeroGiorni}";
        }

        //metodo Compare
        public static int Compare(ArticoloFresco a, ArticoloFresco b)
        {
            return Articolo.Compare(a, b);
        }
    }
}
