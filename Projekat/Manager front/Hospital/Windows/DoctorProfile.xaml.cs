using Hospital.Model;
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
using System.Windows.Shapes;

namespace Hospital.Windows
{
    /// <summary>
    /// Interaction logic for DoctorProfile.xaml
    /// </summary>
    public partial class DoctorProfile : Window
    {
        public DoctorProfile(Zaposlen zaposlen)
        {
            InitializeComponent();
            imeTextBox.Text = zaposlen.Ime;
            prezimeTextBox.Text = zaposlen.Prezime;
            specijalizacijaTextBox.Text = zaposlen.Ostalo;
            idLabel.Content = zaposlen.Id.ToString();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new AlertWindow("Da li ste sigurni da zelite da date otkaz ovom lekaru?");
            nextWindow.Show();
        }
    }
}
