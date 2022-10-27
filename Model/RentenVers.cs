using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruttoNettoRechner.Model
{
    internal class RentenVers
    {
        public const decimal BBGRV_West = 84600.00m;
        public const decimal BBGRV_Ost = 81000.00m;

        public const decimal RVSATZAN = 0.0930m;
        public const decimal RVSATZAG = 0.0930m;

        public const decimal TBSVORV = 0.8800m; //Teilbetragssatz der Vorsorgepauschale für die Rentenversicherung


        public static decimal ANRentenAbzug = 0.00m;
        public static decimal AGRentenAbzug = 0.00m;

        public static decimal ANRentenAbzugBerechnung(decimal brutto)    //nur WEST - Ost noch nicht verfügbar!
        {
            switch (brutto * 12)
            {
                case <= BBGRV_West:

                    ANRentenAbzug = Decimal.Round(brutto * RVSATZAN, 2);
                    break;

                    case > BBGRV_West:

                    ANRentenAbzug = Decimal.Round((BBGRV_West * RVSATZAN)/12, 2);
                    break;

            }

            return ANRentenAbzug;
        }


    }
}
