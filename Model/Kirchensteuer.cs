using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruttoNettoRechner.Model
{
    internal class Kirchensteuer
    {

        public List<string> KirchenSteuer;

        public static decimal kiStrBetrag = 0.00m;

        public static decimal KirchenSteuerAbzug(string kistr, decimal lohnstr)   //KinderFB nicht berücksichtigt
        {
            kiStrBetrag = 0;

            switch (kistr)
            {
                case "keine":
                    kiStrBetrag = 0;
                    break;

                case "8%":
                    kiStrBetrag = (Math.Truncate(lohnstr * 0.08m *100) / 100);
                    break;

                case "9%":
                    kiStrBetrag = (Math.Truncate(lohnstr * 0.09m * 100) / 100);
                    break;

            }

            return kiStrBetrag;
        }

        public Kirchensteuer()
        {
            KirchenSteuer = new() { "keine", "8%", "9%" };
        }


    }
}
