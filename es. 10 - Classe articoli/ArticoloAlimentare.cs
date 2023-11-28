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

        public ArticoloAlimentare(int Codice, string Descrizione, int Prezzo, bool Fedeltà, int AnnoScadenza) : base(Codice, Descrizione, Prezzo, Fedeltà)
        {
            Anno = AnnoScadenza;
        }

        /*/   public override double Sconto()
           {
               double scontoBase = base.Sconto();
               if (DateTime.Now.Year == Anno)
               {
                   return scontoBase * 20 / 100;
               }
               else
               {
                   return scontoBase;
              }
           double scontoBase = base.Sconta();
           return DateTime.Now.Year == AnnoScadenza ? scontoBase * 0.2m : scontoBase;

           }/*/

        //Metodo Equals
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Articolo metodo = (Articolo)obj;
            if (Anno == metodo.Anno)
            {
                return true;
            }
            return false;
        }

        //Metodo ToString 
        public override string ToString()
        {
            return $"Anno: {Anno}";
        }
    }
}

