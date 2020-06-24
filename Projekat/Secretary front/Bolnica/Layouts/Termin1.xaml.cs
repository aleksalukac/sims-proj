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

namespace Bolnica.Layouts
{
    /// <summary>
    /// Interaction logic for Termin1.xaml
    /// </summary>
    public partial class Termin1 : Page
    {
        public Termin1()
        {
            InitializeComponent();
        }
       

        private void Otkazi(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li zelite da otkazete termin?", "Otkazivanje termina", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result.Equals(MessageBoxResult.Yes))
            {
                MessageBox.Show("Uspesno ste otkazali termin!", "Otkazan termin");
                App.ParentWindowRef.Parent.Navigate(new Profil());
            }
        }


        private void Potvrdi(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li zelite da promenite termin?", "Promena termina", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result.Equals(MessageBoxResult.Yes))
            {
                MessageBox.Show("Uspesno ste promenili termin!", "Promena termin");

                App.ParentWindowRef.Parent.Navigate(new Profil());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combobox1.SelectedIndex = 0;
        }
        private void Form1_Load1(object sender, EventArgs e)
        {
            combobox2.SelectedIndex = 2;
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
