using Controllers;
using Hospital_class_diagram.Controllers;
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
        private TextContentController _textContentController;
        private UserController _userController;

        public ProblemReportWindow()
        {
            _textContentController = (Application.Current as App).TextContentController;
            _userController = (Application.Current as App).UserController;
            InitializeComponent();
        }

        private void login_Copy1_Click(object sender, RoutedEventArgs e)
        {
            TextContent textContent = new TextContent();
            textContent.Text = problemTextBox.Text;
            textContent.Type = TextContentType.feedback;
            textContent.CreatorUser = _userController.GetLoggedUser().Id;

            _textContentController.Add(textContent);
            this.Close();
        }
    }
}
