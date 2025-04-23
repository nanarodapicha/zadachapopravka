using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zadachapopravka
{
    public class Komputur : Ustroistvo, IRemontnaSistema
    {
        public Komputur(string imeUstroystvo, string vidPovreda, double sumaRemont, int dataPredavane, string imeMaistor, string imeKlient)
        : base(imeUstroystvo, vidPovreda, sumaRemont, dataPredavane, imeMaistor, imeKlient)
        {
        }
        public override double AvrSum()
        {
            return SumaRemont;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Ime na ustroistvoto:{this.ImeUstroistvo}\nVid povreda:{this.VidPovreda}\nSuma za remonta:{this.SumaRemont}" +
             $" \nDatata na predavane:{this.DataPredavane}\nImeto na maistora: {this.ImeMaistor}\nImeto na klienta: {this.ImeKlient}");
        }
    }
}
