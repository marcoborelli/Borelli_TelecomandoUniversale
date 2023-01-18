using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoUniversale {
    public class DispositivoBase {
        private bool _stato;

        //properties
        public bool Stato {
            get {
                return _stato;
            }
            protected set {
                _stato = value;
            }
        }

        public void Accendi() {
            this.Stato = true;
        }

        public void Spegni() {
            this.Stato = false;
        }
    }
}
