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
    /// Interaction logic for Povratneinformacije.xaml
    /// </summary>
    public partial class Povratneinformacije : Page
    {
        public List<Povrtnainf> myPovratnainf { get; set; }

        public Povratneinformacije()
        {
            InitializeComponent();
            myPovratnainf = new List<Povrtnainf>();
          
            Povrtnainf pov1 = new Povrtnainf();
            pov1.Korisnik = "Aleksandar Savic";
            pov1.Informacija = "Izuzetno sam zadovoljan uslugama vase bolnice.";
            pov1.Ocena = "5/5";

            Povrtnainf pov2 = new Povrtnainf();
            pov2.Korisnik = "Milica Nenadic";
            pov2.Informacija = "Bez cekanja,brza usluga i dobri lekari.Jedina zamerka je lokacija.";
            pov2.Ocena = "4/5";

            Povrtnainf pov3 = new Povrtnainf();
            pov3.Korisnik = "Nikola Nikolic";
            pov3.Informacija = "Prvi put sam posetio vasu bolnicu i preporucio bih svima.";
            pov3.Ocena = "5/5";

            Povrtnainf pov4 = new Povrtnainf();
            pov4.Korisnik = "Marko Markovic";
            pov4.Informacija = "Nezadovoljan sam ,zbog neljubaznosti pojedinih zaposlenih.";
            pov4.Ocena = "2/5";

            myPovratnainf.Add(pov1);
            myPovratnainf.Add(pov2);
            myPovratnainf.Add(pov3);
            myPovratnainf.Add(pov4);

           
            listBox.DataContext = myPovratnainf;

        }
        private void Tutorijal(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Tutorijal());
            
        }

        private void Profil(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Profil());
        }

    }
}
