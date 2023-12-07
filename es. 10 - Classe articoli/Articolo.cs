using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._10___Classe_articoli
{
    public class Articolo
    {
        //Attributi
        protected int _codice;
        protected string _descrizione;
        protected int _prezzo;
        protected bool _fedeltà;

        //costruttore senza parametri
        public Articolo()
        {
            Codice = 0;
            Descrizione = string.Empty; //comando per azzerare una stringa
            Prezzo = 0;
            Fedeltà = false;
        }
        //Costruttore
        public Articolo(int Codice, string Descrizione, int Prezzo, bool Fedeltà)
        {
            _codice = Codice;
            _descrizione = Descrizione;
            _prezzo = Prezzo;
            _fedeltà = Fedeltà;
        }
        //costruttore di coppia
        public Articolo(Articolo a)
        {
            Codice = a.Codice;
            Descrizione = a.Descrizione;
            Prezzo= a.Prezzo;
            Fedeltà = a.Fedeltà;
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

        public bool Fedeltà
        {
            get { return _fedeltà;  }
            set { _fedeltà = value;  }

        }

        //Funzione Sconto
        public virtual double Sconto()
        {
            // Sconto del 5% se ha la carta fedeltà
            if (Fedeltà)
            {
                Prezzo = Prezzo - Prezzo * (5 / 100);
            }
            return Prezzo;
        }

        //Metodo Equals
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Articolo metodo = (Articolo)obj;
            if (Codice == metodo.Codice && Descrizione == metodo.Descrizione && Prezzo == metodo.Prezzo && Fedeltà == metodo.Fedeltà)
            {
                return true;
            }
            return false;
        }

        //Metodo ToString 
        public override string ToString()
        {
            return $"codice: {Codice} descrizione: {Descrizione} prezzo: {Prezzo} fedeltà: {Fedeltà}";
        }

        //metodo Compare

    }
}
