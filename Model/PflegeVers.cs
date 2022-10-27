using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace BruttoNettoRechner.Model
{
    internal class PflegeVers
    {

        public static decimal PVSATZAN = 0.01525m;

        public const decimal PVZusatzAN = 0.00350m; // derzeit nicht genutzt - Altersberechnug erforderlich
        public const decimal PVSATZAG = 0.015250m;

        public const decimal BBGPV = 58050.00000m;   // Beitragsbemessungsgrenze PV == KV 

        public static decimal ANPflegekassenAbzug = 0.00m;
        public static decimal AGPflegekassenAbzug = 0.00m;

        public static decimal ANPflegekassenAbzugBerechnen(decimal brutto)
        {
            ANPflegekassenAbzug = 0.00m;

            if(brutto*12 <= BBGPV)
            {

                ANPflegekassenAbzug = Decimal.Round(brutto * PVSATZAN, 2);

            }
            else
            {
                ANPflegekassenAbzug = Decimal.Round((BBGPV * PVSATZAN)/12, 2);   
            }


            return ANPflegekassenAbzug;
        }



    }
}
