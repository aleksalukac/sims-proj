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
    /// Interaction logic for Kontakt1.xaml
    /// </summary>
    public partial class Kontakt1 : Page
    {
       

        public List<Lekar> myLekar { get; set; }

        public Kontakt1()
        {
            InitializeComponent();
        


            lvUsers.ItemsSource = myLekar;



            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            view.Filter = UserFilter;




        }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(txtFilter.Text))
                return true;
            else
                return ((item as Lekar).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
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

    }
}
