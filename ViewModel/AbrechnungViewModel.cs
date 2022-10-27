using BruttoNettoRechner.Model;
using BruttoNettoRechner.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace BruttoNettoRechner.ViewModel
{
    internal class AbrechnungViewModel : ViewModelBase
    {
        public SteuerBerechnung AbrechnungSteuer { get; set; }

        

        //Properties

        private string? _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                    
                }
            }
        }

        public  List<string> StrKlassen { get; }
        public List<string> KiSteuer { get;  }

        public List<string> KinderFB { get; }
        public List<string> KrankenKassen { get; }  

        private string? _selectedsteuerklasse;
        public string? SelectedSteuerklasse
        {
            get { return _selectedsteuerklasse; }
            set
            {    if(_selectedsteuerklasse != value)
                {
                    _selectedsteuerklasse = value;
                    OnPropertyChanged();
                    
                }
                
               
            }
        }

        private string? _selectedkisteuer;
        public string? SelectedKiSteuer
        {
            get { return _selectedkisteuer; }
            set
            {
                if (_selectedkisteuer != value)
                {
                    _selectedkisteuer = value;
                    OnPropertyChanged();
                    BlockBerechnen = false;
                    BerechnenButton?.RaiseCanExecuteChanged();
                }


            }
        }

        private string? _selectedkifb;
        public string? SelectedKiFB
        {
            get { return _selectedkifb; }
            set
            {
                if (_selectedkifb != value)
                {
                    _selectedkifb = value;
                    OnPropertyChanged();

                }


            }
        }

        private string? _selectedkrankenkasse;
        public string? SelectedKrankenkasse
        {
            get { return _selectedkrankenkasse; }
            set
            {
                if (_selectedkrankenkasse != value)
                {
                    _selectedkrankenkasse = value;
                    OnPropertyChanged();
                    BlockBerechnen = false;
                    BerechnenButton?.RaiseCanExecuteChanged();
                }


            }
        }


        private decimal _bruttogehalt;
        public decimal BruttoGehalt
        {

            get { return _bruttogehalt; }

            set
            {
                if (_bruttogehalt != value)
                {
                    _bruttogehalt = value;
                    ClearProperties();
                    OnPropertyChanged();
                    BlockBerechnen = false;
                    BerechnenButton?.RaiseCanExecuteChanged();
                  
                   
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
                }

            }


        }


        private string? _soli;
        public string? Soli
        {
            get { return _soli; }

            set { 
                
                if (_soli != value)
                {
                    _soli = value;
                    OnPropertyChanged();
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
                    OnPropertyChanged();
                }
            }

        }


        private bool? _blockberechnen;
        public bool? BlockBerechnen
        {
            get { return _blockberechnen; }

            set
            {
                if(_blockberechnen != value)
                {
                    _blockberechnen = value;
                   
                    BerechnenButton?.RaiseCanExecuteChanged();

                }
            }
        }

        private bool? _blockeingabe;
        public bool? BlockEingabe
        {
            get { return _blockeingabe; }

            set
            {
                if (_blockeingabe != value)
                {
                    _blockeingabe = value;
                    OnPropertyChanged();
                    

                }
            }
        }

        private bool _isxml;

        public bool IsXML
        {
            get { return _isxml; }
            set { 
                   if( _isxml != value)
                    {
                       _isxml = value;
                       OnPropertyChanged();
                       SpeichernXMLButton?.RaiseCanExecuteChanged();
                    } 
            }
        }

        private string? _statuscheck;

        public string? Statuscheck
        {
            get { return _statuscheck; }
            set {

                if (_statuscheck != value)
                {
                    _statuscheck = value;
                    OnPropertyChanged();
                }
                 
            }
        }



        //Methoden

        public void ClearProperties()
        {
           
            this.Steuerabzug = "";
            this.Soli = "";
            this.KiStrabzug = "";
            this.ANRentenabzug = "";
            this.ANArbeitslosenabzug = "";
            this.ANKrankenkassenabzug = "";
            this.ANPflegekassenabzug = "";
            this.NettoGehalt = "";
            this.AGRentenBeitrag = "";
            this.AGArbeitslosenBeitrag = "";
            this.AGKrankenkassenBeitrag = "";
            this.AGPflegekassenBeitrag = "";
            this.U1 = "";
            this.U2 = "";
            this.U3 = "";
            this.Lohnkosten = "";

            IsXML = false;
            Statuscheck = "Neue Dateneingabe!";

        }

        public async void  BerechnenAsync(decimal brutto)
        {
            BlockEingabe = true;
            BlockBerechnen = true;

            Statuscheck = "Berechnung läuft ...";

            decimal bruttoDecimal = brutto; //0.00m;
            decimal tempSteuer = 0.00m;
            decimal tempKiStr = 0.00m;
            decimal tempSoli = 0.00m;
            decimal tempANRentenAbzug = 0.00m;
            decimal tempANArbeitslosenAbzug = 0.00m;
            decimal tempANKrankenkassenAbzug = 0.00m;
            decimal tempAGKrankenKassenBeitrag = 0.00m;
            decimal tempANPflegekassenAbzug = 0.00m;
            decimal tempNetto = 0.00m;
            decimal tempU1 = 0.00m;
            decimal tempU2 = 0.00m;
            decimal tempU3 = 0.00m;
            decimal tempLohnkosten = 0.00m;


            
            if ((SelectedKrankenkasse != null) && (SelectedSteuerklasse != null) && (SelectedKiFB != null))
            {


                    tempSteuer =  await AbrechnungSteuer.Steuer(bruttoDecimal, SelectedKrankenkasse, SelectedSteuerklasse, SelectedKiFB);
                    tempSoli = SoliZuschlag.SoliZBerechnen(tempSteuer, SelectedSteuerklasse);
                    this.Soli = tempSoli.ToString("N2");
                    this.Steuerabzug = tempSteuer.ToString("N2");
                    

                }
                else
                {
                    
                    MessageBox.Show("Keine gültigen Eingabewerte! Nur Zahlenformat / Dezimalzahl etc.");

                }

                //Kirchensteuerberechnnung
                if (SelectedKiSteuer != null)
                {
                    tempKiStr = Kirchensteuer.KirchenSteuerAbzug(SelectedKiSteuer, tempSteuer);
                    this.KiStrabzug = tempKiStr.ToString("N2");
                }


                //SoliZuchalg

                this.Soli = tempSoli.ToString("N2");


                //Rentenversicherungsbeitrag 
                tempANRentenAbzug = RentenVers.ANRentenAbzugBerechnung(bruttoDecimal);
                this.ANRentenabzug = tempANRentenAbzug.ToString("N2");
                this.AGRentenBeitrag = this.ANRentenabzug;

                //Arbeitsloenversicherungsbeitrag
                tempANArbeitslosenAbzug = ArbeitslosenVers.ANArbeitslosenAbzugBerechnung(bruttoDecimal);
                this.ANArbeitslosenabzug = tempANArbeitslosenAbzug.ToString("N2");
                this.AGArbeitslosenBeitrag = this.ANArbeitslosenabzug;

                //Krankenkassenversicherungsbeitrag
                if (SelectedKrankenkasse != null)
                {
                    tempANKrankenkassenAbzug = Krankenkassen.ANKrankenkassenAbzugBerechnen(bruttoDecimal, SelectedKrankenkasse);
                    this.ANKrankenkassenabzug = tempANKrankenkassenAbzug.ToString("N2");
                    tempAGKrankenKassenBeitrag = Krankenkassen.AGKrankenkassenBeitragBerechnen(bruttoDecimal, SelectedKrankenkasse);
                    this.AGKrankenkassenBeitrag = tempAGKrankenKassenBeitrag.ToString("N2");
                }


                //Pflegeversicherungsbeitrag
                tempANPflegekassenAbzug = PflegeVers.ANPflegekassenAbzugBerechnen(bruttoDecimal);
                this.ANPflegekassenabzug = tempANPflegekassenAbzug.ToString("F2");
                this.AGPflegekassenBeitrag = this.ANPflegekassenabzug;

                //U1 U2 U3
                if (SelectedKrankenkasse != null)
                {
                    tempU1 = Umlagen.U1Berechnen(bruttoDecimal, SelectedKrankenkasse);
                    this.U1 = tempU1.ToString("N2");

                    tempU2 = Umlagen.U2Berechnen(bruttoDecimal, SelectedKrankenkasse);
                    this.U2 = tempU2.ToString("N2");

                    tempU3 = Umlagen.U3Berechnen(bruttoDecimal);
                    this.U3 = tempU3.ToString("N2");

                }

                //Netto-Gehalt Berechnung
                tempNetto = bruttoDecimal - (tempSteuer + tempKiStr + tempSoli + tempANRentenAbzug + tempANArbeitslosenAbzug + tempANKrankenkassenAbzug + tempANPflegekassenAbzug);
                this.NettoGehalt = tempNetto.ToString("N2");

                //Lohnkosten Berechnung
                tempLohnkosten = bruttoDecimal + tempANRentenAbzug + tempANArbeitslosenAbzug + tempAGKrankenKassenBeitrag + tempANPflegekassenAbzug + tempU1 + tempU2 + tempU3;
                this.Lohnkosten = tempLohnkosten.ToString("N2");

           
           
            //BlockBerechnen = false;
            BlockEingabe = false;
            IsXML = true;
            Statuscheck = "Berechung abgeschlossen - Neue Dateneingabe möglich!";

        }

        
        public async void SpeichernXMLAsync()
        {
            Statuscheck = "XML Speicherung läuft!";

            string? BruttoGehaltString = BruttoGehalt.ToString("N2");
            //MessageBox.Show(BruttoGehaltString + "Name:" + Name);

            if (BruttoGehaltString != null)
            {
                AbrechnungSerialObject abrechnungSerialObject = new(Name, BruttoGehaltString,Steuerabzug, KiStrabzug, Soli, ANRentenabzug, ANPflegekassenabzug,
                                                                       ANKrankenkassenabzug, ANPflegekassenabzug, NettoGehalt,AGRentenBeitrag, AGArbeitslosenBeitrag, AGKrankenkassenBeitrag,
                                                                       AGPflegekassenBeitrag, U1, U2, U3, Lohnkosten);
                ToXML toXML = new();
                await toXML.XMLRunAsync(abrechnungSerialObject);
                Statuscheck = "XML Speicherung abgeschlossen - Neue Dateneingabe möglich!";
            }
            else
            {
                Statuscheck = "Fehler beim XML-Speichern!";
            }

            IsXML = false;
           
        }


        //Commands
        public DelegateCommand? BerechnenButton { get; set; } 

        public DelegateCommand? SpeichernXMLButton { get; set; }

        //Konstruktor

        public AbrechnungViewModel()
        {

            //Verweis auf Listen in Model
            Steuerklassen tempStrKl = new();
            StrKlassen = tempStrKl.SteuerKlassen;

            Kirchensteuer tempKiStr = new();
            KiSteuer = tempKiStr.KirchenSteuer;

            Kinderfreibetrag tempKiFB = new();
            KinderFB = tempKiFB.KinderFreibetrag;

            Krankenkassen tempKrKa = new();
            KrankenKassen = tempKrKa.KrankenkassenListe;

            AbrechnungSteuer = new();

            BlockEingabe = false;
            IsXML = false;
            this.Name = "Alias";
            Statuscheck = "Neue Dateneingabe!";
           
            //Commands einrichten

            this.BerechnenButton = new DelegateCommand(

               (obj) =>
               {
                    BerechnenAsync(BruttoGehalt);
               },

                (obj) => !( BruttoGehalt <= 0 || BlockBerechnen.Equals(true))           

                ) ; //Ende Command ShowButton  

            this.SpeichernXMLButton = new DelegateCommand(

              (obj) =>
              {
                  SpeichernXMLAsync();
              },

               (obj) => IsXML

               ); //Ende Command SpeichernXMLButton 



        }

    }
}
