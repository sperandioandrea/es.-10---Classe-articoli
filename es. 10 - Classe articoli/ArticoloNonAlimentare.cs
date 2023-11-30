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

        public string Materiale
        {
            get { return materiale; }
            set { materiale = value; }
        }

        //costruttore senza parametri
        public ArticoloNonAlimentare() : base()
        {
            riciclabile = false;
            materiale = string.Empty;
        }
        //costruttore con parametri
        public ArticoloNonAlimentare(bool riciclabile, string materiale, int Codice, string Descrizione, int Prezzo, bool Fedeltà) : base(Codice, Descrizione, Prezzo, Fedeltà)
        {
            Riciclabile = riciclabile;
            Materiale = materiale;
        }
        //costruttore di coppia
        public ArticoloNonAlimentare(ArticoloNonAlimentare anl, Articolo a) : base(a)
        {
            Riciclabile = anl.Riciclabile;
            Materiale = anl.Materiale;
        }

        //funzione sconta
        public override double Sconto()
        {
            // Sconto aggiuntivo del 10% se il materiale è riciclabile
            double scontoBase = base.Sconto();
            return Riciclabile ? scontoBase * 0.1 : scontoBase;
        }

    }
}
