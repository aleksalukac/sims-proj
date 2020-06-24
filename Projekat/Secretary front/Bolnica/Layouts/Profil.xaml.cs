using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Bolnica.Layouts
{
    /// <summary>
    /// Interaction logic for Profil.xaml
    /// </summary>
    public partial class Profil : Page
    {
        

        public Profil()
        {
            InitializeComponent();
     
        }

        private void Odjavi_Se(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new WindowsPage());

        }

        private void Tutorijal(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Tutorijal());
           
        }

        private void Registruj(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Registruj());
        }

        private void Zakazi_termin(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Zakazivanje_termina());
        }
        private void Kontakt(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new KontaktiSvi());
        }
        private void Pitanja(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Pitanja());
        }
        private void Cestapitanja(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new CestaPitanja());
        }
        
        private void zakazivanjeoperacije(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Zakazivanje_operacije());
        }

        private void Manipulacijaterminom(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Manipulacijaterminom());
        }

        private void Upravljanje(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Upravljanjesalama());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Povratneinformacije());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Rasporedlekara());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new PacijentiRegistrovani());
        }

       
    }
}
