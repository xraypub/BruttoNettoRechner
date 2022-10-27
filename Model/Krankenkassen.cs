using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BruttoNettoRechner.Model
{
    internal class Krankenkassen
    {
        public List<string> KrankenkassenListe;

        public const decimal BBGKV = 58050.00000m;
        
        public const decimal KVBeitrag = 0.14600m;
        public const decimal KVBeitragVermindert = 0.14000m;

        public static decimal ANKrankenkassenAbzug = 0.00m;
        public static decimal AGKrankenkassenBeitrag = 0.00m;
        private static decimal KVZ = 0.00m;
        


        public const decimal AOK_KVZ = 0.0130m;


        public const decimal TK_KVZ = 0.0120m;


        public const decimal DAK_KVZ = 0.0150m;


        public const decimal Mobil_KVZ = 0.0129m;


        public const decimal Barmer_KVZ = 0.0150m;


        public static decimal ANKrankenkassenAbzugBerechnen(decimal brutto, string sKK)
        {
            ANKrankenkassenAbzug = 0.00m;
            KVZ = 0.00m;
            KVZ = KVZ_indivi(sKK);

            if (brutto*12 <= BBGKV)
            {
                ANKrankenkassenAbzug = Decimal.Round(brutto * ((KVBeitrag / 2) + (KVZ/2)), 2);
            }
            else
            {
                ANKrankenkassenAbzug = Decimal.Round((BBGKV * ((KVBeitrag / 2) + (KVZ/2)))/12, 2);
            }

            return ANKrankenkassenAbzug;
        }

        public static decimal AGKrankenkassenBeitragBerechnen(decimal brutto, string sKK)
        {
            AGKrankenkassenBeitrag = 0.00m;
            KVZ = 0.00m;
            KVZ = KVZ_indivi(sKK);

            if (brutto * 12 <= BBGKV)
            {
                AGKrankenkassenBeitrag = Decimal.Round(brutto * ((KVBeitrag / 2) + (KVZ / 2)), 2);
            }
            else
            {
                AGKrankenkassenBeitrag = Decimal.Round((BBGKV * ((KVBeitrag / 2) + (KVZ / 2))) / 12, 2);
            }


            return AGKrankenkassenBeitrag;
        }


        public static decimal KVZ_indivi(string sKK)
        {
            decimal kvz = 0.00m;

            switch (sKK)
            {
                case "AOK":
                    kvz = AOK_KVZ;
                    break;

                case "Techniker":
                    kvz = TK_KVZ;
                    break;

                case "DAK":
                    kvz = DAK_KVZ;
                    break;

                case "Mobil":
                    kvz = Mobil_KVZ;
                    break;

                case "Barmer":
                    kvz = Barmer_KVZ;
                    break;


                default:
                    MessageBox.Show("Keinen KK Zusatzbeitrag gefunden!");
                    break;
            }

            
            return kvz;
        }




        public Krankenkassen()
        {
            KrankenkassenListe = new() { "AOK", "Techniker", "DAK", "Mobil", "Barmer" };

            

        }


    }
}
