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
    /// Interaction logic for WindowsPage.xaml
    /// </summary>
    public partial class WindowsPage : Page
    {

        public WindowsPage()
        {
            InitializeComponent();
         
        }

        private void Tutorijal(object sender, RoutedEventArgs e)
        {

                App.ParentWindowRef.Parent.Navigate(new Tutorijal());
           
        }

        private void Profil(object sender, RoutedEventArgs e)
        {

            string password = Sekretar.getInstance().Password;


            if (Sekretar.getInstance().Email.Equals(Email.Text) && Sekretar.getInstance().Password.Equals(Crypt.Encrypt(Sifra.Password)))
            {
                App.ParentWindowRef.Parent.Navigate(new Profil());
            }
            else
            {
                MessageBox.Show("Email i sifra nisu prepoznati", "Greska");
            }

        }

        
    }
}
