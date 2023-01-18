using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoUniversale {
    public class TelecomandoUniversale {
        DispositivoBase _d;
        public TelecomandoUniversale(DispositivoBase d) {
            this.Dispositivo = d;
        }

        public DispositivoBase Dispositivo {
            get {
                return _d;
            }
            set {
                if (value != null) {
                    _d = value;
                } else {
                    throw new Exception("Inserire un dispositivo valido");
                }
            }
        }

        public void Spegni() {
            _d.Spegni();
        }
        public void Accendi() {
            _d.Accendi();
        }
    }
}
