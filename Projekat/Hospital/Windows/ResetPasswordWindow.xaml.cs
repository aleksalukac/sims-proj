using Controllers;
using Hospital.ViewModel;
using Hospital_class_diagram.Crypt;
using Model;
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
using System.Windows.Shapes;

namespace Hospital.Windows
{
    /// <summary>
    /// Interaction logic for ResetPasswordWindow.xaml
    /// </summary>
    public partial class ResetPasswordWindow : Window
    {
        private UserController _userController;

        public ResetPasswordWindow()
        {
            _userController = (Application.Current as App).UserController;
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string email = emailTextbox.Text;
            User user = _userController.GetByEmail(email);

            if(user == null)
            {
                System.Windows.MessageBox.Show("Email nije pronadjen.");
                return;
            }

            user.Password = Crypt.Encrypt("");

            _userController.Update(user);

            this.Close();
        }
    }
}
