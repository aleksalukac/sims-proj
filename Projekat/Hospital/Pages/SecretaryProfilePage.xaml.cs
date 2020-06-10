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
    /// Interaction logic for SecretaryProfilePage.xaml
    /// </summary>
    public partial class SecretaryProfilePage : Page
    {
        public SecretaryProfilePage(EmployeeView secretary)
        {
            InitializeComponent();
            imeTextBox.Text = secretary.Name;
            prezimeTextBox.Text = secretary.Surname;
            emailTextBox.Text = secretary.Email;
            workBeginTextBox.Text = secretary.StartWorkingHours.ToString();
            workEndTextBox.Text = secretary.EndWorkingHours.ToString();
            idLabel.Content = secretary.Id.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var doctor = ZaposleniPage.SecretaryList.Where(x => x.Id == Int32.Parse(idLabel.Content.ToString())).FirstOrDefault();

            doctor.Name = imeTextBox.Text;
            doctor.Surname = prezimeTextBox.Text;
            doctor.Email = emailTextBox.Text;
            doctor.StartWorkingHours = (uint)Int32.Parse(workBeginTextBox.Text);
            doctor.EndWorkingHours = (uint)Int32.Parse(workEndTextBox.Text);

            NavigationService.Navigate(new Page());
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
