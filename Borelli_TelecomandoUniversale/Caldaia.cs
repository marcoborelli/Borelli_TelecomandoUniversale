using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoUniversale {
    public class Caldaia : DispositivoBase {
        private string _produttore, _modello, _numSerie;
        private DateTime _dataInstallazione;
        private int _tempAcqua, _tempRiscaldamento, _funzionamento;//0=risc+h20 1=h20

        public Caldaia(string id, string prod, string mod, string numSer, DateTime dataInst) : base(id) {
            Accendi();

            this.Produttore = prod;
            this.Modello = mod;
            this.NumeroSerie = numSer;
            this.DataInstallazione = dataInst;
            this.Funzionamento = 0;

            inizializzaVariabili();//inzializzo le altre variabili
        }

        public string Produttore {
            get {
                return _produttore;
            }
            set {
                InserisciSeStringaValida(ref _produttore, value, "Produttore");
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
        public string NumeroSerie {
            get {
                return _numSerie;
            }
            set {
                InserisciSeStringaValida(ref _numSerie, value, "Numero di serie");
            }
        }
        public DateTime DataInstallazione {
            get {
                return _dataInstallazione;
            }
            set {
                if (value != null) {
                    _dataInstallazione = value;
                } else {
                    throw new Exception("Inserire una data valida");
                }
            }
        }
        public int TemperaturaAcqua {
            get {
                return _tempAcqua;
            }
            set {
                if ((value > 10 && value < 40) && this.Stato) {
                    _tempAcqua = value;
                } else {
                    throw new Exception("Impostare valori accettabili e assicurarsi che la caldaia sia accesa");
                }
            }
        }
        public int TemperaturaRiscaldamento {
            get {
                return _tempRiscaldamento;
            }
            set {
                if ((value > 10 && value < 40) && this.Funzionamento == 0 && this.Stato) {
                    _tempRiscaldamento = value;
                } else {
                    throw new Exception("Impostare valori accettabili e assicurarsi che la caldaia sia accesa");
                }
            }
        }
        public int Funzionamento {
            get {
                return _funzionamento;
            }
            set {
                if ((value == 0 || value == 1) && this.Stato) {
                    _funzionamento = value;
                } else {
                    throw new Exception("Impostare valori accettabili e assicurarsi che la caldaia sia accesa");
                }
            }
        }
        public string getStatoFunzionamento() {
            if (!(this.TemperaturaAcqua > 10 && this.TemperaturaAcqua < 40)) {
                return "La temperatura dell'acqua è fuori dai range. Assicurarsi di averla impostata correttamente";
            } else if (!(this.TemperaturaRiscaldamento > 10 && this.TemperaturaRiscaldamento < 40)) {
                return "La temperatura del riscaldamento è fuori dai range. Assicurarsi di averla impostata correttamente";
            } else {
                return String.Empty;
            }
        }

        private void inizializzaVariabili() {
            this.TemperaturaAcqua = 21;
            this.TemperaturaRiscaldamento = 21;
        }
    }
}