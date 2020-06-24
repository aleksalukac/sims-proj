using Bolnica.Layouts;
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

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow( )
        {
            InitializeComponent();
            this.DataContext = this;


            Registruj.pacijenti2.Add(new Pacijenti2 { id = 1, ime = "Milos", prezime = "Savic", datum = "21/03/2002.", Kontakt = "56732819", Email = "misa2002@hotmail.com", JMBG = "1234321234567", BrZ = "11111111111" }) ;
               Registruj.pacijenti2.Add(new Pacijenti2 {id=2, ime = "Ana", prezime = "Krstic", datum = "28/10/1998.", Kontakt = "098635262", Email = "anakrstiic@hotmail.com", JMBG = "9992929292929", BrZ = "22222222222" });
            Registruj.pacijenti2.Add(new Pacijenti2 { id = 3,ime = "Sara", prezime = "Antic", datum = "02/11/1987.", Kontakt = "0647799555", Email = "1987sara@gmail.com", JMBG = "1236547898742", BrZ = "33333333333" }) ;
             Registruj.pacijenti2.Add(new Pacijenti2 {id=4, ime = "Nikola", prezime = "Leontijevic", datum = "14/08/1995.", Kontakt ="0621515888", Email = "leont@hotmail.com", JMBG = "1254789632541", BrZ = "78533333335" });


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef = this;
            this.Parent.Navigate(new WindowsPage());
        }

        private void Tutorijal(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Tutorijal());

        }

        private void myFrame_ContentRendered(object sender, EventArgs e)
        {
            Parent.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }
    }
}
