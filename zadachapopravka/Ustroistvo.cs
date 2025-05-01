using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachapopravka
{
    public abstract class Ustroistvo
    {
        private string imeUstroistvo;

        public string ImeUstroistvo
        {
            get { return imeUstroistvo; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Vuvedi ime na ustroistvoto");
                }
                imeUstroistvo = value; 
            }
        }
        private string vidPovreda;

        public string VidPovreda
        {
            get { return vidPovreda; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Vuvedi vid povreda");
                }
                vidPovreda = value;
            }
        }
        //dddddd
        public Ustroistvo(string imeUstroistvo, string vidPovreda)
        {
            ImeUstroistvo = imeUstroistvo;
            VidPovreda = vidPovreda;
        }
        public abstract double AvrSum();
    }
}
