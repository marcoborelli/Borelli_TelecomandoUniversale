using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoUniversale {
    public class Tv : DispositivoBase {
        private string _prod, _modello;
        private string[] _conn;
        private int _canale;
        private int _volume;

        public Tv(string id, string ilproduttore, string ilmodello) : base(id)//costruttore
        {
            this.Produttore = ilproduttore;
            this.Modello = ilmodello;
        }

        //properties
        public string Produttore {
            get {
                return _prod;
            }
            set {
                InserisciSeStringaValida(ref _prod, value, "Produttore");
            }
        }
        public string Modello {
            get {
                return _modello;
            }
            set {
                InserisciSeStringaValida(ref _modello, value, "Modello");
            }
        }
        public int Volume {
            get {
                return _volume;
            }
            set {
                SettaSeMaggioreDiZeroMinoreDiCento(ref _volume, value, "Volume");
            }
        }
        public int Canale {
            get {
                return _canale;
            }
            set {
                if (value > 0) {
                    _canale = value;
                } else {
                    throw new Exception($"Il campo \"Canale\" deve essere maggiore di 0");
                }
            }
        }
        public string[] Connettori {
            get {
                return _conn;
            }
            set {
                _conn = new string[value.Length];
                for (int i = 0; i < value.Length; i++) {
                    InserisciSeStringaValida(ref _conn[i], value[i], $"Connettore {i}");
                }
            }
        }

        //funzioni generali
        public override string ToString() {
            string temp = "";
            for (int i=0; i < _conn.Length;i++) {
                temp += $"{_conn[i]};";
            }

            return $"{Produttore};{Modello};{Volume};{Canale};{temp}";
        }
        public virtual bool Equals(Tv t) {
            if (t == null) {
                return false;
            } else if (t == this) {
                return true;
            } else {
                return (t.Id == this.Id);
            }
        } 

        //funzioni specifiche
        public void AumentaVolume() {
            this.Volume++;
        }
        public void DiminuisciVolume() {
            this.Volume--;
        }
    }
}
