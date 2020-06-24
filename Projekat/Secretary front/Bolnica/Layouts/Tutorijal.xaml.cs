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
    /// Interaction logic for Tutorijal.xaml
    /// </summary>
    public partial class Tutorijal : Page
    {

        public Tutorijal( )
        {
            InitializeComponent();
            
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Profil());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            video.Play();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            video.Pause();
        }

    }
}
