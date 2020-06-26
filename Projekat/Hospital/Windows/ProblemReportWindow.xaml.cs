using Controllers;
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
    /// Interaction logic for Problem_report.xaml
    /// </summary>
    public partial class ProblemReportWindow : Window
    {
        private ReportController _reportController;

        public ProblemReportWindow()
        {
            _reportController = (Application.Current as App).ReportController;
            InitializeComponent();
        }

        private void login_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Report report = new Report();
            report.Text = problemTextBox.Text;

            _reportController.Add(report);
        }
    }
}
