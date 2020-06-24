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
    /// Interaction logic for Slobodnesale1.xaml
    /// </summary>
    public partial class Slobodnesale1 : Page
    {
        public Slobodnesale1()
        {
            InitializeComponent();
            List<Salaa> items = new List<Salaa>();
            items.Add(new Salaa() { Sala = "p101" });
            items.Add(new Salaa() { Sala = "p201" });
            items.Add(new Salaa() { Sala = "p250" });
            lvUsers.ItemsSource = items;
        }

        public class Salaa
        {
            public string Sala { get; set; }


        }
        public void Zauzmi(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Zauzimanjeslobodne1());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Upravljanjesalama());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Zauzetesale1xaml());
        }

        private void Profil(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Profil());
        }

        private void Tutorijal(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Tutorijal());
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Zakazivanje_termina());
        }
    }
}
