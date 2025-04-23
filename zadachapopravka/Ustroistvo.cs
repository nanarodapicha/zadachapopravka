using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachapopravka
{
    public abstract class Ustroistvo:IComparable<Ustroistvo>
    {
        public string ImeUstroistvo { get; set; }
        public string VidPovreda { get; set; }
        public double SumaRemont { get; set; }
        public int DataPredavane { get; set; }
        public string ImeMaistor { get; set; }
        public string ImeKlient { get; set; }
        public abstract double AvrSum();
        public Ustroistvo(string imeUstroistvo, string vidPovreda, double sumaRemont, int dataPredavane, string imeMaistor, string imeKlient)
        {
            this.ImeUstroistvo = imeUstroistvo;
            this.VidPovreda = vidPovreda;
            this.SumaRemont= sumaRemont;
            this.DataPredavane= dataPredavane;
            this.ImeMaistor= imeMaistor;
            this.ImeKlient= imeKlient;
        }
        public int CompareTo(Ustroistvo i)
        {
            return this.SumaRemont.CompareTo(i.SumaRemont); 
        }
    }
}
