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
    /// Interaction logic for Kontakt.xaml
    /// </summary>
    public partial class Kontakt : Page
    {
        
        
        
        public Kontakt()
        {
            InitializeComponent();


            Registruj.pacijenti2 = Registruj.pacijenti2;

            lvUsers.ItemsSource = Registruj.pacijenti2;

            DataContext = this;



            
        }
       

        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

            var temp =new ObservableCollection<Pacijenti2>(from x in Registruj.pacijenti2 select (Pacijenti2)x.Clone());
            var filter = new ObservableCollection<Pacijenti2>();
            foreach (var resource in temp)
            {
                if (resource.Contains(txtFilter.Text.ToUpper()))
                {
                    filter.Add(resource);
                    lvUsers.ItemsSource = filter;
                }
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
