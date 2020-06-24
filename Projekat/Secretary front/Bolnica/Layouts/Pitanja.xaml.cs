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
    /// Interaction logic for Pitanja.xaml
    /// </summary>
    public partial class Pitanja : Page
    {
        public static ObservableCollection<PitanjaiOdgovori> myPitanjaiOdgovori = new ObservableCollection<PitanjaiOdgovori> ();

        public Pitanja()
        {
            InitializeComponent();
           

            if (myPitanjaiOdgovori.Count == 0)
            {
                PitanjaiOdgovori pitanje1 = new PitanjaiOdgovori();
                pitanje1.pitanje = "Da li Vasa bolnica radi 24h?";
                pitanje1.id = 1;


                PitanjaiOdgovori pitanje2 = new PitanjaiOdgovori();
                pitanje2.pitanje = "Da li moram da imam nalog da bih zakazao pregled?";
                pitanje2.id = 2;


                PitanjaiOdgovori pitanje3 = new PitanjaiOdgovori();
                pitanje3.pitanje = "Da li imate orl lekara u bolnici?";
                pitanje3.id = 3;


                myPitanjaiOdgovori.Add(pitanje1);
                myPitanjaiOdgovori.Add(pitanje2);
                myPitanjaiOdgovori.Add(pitanje3);

            }

            ListViewPitanja.ItemsSource = myPitanjaiOdgovori;



        }
        private void Tutorijal(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Tutorijal());
            
        }

        private void Profil(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Profil());
        }

        private void Odgovori(object sender, RoutedEventArgs e)
        {
            
            var pitanje = ListViewPitanja.SelectedItem as PitanjaiOdgovori; 
            if(pitanje != null)
            {
                myPitanjaiOdgovori.Remove(pitanje);
                pitanje.odgovori = odgovorTextBox.Text;
                myPitanjaiOdgovori.Add(pitanje);

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var data =ListViewPitanja.ItemsSource as PitanjaiOdgovori;
            myPitanjaiOdgovori.Remove(data);
            data.pitanje = PitanjeTextBox.Text;
            myPitanjaiOdgovori.Add(data);
          

            
        }
    }
}
