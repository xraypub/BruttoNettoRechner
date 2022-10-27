using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace BruttoNettoRechner.Model
{
    internal class SteuerBerechnung
    {
        
        
        
        
        //Felder

        private const decimal ANPAUSCH = 1200.00m;
        private const decimal SOZVPAUSCH = 36.00m;
        private const decimal KFBExistenz = 2730.00m;
        private const decimal KFBAusbildung = 1464.00m;

        private const decimal GFB = 10347.00m;
       
        

        private decimal ZRE4 = 0.00m;
        private decimal ZRE4J = 0.00m;
        private decimal ZRE4VP = 0.00m;
        private decimal ZVE = 0.00m;
        private decimal X = 0.00m;
        private decimal KZTAB = 0.00m;
        private decimal KFB = 0.00m;   //Kinderfreibetrag bei Lohnsteuer unterjährig nicht berücksichtigt -> Kindergeld   // nur bei KiStr. und Soli

        private decimal VSP = 0.00m;  //Vorsorgepauschale
        private decimal VSP1 = 0.00m; //Zwischenwert 1 VSP
        private decimal VSP2 = 0.00m; //Zwischenwert 2 VSP
        private decimal VSP3 = 0.00m; //Vorsorgepauschale mit Teilbeträgen
        private decimal VSPN = 0.00m; //Vorsorgepauschale mit Teil RV und KV PV
        private decimal KVZ = 0.00m;  //Krankenkassen Zusatzbeitrag individuell
        private decimal KVSATZAN = 0.00000m;
        private decimal KVSATZAG = 0.00000m;


        //Properties

        private int PKV { get; set; }   // 0 = gesetzlich krankenversichert  !! nur implementiert !!!
        private int KRV { get; set; }  // 0 gesetzlich rentenversichert    !! nur implementiert !!!

        private static string? StrKlasse { get; set; } 


        //Methoden

        public Task<decimal> Steuer(decimal brutto, string s_Krankenkasse, string s_StrKlasse, string s_KiFB)
        {

            try
            {
                return Task.Run(() =>
                {
                    KVZ = Krankenkassen.KVZ_indivi(s_Krankenkasse);
                    KVSATZAN = ((KVZ / 2) + (Krankenkassen.KVBeitragVermindert / 2));
                    KFB = (KFBAusbildung + KFBExistenz) * decimal.Parse(s_KiFB);    
                    StrKlasse = s_StrKlasse;

                    if(StrKlasse == "3")
                    {
                        KZTAB = 2.0m;

                    }
                    else
                    {
                        KZTAB = 1.0m;
                    }




                    decimal steuer = 0.00m;

                    //Monatsbrutto in Jahresbrutto in Cent 
                    decimal RE4 = brutto * 100;            



                    ZRE4J = Decimal.Round((RE4 * 12)/100, 2);
                    ZRE4VP = Decimal.Round((RE4 * 12)/100, 2);  // Abzug Entschädigungen fehlt!!

                    ZRE4 = ZRE4J - ( ANPAUSCH + SOZVPAUSCH);  


                    VSP = VorsorgePauschale();

                    ZVE = Decimal.Round( (ZRE4 - VSP) , 2);          // Abzug weiterer Beträge fehlt AltersFB etc.

                    if (ZVE < 1)
                    {
                        ZVE = 0.00m;
                        X = 0.00m;
                    } else
                    {
                        X = ZVE / KZTAB;      //ZVE : KZTAB   - 1 Grundtarif, 2 Splittingtarif
                    }

                    if( int.Parse(s_StrKlasse) < 5)               // evtl. TryParse!!
                    {
                        steuer = UPTAB22();

                    } else
                    {
                        // Sonderberechnung
                        MessageBox.Show("Sterklassen 5 und 6 nicht implementiert");

                    }
                    
                    
                    
                    //Thread.Sleep(5000);
                    return steuer;






                });        // Task.Run Ende

            } catch
            {


                return Task.Run(() => -1.00m); 
            }          
        }

        protected decimal VorsorgePauschale()
        {
           

            decimal vsp = 0.00m;
            decimal vhb = 0.00m;

            decimal KK_ZRE4VP = 0.00m;
            decimal RV_ZRE4VP = 0.00m;


            //Berechnung Mindestvorsorgepauschae
            
            if(ZRE4VP > Krankenkassen.BBGKV)   
            {

                KK_ZRE4VP = Krankenkassen.BBGKV;   

            }
            else
            {
                KK_ZRE4VP = ZRE4VP;

            }



            if(PKV > 0)    
            {

                //Sonderberechnung
            }

            decimal tempVSP3 = KK_ZRE4VP * (KVSATZAN + PflegeVers.PVSATZAN);
            VSP3 = Decimal.Round(tempVSP3, 2);


            //Berechnung Vorsorgepauschale

             if(KRV > 0)
            {
                //Sonderberechnung
            }

            if (ZRE4VP > RentenVers.BBGRV_West)         //Nur West-Löhne bisher berücksichtigt
            {
                RV_ZRE4VP = RentenVers.BBGRV_West;

            }
            else
            {
                RV_ZRE4VP = ZRE4VP;
            }

            decimal tempVSP1 = Decimal.Round( (RV_ZRE4VP * RentenVers.TBSVORV), 2);

            VSP1 = Decimal.Round( (tempVSP1 * RentenVers.RVSATZAN), 2);

            VSP2 = ZRE4VP * 0.1200m;

            if(StrKlasse == "3")
            {
                vhb = 3000.00m;

            } else
            {
                vhb = 1900.00m;
            }

            if (VSP2 > vhb)
            {

                VSP2 = vhb;

            }   

            VSPN = Decimal.Round( (VSP1 + VSP2) , 2);  

            VSP = Decimal.Round( (VSP1 + VSP3) , 2);    

            if(VSPN > VSP)
            {

                VSP = VSPN;
            }

            vsp = Math.Ceiling(VSP);

            return vsp;
        }


        protected decimal UPTAB22()          //Anwendung Steuertarife
        {
            decimal Y = 0.000000m;
            decimal RW = 0.00m;
            decimal ST = 0.00m;

            switch (X)
            {
                case  < (GFB + 1):
                    ST = 0.00m;
                    break;

                case < 14927.00m:

                    Y = (X - GFB) / 10000;
                    RW = Y * 1088.67m;
                    RW = RW + 1400.00m;
                    ST = Math.Floor( RW * Y );

                    break;

                case < 58597.00m:

                    Y = (X - 14926.00m) / 10000;
                    RW = Y * 206.43m;
                    RW = RW + 2397.00m;
                    RW = RW * Y;
                    ST = Math.Floor(RW + 869.32m);
                   
                    break;

                case < 277826.00m:

                    ST = Math.Floor((X * 0.42m) - 9336.45m);

                    break;

                case >= 277826.00m:

                    ST = Math.Floor((X * 0.45m) - 17671.20m);
                    
                    break;

                                   
            }

            ST = Math.Truncate(((ST * KZTAB) /12)*100) / 100;

            return ST;
        }



        //Konstruktor

        public SteuerBerechnung()
        {

            this.PKV = 0;
            this.KRV = 0;   
           
        }


    }
}
