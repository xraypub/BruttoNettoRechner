using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruttoNettoRechner.Model
{
    internal class ArbeitslosenVers
    {
        private const decimal ALOSAN = 0.0120m;    //Beitragsanteil
        private const decimal ALOSAG = 0.0120m;

        public static decimal ANArbeitslosenAbzug = 0.00m;
        public static decimal AGArbeitslosenAbzug = 0.00m;

        public static decimal ANArbeitslosenAbzugBerechnung(decimal brutto)
        {
            switch (brutto*12)
            {
                case <= RentenVers.BBGRV_West:

                    ANArbeitslosenAbzug = Decimal.Round(brutto * ALOSAN, 2);
                    break;

                case > RentenVers.BBGRV_West:

                    ANArbeitslosenAbzug = Decimal.Round((RentenVers.BBGRV_West * ALOSAN)/12, 2);
                    break;

            }


            return ANArbeitslosenAbzug;
        }


    }
}
