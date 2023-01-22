using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoUniversale {
    public abstract class DispositivoBase {
        private bool _stato;
        private string _id;

        public DispositivoBase(string id) {
            this.Id = id;
        }

        //properties
        public bool Stato {
            get {
                return _stato;
            }
            protected set {
                _stato = value;
            }
        }
        public string Id {
            get {
                return _id;
            }
            private set {
                InserisciSeStringaValida(ref _id, value, "Id");
            }
        }

        public virtual void Accendi() {
            this.Stato = true;
        }

        public virtual void Spegni() {
            this.Stato = false;
        }

        //funzioni protected/private
        protected void InserisciSeStringaValida(ref string campo, string val, string perErrore) {
            if (!String.IsNullOrWhiteSpace(val)) {
                campo = val;
            } else {
                throw new Exception($"Inserire il campo \"{perErrore}\" valido");
            }
        }
        protected void SettaSeMaggioreDiZeroMinoreDiCento(ref int campo, int val, string nomeCampo) {
            if (val > 0 && val < 100) {
                campo = val;
            } else {
                throw new Exception($"Il campo \"{nomeCampo}\" deve essere maggiore di 0 e minore di 100");
            }
        }
    }
}
