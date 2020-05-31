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
    /// Interaction logic for RenoviranjeWindow.xaml
    /// </summary>
    public partial class RenoviranjeWindow : Window
    {
        public RenoviranjeWindow(Zaposlen soba)
        {
            InitializeComponent();
            idLabel.Content = soba.Id;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new AlertWindow("Da li ste sigurni da zelite da zakazete ovo renoviranje?");
            nextWindow.Show();
        }
    }
}
