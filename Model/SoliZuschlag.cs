using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruttoNettoRechner.Model
{
    internal class SoliZuschlag
    {
        private const decimal SOLIFG = 16956.00m;
        private const decimal SOLZSATZ = 0.0550m;
        private const decimal SOLZMINSATZ = 0.1190m;
       
        public static decimal SoliZBerechnen(decimal steuer, string strkl) //KinderFB nicht berücksichtigt
        {
            decimal soliz = 0.00m;
            decimal kztab = 0.00m;
            decimal jbmg = steuer * 12;

            if (strkl == "3")
            {
                kztab = 2.0m;

            }
            else
            {
                kztab = 1.0m;
            }

            decimal solzfrei = SOLIFG * kztab;

            if(jbmg > solzfrei)
            {
                decimal solzj = Math.Truncate((jbmg * SOLZSATZ) * 100) / 100;
                decimal solzmin = Math.Truncate( ((jbmg - SOLIFG) * SOLZMINSATZ) *100) / 100;
                if(solzmin < solzj)
                {
                    soliz = Decimal.Round(solzmin / 12, 2);

                }
                else
                {
                    soliz = Decimal.Round(solzj / 12, 2);
                }

            }
            else
            {
                soliz = 0.00m;
            }



            return soliz;
        }



    }
}
