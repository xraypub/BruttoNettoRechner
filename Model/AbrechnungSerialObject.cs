using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BruttoNettoRechner.Model
{
    [XmlType(TypeName = "Brutto-Netto-Lohnkosten-Rechner")]
    public class AbrechnungSerialObject
    {
        public  string? HeaderGehalt { get; set; }

        private string? _name;
       
        public string? Name
        {
            get { return _name; }
            set {
                
                if (_name != value)
                {
                    _name = value;
                }        
            
            }
        }

        private string? _brutto;
       
        public string? BruttoGehalt
        {
            get { return _brutto; }
            set
            {

                if (_brutto != value)
                {
                    _brutto = value;
                }

            }
        }

       
        private string? _steuerabzug;
        public string? Steuerabzug
        {

            get { return _steuerabzug; }

            set
            {
                if (_steuerabzug != value)
                {
                    _steuerabzug = value;
                    
                }

            }
        }

        private string? _soli;
        public string? Soli
        {
            get { return _soli; }

            set
            {

                if (_soli != value)
                {
                    _soli = value;

                }
            }

        }

        private string? _kistrabzug;
        public string? KiStrabzug
        {
            get { return _kistrabzug; }

            set
            {
                if (_kistrabzug != value)
                {
                    _kistrabzug = value;
                    
                }

            }


        }

        private string? _anrentenabzug;
        public string? ANRentenabzug
        {
            get { return _anrentenabzug; }

            set
            {
                if (_anrentenabzug != value)
                {
                    _anrentenabzug = value;
                    
                }

            }

        }

       


        private string? _anarbeitslosenabzug;
        public string? ANArbeitslosenabzug
        {
            get { return _anarbeitslosenabzug; }

            set
            {
                if (_anarbeitslosenabzug != value)
                {
                    _anarbeitslosenabzug = value;
                   
                }

            }


        }

        
        private string? _ankrankenkassenabzug;
        public string? ANKrankenkassenabzug
        {
            get { return _ankrankenkassenabzug; }

            set
            {
                if (_ankrankenkassenabzug != value)
                {
                    _ankrankenkassenabzug = value;
                   
                }

            }


        }

        

        private string? _anpflegekassenabzug;
        public string? ANPflegekassenabzug
        {
            get { return _anpflegekassenabzug; }

            set
            {
                if (_anpflegekassenabzug != value)
                {
                    _anpflegekassenabzug = value;
                    
                }

            }


        }

        private string? _nettogehalt;
        public string? NettoGehalt
        {

            get { return _nettogehalt; }

            set
            {
                if (_nettogehalt != value)
                {
                    _nettogehalt = value;

                }

            }
        }

        public string? HeaderLohnkosten { get; set; }

        private string? _brutto2;

        public string? BruttoGehalt2
        {
            get { return _brutto2; }
            set
            {

                if (_brutto2 != value)
                {
                    _brutto2 = value;
                }

            }
        }

        private string? _agrentenbeitrag;
        public string? AGRentenBeitrag
        {
            get { return _agrentenbeitrag; }

            set
            {
                if (_agrentenbeitrag != value)
                {
                    _agrentenbeitrag = value;

                }

            }

        }

        private string? _agarbeitslosenbeitrag;
        public string? AGArbeitslosenBeitrag
        {
            get { return _agarbeitslosenbeitrag; }

            set
            {
                if (_agarbeitslosenbeitrag != value)
                {
                    _agarbeitslosenbeitrag = value;

                }

            }


        }

        private string? _agkrankenkassenbeitrag;
        public string? AGKrankenkassenBeitrag
        {
            get { return _agkrankenkassenbeitrag; }

            set
            {
                if (_agkrankenkassenbeitrag != value)
                {
                    _agkrankenkassenbeitrag = value;

                }

            }


        }

        private string? _agpflegekassenbeitrag;
        public string? AGPflegekassenBeitrag
        {
            get { return _agpflegekassenbeitrag; }

            set
            {
                if (_agpflegekassenbeitrag != value)
                {
                    _agpflegekassenbeitrag = value;

                }

            }


        }

        private string? _u1;
        public string? U1
        {
            get { return _u1; }

            set
            {
                if (_u1 != value)
                {
                    _u1 = value;
                    
                }

            }


        }


        private string? _u2;
        public string? U2
        {
            get { return _u2; }

            set
            {
                if (_u2 != value)
                {
                    _u2 = value;
                    
                }

            }


        }


        private string? _u3;
        public string? U3
        {
            get { return _u3; }

            set
            {
                if (_u3 != value)
                {
                    _u3 = value;
                    
                }

            }


        }

              


        private string? _lohnkosten;
        public string? Lohnkosten
        {
            get { return _lohnkosten; }

            set
            {

                if (_lohnkosten != value)
                {
                    _lohnkosten = value;
                   
                }
            }

        }

        public AbrechnungSerialObject()
        {

        }

        public AbrechnungSerialObject(string name, string brutto, string lst, string kist, string soli, string rv, string av, string kk, string pv, string netto,
                                                       string agrv, string agav, string agkv, string agpv, string u1, string u2, string u3, string lohnk )
        {
            this.HeaderGehalt = "Gehaltsabrechnung:";
            this.Name = name;
            this.BruttoGehalt = brutto;
            this.Steuerabzug = lst;
            this.KiStrabzug = kist; 
            this.Soli = soli;
            this.ANRentenabzug = rv;
            this.ANArbeitslosenabzug = av;  
            this.ANKrankenkassenabzug = kk;
            this.ANPflegekassenabzug = pv;
            this.NettoGehalt = netto;
            this.HeaderLohnkosten = "Arbeitgeber Lohnkosten:";
            this.BruttoGehalt2 = brutto;
            this.AGRentenBeitrag = agrv;
            this.AGArbeitslosenBeitrag = agav;
            this.AGKrankenkassenBeitrag = agkv;
            this.AGPflegekassenBeitrag = agpv;
            this.U1 = u1;
            this.U2 = u2;
            this.U3 = u3;
            this.Lohnkosten = lohnk;
           

        }



    }
}
