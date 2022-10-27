using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BruttoNettoRechner.Model
{
    internal class Umlagen
    {
        //private const decimal U1 = 0.00m;  //Umlage für Lohnfortzahlung bis 30 Mitarbeiter   individuell je Krankenkassen und Abstufung!
        //private const decimal U2 = 0.00m;  //Umlage für Mutterschaftsgeld und Beschäftigungsverbot für alle Betriebe individuell je Krankenkasse
        
        private const decimal U3 = 0.0009m;  //Umlage für Insolvenzkasse 

        public static decimal U1Berechnen(decimal brutto, string sKK)
        {
            decimal umlage1 = 0.00m;

            switch (sKK)
            {
                case "AOK":
                    umlage1 = Decimal.Round(brutto * 0.0210m, 2);
                    break;

                case "Techniker":
                    umlage1 = Decimal.Round(brutto * 0.0260m, 2);
                    break;

                case "DAK":
                    umlage1 = Decimal.Round(brutto * 0.0220m, 2);
                    break;

                case "Mobil":
                    umlage1 = Decimal.Round(brutto * 0.0170m, 2);
                    break;

                case "Barmer":
                    umlage1 = Decimal.Round(brutto * 0.0200m, 2);
                    break;

                default:
                    MessageBox.Show("Kein Umlagesatz gefunden1");
                    break;
            }


            return umlage1;


        }


        public static decimal U2Berechnen(decimal brutto, string sKK)
        {
            decimal umlage2 = 0.00m;

            switch (sKK)
            {
                case "AOK":
                    umlage2 = Decimal.Round(brutto * 0.0069m, 2);
                    break;

                case "Techniker":
                    umlage2 = Decimal.Round(brutto * 0.0058m, 2);
                    break;

                case "DAK":
                    umlage2 = Decimal.Round(brutto * 0.0065m, 2);
                    break;

                case "Mobil":
                    umlage2 = Decimal.Round(brutto * 0.0056m, 2);
                    break;

                case "Barmer":
                    umlage2 = Decimal.Round(brutto * 0.0059m, 2);
                    break;

                default:
                    MessageBox.Show("Kein Umlagesatz gefunden1");
                    break;
            }


            return umlage2;


        }


        public static decimal U3Berechnen(decimal brutto)
        {
            decimal umlage3 = 0.00m;

            umlage3 = Decimal.Round(brutto * U3, 2);

            return umlage3;
        }


    }
}
