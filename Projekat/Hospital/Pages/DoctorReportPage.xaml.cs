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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Model;
using Controllers;
using iTextSharp.text;

namespace Hospital.Pages
{
    /// <summary>
    /// Interaction logic for DoctorReportPage.xaml
    /// </summary>
    public partial class DoctorReportPage : Page
    {
        private DoctorController _doctorController;
        private ReportController _reportController;
        private UserController _userController;

        public DoctorReportPage()
        {
            _doctorController = (Application.Current as App).DoctorController;
            _reportController = (Application.Current as App).ReportController;
            _userController = (Application.Current as App).UserController;

            InitializeComponent();
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);

            string documentText = "";

            //Insert a paragraph at the beginning of the document.
            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "Izveštaj o lekarima - Upravnik";
            documentText += oPara1.Range.Text;
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter();

            //Insert a paragraph at the end of the document.
            Word.Paragraph oPara2;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara2.Format.SpaceAfter = 6;
            oPara2.Range.InsertParagraphAfter();

            //Insert another paragraph.
            Word.Paragraph oPara3;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara3.Range.Text = "U našoj klinici postoji " + EmployeesPage.DoctorList.Count + " lekara.";
            documentText += "\n" + oPara3.Range.Text;
            oPara3.Range.Font.Bold = 0;
            oPara3.Format.SpaceAfter = 24;
            oPara3.Range.InsertParagraphAfter();

            //Insert a 3 x 5 table, fill it with data, and make the first row
            //bold and italic.
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, EmployeesPage.DoctorList.Count, 5, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;
            int r, c;
            string strText;

            oTable.Cell(1, 1).Range.Text = "Id";
            documentText += oTable.Cell(1, 1).Range.Text;

            oTable.Cell(1, 2).Range.Text = "Ime i prezime";
            documentText += " " + oTable.Cell(1, 2).Range.Text;

            oTable.Cell(1, 3).Range.Text = "Specijalizacija";
            documentText += " " + oTable.Cell(1, 3).Range.Text;

            oTable.Cell(1, 4).Range.Text = "Broj pregleda";
            documentText += " " + oTable.Cell(1, 4).Range.Text;

            oTable.Cell(1, 5).Range.Text = "Broj lekova za odobravanje";
            documentText += " " + oTable.Cell(1, 5).Range.Text;

            for (r = 2; r < EmployeesPage.DoctorList.Count + 2; r++)
            {
                Doctor doctor = _doctorController.Get((int)EmployeesPage.DoctorList[r - 2].Id);

                strText = doctor.Id.ToString();
                documentText += "\n" + strText;
                oTable.Cell(r, 1).Range.Text = strText;

                strText = EmployeesPage.DoctorList[r - 2].Name + " " + EmployeesPage.DoctorList[r - 2].Surname;
                documentText += " " + strText;
                oTable.Cell(r, 2).Range.Text = strText;

                strText = EmployeesPage.DoctorList[r - 2].Specialisation;
                documentText += " " + strText;
                oTable.Cell(r, 3).Range.Text = strText;


                strText = doctor.medicalExam.Count.ToString();
                documentText += " " + strText;
                oTable.Cell(r, 4).Range.Text = strText;

                strText = doctor.Notification.Count.ToString();
                documentText += " " + strText;
                oTable.Cell(r, 5).Range.Text = strText;
            }
            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.Font.Italic = 1;

            _reportController.Add(_userController.GetLoggedUser().Id, documentText);

        }
    }
}
