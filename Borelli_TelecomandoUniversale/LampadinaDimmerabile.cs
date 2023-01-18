using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoUniversale {
    public class LampadinaDimmerabile : Lampadina {
        private int _intensAtt;

        public void Regola(int nuovaIntens) {
            this.IntensitaAttuale = nuovaIntens;
            if (this.IntensitaAttuale < 30) {
                this.Stato = false;
            } else {
                this.Stato = true;
            }
        }

        public int IntensitaAttuale {
            get {
                return _intensAtt;
            }
            set {
                SettaSeMaggioreDiZero(ref _intensAtt, value, "Intensita' attuale");
            }
        }

        public override string ToString() {
            return $"{Stato};{Potenza};{Intensita};{Colore};{IntensitaAttuale}";
        }
    }
}
