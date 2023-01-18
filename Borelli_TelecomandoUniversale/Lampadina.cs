using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoUniversale {
    public class Lampadina : DispositivoBase {
        private float _potenza;
        private int _intensita, _colore;//intensità in lumen, colore in kelvin

        //properties perchè nel 2023 vanno messe.
        public float Potenza {
            get {
                return _potenza;
            }
            set {
                if (value > 0 && value < 100) {
                    _potenza = value;
                } else {
                    throw new Exception("La potenza deve essere maggiore di 0 e minore di 100");
                }
            }
        }
        public int Intensita {
            get {
                return _intensita;
            }
            set {
                SettaSeMaggioreDiZero(ref _intensita, value, "Intensita'");
            }
        }
        public int Colore {
            get {
                return _colore;
            }
            set {
                SettaSeMaggioreDiZero(ref _colore, value, "Colore");
            }
        }

        //funzioni generali (non ho voglia di fare la Clone)
        public override string ToString() {
            return $"{Stato};{Potenza};{Intensita};{Colore}";
        }
        public bool Equals(Lampadina l) {
            if (l == null) {
                return false;
            } else if (l == this) {
                return true;
            } else {
                return (l.Potenza == Potenza && l.Intensita == Intensita && l.Colore == Colore);
            }
        }

        //funzioni private 
        protected void SettaSeMaggioreDiZero(ref int campo, int val, string nomeCampo) {
            if (val > 0 && val < 100) {
                campo = val;
            } else {
                throw new Exception($"Il campo \"{nomeCampo}\" deve essere maggiore di 0 e minore di 100");
            }
        }

    }
}
