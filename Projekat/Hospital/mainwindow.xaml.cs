using Hospital.Pages;
using Hospital.Windows;
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

namespace Hospital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void reset_password_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new ResetPasswordWindow();
            nextWindow.Show();
        }

        private void login_Copy2_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new ProblemReportWindow();
            nextWindow.Show();
        }

        private void login_Copy1_Click(object sender, RoutedEventArgs e)
        {
            string password = ManagerView.getInstance().Password;
            

            if(ManagerView.getInstance().Email.Equals(emailBox.Text) && ManagerView.getInstance().Password.Equals(Crypt.Encrypt(passwordBox.Password)))
            {
                var nextPage = new DefaultPage();
                this.Content = nextPage;
            }
            else
            {
                MessageBox.Show("Email i sifra nisu prepoznati", "Greska");
            }

        }

        private void passwordsBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void login_Copy3_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new ResetPasswordWindow();
            nextWindow.Show();
        }
    }
}
