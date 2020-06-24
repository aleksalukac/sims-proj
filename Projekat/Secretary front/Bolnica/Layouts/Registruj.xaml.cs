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
    /// Interaction logic for Registruj.xaml
    /// </summary>
    public partial class Registruj : Page
    {
        public static ObservableCollection<Pacijenti2> pacijenti2 = new ObservableCollection<Pacijenti2>();

        public Registruj()
        {
            InitializeComponent();
            this.DataContext = this;

            

        }

        

        private void Potvrdi(object sender, RoutedEventArgs e)
        {

            if (JMBGPacijenta.Text.Length != 13 || ImePacijenta.Text.Length==0 || PrezimePacijenta.Text.Length==0 || BrZPacijenta.Text.Length!=11 || emailTextBox.Text.Length==0 || sifraTextBox.Text.Length==0 || KontaktPacijenta.Text.Length==0 )
            {
                MessageBox.Show("Neodgovarajući unos podataka");
                return;

            }

            MessageBoxResult result = MessageBox.Show("Da li zelite da potvrdite registraciju?", "Registracija pacijenta", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result.Equals(MessageBoxResult.Yes))
            {
                Pacijenti2 pacijent = new Pacijenti2();
                pacijent.ime = ImePacijenta.Text;
                pacijent.prezime = PrezimePacijenta.Text;
                pacijent.Kontakt = KontaktPacijenta.Text;
                pacijent.Email = emailTextBox.Text;
                pacijent.datum = Datum.Text;
                pacijent.JMBG = JMBGPacijenta.Text;
                pacijent.BrZ = BrZPacijenta.Text;
                pacijent.id++;



                pacijenti2.Add(pacijent);
               
                MessageBoxResult resul1 = MessageBox.Show("Uspesna registracija pacijenta.", "Registracija pacijenta");
               
                App.ParentWindowRef.Parent.Navigate(new Profil());   
            }
           




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
