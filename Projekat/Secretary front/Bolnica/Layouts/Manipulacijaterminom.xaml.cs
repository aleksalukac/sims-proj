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
    /// Interaction logic for Manipulacijaterminom.xaml
    /// </summary>
    public partial class Manipulacijaterminom : Page
    {
        public List<Termin> myTermin { get; set; }

        public Manipulacijaterminom()
        {
            InitializeComponent();
            myTermin = new List<Termin>();
            Termin Termin1 = new Termin();

            Termin1.ImePrezime = "Nikola Nikolic";
            Termin1.Specijalnost = "Opsta";
            Termin1.ImePrezimeLekara = "Marina Marinkovic";
            Termin1.Datum = "13.05.2020.";
            Termin1.Vreme = "14:00";
            Termin1.Sala = "p201";

            Termin Termin2 = new Termin();

            Termin2.ImePrezime = "Milica Nenadic";
            Termin2.Specijalnost = "Opsta";
            Termin2.ImePrezimeLekara = "Darko Gajic";
            Termin2.Datum = "14.05.2020.";
            Termin2.Vreme = "08:00";
            Termin2.Sala = "p101";

            Termin Termin3 = new Termin();


            Termin3.ImePrezime = "Nikola Nikolic";
            Termin3.Specijalnost = "Ocno";
            Termin3.ImePrezimeLekara = "Zaharije Trnavac";
            Termin3.Datum = "13.05.2020.";
            Termin3.Vreme = "15:00";
            Termin3.Sala = "p300";

            Termin Termin4= new Termin();


            Termin4.ImePrezime = "Aleksandar Savic";
            Termin4.Specijalnost = "Hirurgija";
            Termin4.ImePrezimeLekara = "Aleksandar Arsic";
            Termin4.Datum = "18.05.2020.";
            Termin4.Vreme = "12:30";
            Termin4.Sala = "o320";

            myTermin.Add(Termin1);
            myTermin.Add(Termin2);
            myTermin.Add(Termin3);
            myTermin.Add(Termin4);

            lvUsers.ItemsSource = myTermin;



            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            view.Filter = UserFilter;


        }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(txtFilter.Text))
                return true;
            else
                return ((item as Termin).ImePrezime.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
        }
        private void Tutorijal(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Tutorijal());
            
        }

        private void Profil(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Profil());
        }
        private void Izmeni(object sender,RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Termin1());
        }

       
    }
}
