using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Word = Microsoft.Office.Interop.Word;

namespace CSVSTOViewWordInWPF
{
    /// <summary>
    /// Логика взаимодействия для Documentation.xaml
    /// </summary>
    public partial class Documentation : Window
    {
        int iTotalFields = 0;
        public Documentation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Object oMissing = System.Reflection.Missing.Value;

            Object oTrue = true;
            Object oFalse = false;

            Word.Application oWord = new Word.Application();
            Word.Document oWordDoc = new Word.Document();


            oWord.Visible = true;

            //Object oTemplatePath = System.Windows.Forms.Application.StartupPath+"\\Report.dot";
            Object oTemplate = "D:\\shablon3.dotx";
            oWordDoc = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);

            //Object oTemplatePath = System.Windows.Forms.Application.StartupPath+"\\Report.dot";
            foreach (Word.Field myMergeField in oWordDoc.Fields)
            {
                iTotalFields++;
                Word.Range rngFieldCode = myMergeField.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLength = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    fieldName = fieldName.Trim();

                    if (fieldName == "institut")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(TextBox1.Text);
                    }

                    if (fieldName == "facultet")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(TextBox2.Text);
                    }

                    if (fieldName == "curs")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(TextBox3.Text);
                    }

                    if (fieldName == "grupa")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(TextBox4.Text);
                    }

                    if (fieldName == "disciplina")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(TextBox5.Text);
                    }

                    if (fieldName == "zavkafedri")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(TextBox6.Text);
                    }

                    if (fieldName == "prepodavatel")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(TextBox7.Text);
                    }
                    if (fieldName == "student")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(TextBox8.Text);
                    }
                    if (fieldName == "zachetka")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(TextBox9.Text);
                    }
                }
                oWordDoc.Save();
            }
            oWord.Application.Quit();
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
