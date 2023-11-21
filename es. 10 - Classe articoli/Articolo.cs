using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._10___Classe_articoli
{
    class Articolo
    {
        //Attributi
        protected int _codice;
        protected string _descrizione;
        protected int _prezzo;
        protected bool _fedeltà;

        //Costruttore
        public Articolo(int Codice, string Descrizione, int Prezzo)
        {
            _codice = Codice;
            _descrizione = Descrizione;
            _prezzo = Prezzo;
        }

        //metodi GET & SET
        public int Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        public int Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        //Metodo Equals
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Articolo metodo = (Articolo)obj;
            if (_codice == metodo._codice && _descrizione == metodo._descrizione && _prezzo == metodo._prezzo && _fedeltà == metodo._fedeltà)
            {
                return true;
            }
            return false;
        }

        //Metodo ToString 
        public override string ToString()
        {
            return $"codice: {_codice} descrizione: {_descrizione} prezzo: {_prezzo} fedeltà: {_fedeltà}";
        }


    }
}
