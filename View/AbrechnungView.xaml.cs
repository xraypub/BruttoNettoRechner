using BruttoNettoRechner.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BruttoNettoRechner.View
{
    /// <summary>
    /// Interaktionslogik für AbrechnungView.xaml
    /// </summary>
    public partial class AbrechnungView : UserControl
    {
        public AbrechnungView()
        {
            InitializeComponent();
             
            
        }


        private void Brutto_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Brutto.ToString() != "" || Brutto.Text != null)
            {
                Brutto.SelectAll();
               

            }
        }

            


        private void Brutto_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Brutto.ToString() != "" || Brutto.Text != null)
            {
                Brutto.SelectAll();
                
            }
        }

        private void Alias_GotFocus(object sender, RoutedEventArgs e)
        {
            Alias.SelectAll();
        }

        
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            FocusManager.SetFocusedElement(taxgrid, Alias); 
        }

       
    }
}
