using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoUniversale {
    internal class Program {
        static void Main(string[] args) {
            Lampadina l1 = new Lampadina();
            TelecomandoUniversale t1 = new TelecomandoUniversale(l1);
            l1.Accendi();
            t1.Spegni();
            Console.WriteLine($"{l1.Stato}");
        }
    }
}
