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
    /// Interaction logic for Zakazivanje_termina.xaml
    /// </summary>
    public partial class Zakazivanje_termina : Page
    {

        public Zakazivanje_termina()
        {
            InitializeComponent();
            
        }

        private void Neregitrovani(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Neregitrovani());
        }


        private void Profil(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Profil());
        }

        private void Regitrovani(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Regitrovani());
        }

        private void Tutorijal(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Tutorijal());
          
        }
    }
}
