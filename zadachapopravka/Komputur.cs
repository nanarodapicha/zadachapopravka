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
        private double sumaRemont;

        public double SumaRemont
        {
            get { return sumaRemont; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Vuvedi validno chislo za suma(bez 0)");
                }
                sumaRemont = value;
            }
        }

        private int dataPredavane;

        public int DataPredavane
        {
            get { return dataPredavane; }
            set 
            { 
                if (value >31 || value<1)
                {
                    throw new Exception("datata trqbva da e mejdu 1 i 31");
                }
                dataPredavane = value; 
            }
        }
        private string imeMaistor;

        public string ImeMaistor
        {
            get { return imeMaistor; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Vuvedi ime na maistor");
                }
                imeMaistor = value; 
            }
        }

        private string imeKlient;

        public string ImeKlient
        {
            get { return imeKlient; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Vuvedi ime na klient");
                }
                imeKlient = value;
            }
        }

        public Komputur(string imeUstroistvo, string vidPovreda, double sumaRemont, int dataPredavane, string imeMaistor, string imeKlient)
            : base(imeUstroistvo, vidPovreda)
        {
            SumaRemont = sumaRemont;
            DataPredavane = dataPredavane;
            ImeMaistor = imeMaistor;
            ImeKlient = imeKlient;
        }

        public override double AvrSum()
        {
            return SumaRemont;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Ime na ustroistvoto: {ImeUstroistvo}\nVid povreda: {VidPovreda}\nSuma za remont: {SumaRemont}" +
                              $"\nData na predavane: {DataPredavane}\nMaistor: {ImeMaistor}\nKlient: {ImeKlient}");
        }
    }
}
