using Hospital.Model;
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

namespace Hospital.Pages
{
    /// <summary>
    /// Interaction logic for AddDoctorPage.xaml
    /// </summary>
    public partial class AddDoctorPage : Page
    {
        public AddDoctorPage(int id)
        {
            InitializeComponent();
            idLabel.Content = (id).ToString();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            DoctorView lekar = new DoctorView();
            lekar.Name = this.imeTextBox.Text;
            lekar.Surname = this.prezimeTextBox.Text;
            lekar.Specialisation = this.specijalizacijaTextBox.Text;
            if (lekar.Name.Length == 0 || lekar.Surname.Length == 0)
            {
                System.Windows.MessageBox.Show("Niste uneli adekvatno ime lekara.");
                return;
            }


                ZaposleniPage.AddDoctor(lekar);
            System.Windows.MessageBox.Show("Uspešno ste sačuvali informacije.");

            NavigationService.Navigate(new Page());
        }
    }
}
