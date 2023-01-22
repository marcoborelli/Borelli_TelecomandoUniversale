using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoUniversale {
    public class LampadinaDimmerabile : Lampadina {
        private int _intensAtt;

        public LampadinaDimmerabile(string id) : base(id) {

        }
        //properties
        public int IntensitaAttuale {
            get {
                return _intensAtt;
            }
            set {
                SettaSeMaggioreDiZeroMinoreDiCento(ref _intensAtt, value, "Intensita' attuale");
            }
        }
        //funzioni generali
        public override string ToString() {
            return $"{Stato};{Potenza};{Intensita};{Colore};{IntensitaAttuale}";
        }
        //funzioni specifiche
        public void Regola(int nuovaIntens) {
            this.IntensitaAttuale = nuovaIntens;
            if (this.IntensitaAttuale < 30) {
                this.Stato = false;
            } else {
                this.Stato = true;
            }
        }
    }
}
