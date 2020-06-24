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
using System.Xml.Linq;

namespace Bolnica.Layouts
{
    /// <summary>
    /// Interaction logic for PacijentiRegistrovani.xaml
    /// </summary>
    public partial class PacijentiRegistrovani : Page
    {
        public PacijentiRegistrovani()
        {
            InitializeComponent();

            Registruj.pacijenti2 = Registruj.pacijenti2;


            Pacijenti.ItemsSource = Registruj.pacijenti2;

        }

        private void Profil(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Profil());
        }

        private void Tutorijal(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Tutorijal());
            
        }
    }
}
