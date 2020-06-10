using System;
using Hospital.Model;
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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace Hospital.Pages
{
    /// <summary>
    /// Interaction logic for ReportPage.xaml
    /// </summary>
    public partial class ReportPage : Page
    {
        public RoomView GetRoom(int id)
        {
            foreach(var room in ProstorijePage.RoomList)
            {
                if (room.Id == id)
                    return room;
            }
            return null;
        }

        public ReportPage()
        {
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

            //Insert a paragraph at the beginning of the document.
            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "Izvestaj o sobama";
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter();

            //Insert a paragraph at the end of the document.
            Word.Paragraph oPara2;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara2.Range.Text = "Klinika NS";
            oPara2.Format.SpaceAfter = 6;
            oPara2.Range.InsertParagraphAfter();

            //Insert another paragraph.
            int roomCount = ProstorijePage.RoomList.Count;
            Word.Paragraph oPara3;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara3.Range.Text = "U bolnici imamo " + roomCount + " soba. Ovo je raspored renoviranja:";
            oPara3.Range.Font.Bold = 0;
            oPara3.Format.SpaceAfter = 24;
            oPara3.Range.InsertParagraphAfter();

            //Insert a 3 x 5 table, fill it with data, and make the first row
            //bold and italic.
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, roomCount, 3, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;
            int r, c;
            string strText;
            for (r = 1; r <= roomCount; r++)
            {
                oTable.Cell(r, 1).Range.Text = GetRoom(r).ToString();
                oTable.Cell(r, 2).Range.Text = GetRoom(r).RoomType;
                oTable.Cell(r, 3).Range.Text = GetRoom(r).Renovation.ToString();
            }


        }
    }
}
