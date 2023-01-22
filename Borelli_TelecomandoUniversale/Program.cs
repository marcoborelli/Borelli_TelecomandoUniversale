using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoUniversale {
    internal class Program {
        static void Main(string[] args) {
            DateTime tempo = new DateTime(2022, 12, 25);

            Lampadina l1 = new Lampadina("L1");
            l1.Accendi();
            Caldaia c1 = new Caldaia("C1", "ProduttoreCarino", "CaldaiaCarina", "ABCD1234", tempo);
            c1.Accendi();
            LampadinaDimmerabile ld1 = new LampadinaDimmerabile("LD1");
            ld1.Accendi();
            Tv tv1 = new Tv("TV1", "Samsung", "Modellino");
            tv1.Accendi();

            TelecomandoUniversale t1 = new TelecomandoUniversale(l1);
            t1.Spegni();
            Console.WriteLine($"{t1.Dispositivo.Id};{t1.Dispositivo.Stato}");

            TelecomandoUniversale t2 = new TelecomandoUniversale(c1);
            t2.Spegni();
            Console.WriteLine($"{t2.Dispositivo.Id};{t2.Dispositivo.Stato}");

            TelecomandoUniversale t3 = new TelecomandoUniversale(ld1);
            t3.Spegni();
            Console.WriteLine($"{t3.Dispositivo.Id};{t3.Dispositivo.Stato}");

            TelecomandoUniversale t4 = new TelecomandoUniversale(tv1);
            t4.Spegni();
            Console.WriteLine($"{t4.Dispositivo.Id};{t4.Dispositivo.Stato}");

            Console.ReadKey();
        }
    }
}
