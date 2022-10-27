using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruttoNettoRechner.Model
{
    internal class Steuerklassen
    {
        public List<string> SteuerKlassen;

        public void RemItem()
        {
            this.SteuerKlassen.Remove(SteuerKlassen[5]);
        }


        public Steuerklassen()
        {
            SteuerKlassen = new() { "1", "2", "3", "4", "5", "6" };
        }



    }

    

}
