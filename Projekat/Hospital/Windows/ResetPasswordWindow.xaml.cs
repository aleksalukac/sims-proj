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
using System.Windows.Shapes;

namespace Hospital.Windows
{
    /// <summary>
    /// Interaction logic for ResetPasswordWindow.xaml
    /// </summary>
    public partial class ResetPasswordWindow : Window
    {
        public ResetPasswordWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (emailTextbox.Text.ToUpper().Equals(ManagerView.getInstance().Email.ToUpper()))
            {
                ManagerView.resetPassword();
            }
            this.Close();
        }
    }
}
