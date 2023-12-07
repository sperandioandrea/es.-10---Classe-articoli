using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._10___Classe_articoli
{
    public class Scontrino : Articolo
    {
        //attributi
        public Articolo [] scontrino;
        private int dim = 0;

        //get e set
        public Articolo Scontr
        {
            get { scontrino = new Articolo[dim]; }
            set { scontrino[dim] = value; }
        }
           
        //costruttore senza parametri
        //costruttore con parametri
        //costruttore di copia
        //metodo ToString
    }
}
