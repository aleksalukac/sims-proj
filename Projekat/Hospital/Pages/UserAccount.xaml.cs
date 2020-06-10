using Hospital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for UserAccount.xaml
    /// </summary>
    public partial class UserAccount : Page
    {

        public UserAccount()
        {
            InitializeComponent();
            ManagerView manager = ManagerView.getInstance();
            nameTextBox.Text = manager.Name;
            surnameTextBox.Text = manager.Surname;
            emailTextBox.Text = manager.Email;
            idLabel.Content = manager.Id.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ManagerView manager = ManagerView.getInstance();

            if (!passwordBox.Password.Equals(confirmedPasswordBox.Password))
            {
                MessageBox.Show("Sifre se ne poklapaju", "Greska");
                return;
            }
            if(confirmedPasswordBox.Password.Length != 0)
            {
                if (confirmedPasswordBox.Password.Length < 6)
                {
                    MessageBox.Show("Sifra je prekratka", "Greska");
                    return;
                }
                manager.Password = Crypt.Encrypt(confirmedPasswordBox.Password);
            }
            manager.Name = nameTextBox.Text;
            manager.Surname = surnameTextBox.Text;

            if (!IsValid(emailTextBox.Text))
            {
                MessageBox.Show("Email nije dobrog formata", "Greska");
                return;
            }

            manager.Email = emailTextBox.Text;
            manager.Name = nameTextBox.Text;
            ManagerView.saveManager();

            var page = new Page();
            NavigationService.Navigate(page);
        }

        public static bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
