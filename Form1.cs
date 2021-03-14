using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Drawing.Printing;


namespace Crypto1
{
    public partial class Form1 : Form
    {
        public string stext, alfa;

        static string lat = " abcdefghijklmnopqrstuvwxyz";
        static string ukr = " абвгґдеєжзиійклмнопрстуфхцчшщюяь";
        private string mystr;
        private string code;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void readEnctyptedStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxSource.Visible = true;
            richTextBoxWork.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            buttonexecute.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label2.Visible = true;
            comboBoxKey.Visible = true;
            groupBox1.Visible = false;
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.ShowDialog();
        }

        private void saveEncryptedStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxSource.Visible = true;
            richTextBoxWork.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            buttonexecute.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label2.Visible = true;
            comboBoxKey.Visible = true;

            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            saveFileDialog1.ShowDialog();
            groupBox1.Visible = false;
            MessageBox.Show("File " + saveFileDialog1.FileName + " write!");
        }

        private void printEncryptedStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxSource.Visible = true;
            richTextBoxWork.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            buttonexecute.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label2.Visible = true;
            comboBoxKey.Visible = true;

            // Варіант друку з richTextBoxWork.Text
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(richTextBoxWork.Text);
                documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPageEncrypted);
                documentToPrint.Print();
            }
        }

        private void DocumentToPrint_PrintPageEncrypted(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(richTextBoxWork.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left - 50;
            float TopMargin = e.MarginBounds.Top - 50;
            string Line = null;
            Font PrintFont = this.richTextBoxWork.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }

        //private void newToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    sourceStripMenuItem1.Enabled = false;
        //    encryptedToolStripMenuItem.Enabled = false;
        //    //searchToolStripMenuItem.Enabled = false;
        //    exitToolStripMenuItem.Enabled = false;

        //    richTextBoxSource.Visible = false;
        //    richTextBoxWork.Visible = false;
        //    panel1.Visible = false;
        //    panel2.Visible = false;
        //    buttonexecute.Visible = false;
        //    label4.Visible = false;
        //    label5.Visible = false;
        //    label2.Visible = false;
        //    comboBoxKey.Visible = false;
        //    checkBoxBruteForce.Visible = false;
        //    buttonEncrypted.Visible = false;
        //    //groupBox2.groupBox1 = false;
        //    groupBox1.Location = new Point(300, 150);
        //    groupBox1.Visible = true;

        //}

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            richTextBoxSource.Visible = true;
            richTextBoxWork.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            buttonexecute.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label2.Visible = true;
            comboBoxKey.Visible = true;
            buttonEncrypted.Visible = true;
            checkBoxBruteForce.Visible = true;

            sourceStripMenuItem1.Enabled = true;
            encryptedToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.FilterIndex == 1)
            {
                richTextBoxSource.SaveFile(saveFileDialog2.FileName, RichTextBoxStreamType.PlainText);
                //System.IO.File.WriteAllText(saveFileDialog2.FileName, richTextBoxSource.Text, Encoding.Default);
            }
            else
            {
                richTextBoxSource.SaveFile(saveFileDialog2.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.FilterIndex == 1)
            {
                //stext = System.IO.File.ReadAllText(openFileDialog1.FileName, Encoding.Unicode).Replace("\n", "");
                stext = System.IO.File.ReadAllText(openFileDialog1.FileName, Encoding.Default).Replace("\n", "");
                richTextBoxSource.Text = stext;
            }
            else
            {
                /*
                Word.Application app = new Microsoft.Office.Interop.Word.Application();//процесс ворда
                Object docxFileName = openFileDialog1.FileName;//имя файла
                Object missing = Type.Missing;
                //открыли документ
                app.Documents.Open(ref docxFileName, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing);
                //путь к папке с временными файлами
                string temp = System.IO.Path.GetTempPath();
                //для передачи параметров при пересохранении
                Object lookComments = false;
                Object password = String.Empty;
                Object AddToRecentFiles = true;
                Object WritePassword = String.Empty;
                Object ReadOnlyRecommended = false;
                Object EmbedTrueTypeFonts = false;
                Object SaveFormsData = false;
                Object SaveAsAOCELetter = false;
                //имя файла без расширения
                Object rtfFileName = openFileDialog1.SafeFileName.Substring(0, openFileDialog1.SafeFileName.Length - ".docx".Length);
                //создали рандом
                Random random = new Random();
                //проверяем есть ли файл с таким именем
                while (System.IO.File.Exists(rtfFileName + ".rtf"))
                    //генерируем случайное имя файла
                    rtfFileName += random.Next(0, 9).ToString();
                //формат RTF
                Object wdFormatRTF = Word.WdSaveFormat.wdFormatRTF;
                //приписали расширение
                rtfFileName += ".rtf";
                //приписали путь к временным файлам
                rtfFileName = temp + rtfFileName;
                //пересохранили
                app.ActiveDocument.SaveAs(ref rtfFileName,
                    ref wdFormatRTF, ref lookComments, ref password, ref AddToRecentFiles, ref WritePassword, ref ReadOnlyRecommended,
                    ref EmbedTrueTypeFonts, ref missing, ref SaveFormsData, ref SaveAsAOCELetter, ref missing,
                    ref missing, ref missing, ref missing, ref missing);
                //переменная
                Object @false = false;
                //закрыли текущий документ
                app.ActiveDocument.Close(ref @false, ref missing, ref missing);
                //вышли из ворда
                app.Quit(ref @false, ref missing, ref missing);
                //прочли файл
                richTextBoxSource.LoadFile((String)rtfFileName);
                */

                
                    Object filename = openFileDialog1.FileName;
                    Object confirmConversions = Type.Missing;
                    Object readOnly = Type.Missing;
                    Object addToRecentFiles = Type.Missing;
                    Object passwordDocument = Type.Missing;
                    Object passwordTemplate = Type.Missing;
                    Object revert = Type.Missing;
                    Object writePasswordDocument = Type.Missing;
                    Object writePasswordTemplate = Type.Missing;
                    Object format = Type.Missing;
                    Object encoding = Type.Missing;
                    Object visible = Type.Missing;
                    Object openConflictDocument = Type.Missing;
                    Object openAndRepair = Type.Missing;
                    Object documentDirection = Type.Missing;
                    Object noEncodingDialog = Type.Missing;
                    Word.Application Progr = new Microsoft.Office.Interop.Word.Application();
                    Progr.Documents.Open(ref filename,
                        ref confirmConversions,
                        ref readOnly,
                        ref addToRecentFiles,
                        ref passwordDocument,
                        ref passwordTemplate,
                        ref revert,
                        ref writePasswordDocument,
                        ref writePasswordTemplate,
                        ref format,
                        ref encoding,
                        ref visible,
                        ref openConflictDocument,
                        ref openAndRepair,
                        ref documentDirection,
                        ref noEncodingDialog);
                    Word.Document Doc = new Microsoft.Office.Interop.Word.Document();
                    Doc = Progr.Documents.Application.ActiveDocument;
                    object start = 0;
                    object stop = Doc.Characters.Count;
                    Word.Range Rng = Doc.Range(ref start, ref stop);
                    string Result = Rng.Text;
                    object sch = Type.Missing;
                    object aq = Type.Missing;
                    object ab = Type.Missing;
                    Progr.Quit(ref sch, ref aq, ref ab);
                    richTextBoxSource.Text = Result;
                    
            }

        }

        private void readSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxSource.Visible = true;
            richTextBoxWork.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            buttonexecute.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label2.Visible = true;
            comboBoxKey.Visible = true;
            groupBox1.Visible = false;
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.ShowDialog();
        }

        private void saveSourceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxSource.Visible = true;
            richTextBoxWork.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            buttonexecute.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label2.Visible = true;
            comboBoxKey.Visible = true;
            saveFileDialog2.FileName = "";
            saveFileDialog2.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            saveFileDialog2.ShowDialog();

            groupBox1.Visible = false;
            MessageBox.Show("File " + saveFileDialog2.FileName + " write!");
        }
        private void printSourceStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxSource.Visible = true;
            richTextBoxWork.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            buttonexecute.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label2.Visible = true;
            comboBoxKey.Visible = true;

            // Варіант друку з richTextBoxSource.Text
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(richTextBoxSource.Text);
                documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
                documentToPrint.Print();
            }
        }
        private void DocumentToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(richTextBoxSource.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left - 50;
            float TopMargin = e.MarginBounds.Top - 50;
            string Line = null;
            Font PrintFont = this.richTextBoxSource.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.FilterIndex == 1)
            {
                richTextBoxWork.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);                
            }
            else
            {
                richTextBoxWork.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void radioButtonUkr_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxKey.Text = "";
            if (radioButtonLat.Checked == true)
                alfa = lat;
            else
                alfa = ukr;
            comboBoxKey.Items.Clear();
            for (int i = 1; i < alfa.Length; i++)
            {
                comboBoxKey.Items.Add(i);
            }
        }

        private void radioButtonLat_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxKey.Text = "";
            if (radioButtonLat.Checked == true)
                alfa = lat;
            else
                alfa = ukr;
            comboBoxKey.Items.Clear();
            for (int i = 1; i < alfa.Length; i++)
            {
                comboBoxKey.Items.Add(i);
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog2.FilterIndex == 1)
            {
                stext = System.IO.File.ReadAllText(openFileDialog2.FileName, Encoding.Default).Replace("\n", "");
                richTextBoxWork.Text = stext;
            }
            else
            {
                Object filename = openFileDialog2.FileName;
                Object confirmConversions = Type.Missing;
                Object readOnly = Type.Missing;
                Object addToRecentFiles = Type.Missing;
                Object passwordDocument = Type.Missing;
                Object passwordTemplate = Type.Missing;
                Object revert = Type.Missing;
                Object writePasswordDocument = Type.Missing;
                Object writePasswordTemplate = Type.Missing;
                Object format = Type.Missing;
                Object encoding = Type.Missing;
                Object visible = Type.Missing;
                Object openConflictDocument = Type.Missing;
                Object openAndRepair = Type.Missing;
                Object documentDirection = Type.Missing;
                Object noEncodingDialog = Type.Missing;
                Word.Application Progr = new Microsoft.Office.Interop.Word.Application();
                Progr.Documents.Open(ref filename,
                    ref confirmConversions,
                    ref readOnly,
                    ref addToRecentFiles,
                    ref passwordDocument,
                    ref passwordTemplate,
                    ref revert,
                    ref writePasswordDocument,
                    ref writePasswordTemplate,
                    ref format,
                    ref encoding,
                    ref visible,
                    ref openConflictDocument,
                    ref openAndRepair,
                    ref documentDirection,
                    ref noEncodingDialog);
                Word.Document Doc = new Microsoft.Office.Interop.Word.Document();
                Doc = Progr.Documents.Application.ActiveDocument;
                object start = 0;
                object stop = Doc.Characters.Count;
                Word.Range Rng = Doc.Range(ref start, ref stop);
                string Result = Rng.Text;
                object sch = Type.Missing;
                object aq = Type.Missing;
                object ab = Type.Missing;
                Progr.Quit(ref sch, ref aq, ref ab);
                richTextBoxWork.Text = Result;
            }
        }

        //щоб не писалося руками ключ
        private void comboBoxKey_TextChanged(object sender, EventArgs e)
        {
                comboBoxKey.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxKey.Text = "";
            if (checkBoxBruteForce.Checked == true)
            {
                radioButtonEncrypted.Checked = true;
                buttonEncrypted.Enabled = true;
            }
            else
            {
                radioButtonCrypted.Checked = true;
                buttonEncrypted.Enabled = false;

            }
        }

        private void buttonEncrypted_Click(object sender, EventArgs e)
        {
            if (richTextBoxWork.Text == "")
            { 
                MessageBox.Show("Encrypted text is empty !");
                return;
            }
            if (radioButtonLat.Checked == true)
                alfa = lat;
            else
                alfa = ukr;

            int shift = 1;
            while (shift < alfa.Length)
            {
                mystr = richTextBoxWork.Text;
                int a;
                code = string.Empty;
                for (int i = 0; i < mystr.Length; i++)
                {
                    //int pos;
                    char c = mystr[i];
                    if (!alfa.Contains(c))
                    {
                        code = code + c;
                        continue;
                    }
                    int pos = alfa.IndexOf(c);
                    //MessageBox.Show("Pos " + Convert.ToString(pos) + " !");
                    a = pos - shift;

                    if (a < 0)
                        //if (a > alfa.Length - 1)
                        a = a + alfa.Length;
                    //MessageBox.Show("a " + Convert.ToString(a) + " !");
                    //MessageBox.Show("Str " + alfa[a] + " !");

                    code = code + alfa[a];
                }

                richTextBoxSource.Text = code;

                string message = "Key is " + Convert.ToString(shift) + ". Is the text decrypted?";
                const string caption = "Frute Force";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    break;
                }

                shift = shift + 1;
            }
            radioButtonCrypted.Checked = true;
            checkBoxBruteForce.Checked = false;
            buttonEncrypted.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sourceStripMenuItem1.Enabled = false;
            encryptedToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = false;
            richTextBoxSource.Visible = false;
            richTextBoxWork.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            buttonexecute.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label2.Visible = false;
            comboBoxKey.Visible = false;
            checkBoxBruteForce.Visible = false;
            buttonEncrypted.Visible = false;
            groupBox1.Location = new Point(300, 150);
            groupBox1.Visible = true;
        }

        private void buttonexecute_Click(object sender, EventArgs e)
        {
            
            if (richTextBoxSource.Text == "" && radioButtonCrypted.Checked == true)
            {
                MessageBox.Show("Empty Source Text!");
                return;
            }

            if (richTextBoxWork.Text == "" && radioButtonEncrypted.Checked == true)
            {
                MessageBox.Show("Empty Encrypted Text!");
                return;
            }

            if (comboBoxKey.Text == "")
            {
                MessageBox.Show("Choose Key!");
                return;
            }            
            if (radioButtonLat.Checked == true)
                alfa = lat;
            else
                alfa = ukr;

            int count = 0;
            mystr = richTextBoxSource.Text;
            for (int i = 0; i < mystr.Length; i++)
            {
                char d = mystr[i];
                if (alfa.Contains(d) && Convert.ToString(d) != " ")
                {
                    count = count + 1;
                    continue;
                }
            }
            if (count == 0 && radioButtonCrypted.Checked == true)
            {
                MessageBox.Show("Source Text without letters!");
                return;
            }
            if (radioButtonCrypted.Checked == true)
            {
                mystr = richTextBoxSource.Text;
                //MessageBox.Show("Alfa.Length" + Convert.ToString(alfa.Length) + " !");
                //MessageBox.Show("Key " + Convert.ToString(comboBoxKey.SelectedItem) + " !");
                int a;
                code = string.Empty;
                for (int i = 0; i < mystr.Length; i++)
                {
                    int pos;
                    char c = mystr[i];
                    if (!alfa.Contains(c))
                    {
                        code = code + c;
                        continue;
                    }
                    pos = alfa.IndexOf(c);
                    //MessageBox.Show("Pos " + Convert.ToString(pos) + " !");
                    a = pos + Convert.ToInt32(comboBoxKey.SelectedItem); //Convert.ToInt32(comboBoxKey.SelectedItem) - key

                    if (a > alfa.Length - 1)
                        a = a - alfa.Length;
                    //MessageBox.Show("a " + Convert.ToString(a) + " !");
                    //MessageBox.Show("Str " + alfa[a] + " !");
                    
                    code = code + alfa[a];
                }

                richTextBoxWork.Text = code;
            }

            if (radioButtonCrypted.Checked == false)
            {
                mystr = richTextBoxWork.Text;
                //MessageBox.Show("Alfa.Length" + Convert.ToString(alfa.Length) + " !");
                //MessageBox.Show("Key " + Convert.ToString(comboBoxKey.SelectedItem) + " !");
                int a;
                code = string.Empty;
                for (int i = 0; i < mystr.Length; i++)
                {
                    int pos;
                    char c = mystr[i];
                    if (!alfa.Contains(c))
                    {
                        code = code + c;
                        continue;
                    }
                    pos = alfa.IndexOf(c);
                    //MessageBox.Show("Pos " + Convert.ToString(pos) + " !");
                    a = pos - Convert.ToInt32(comboBoxKey.SelectedItem);

                    if (a < 0)
                    //if (a > alfa.Length - 1)
                        a = a + alfa.Length;
                    //MessageBox.Show("a " + Convert.ToString(a) + " !");
                    //MessageBox.Show("Str " + alfa[a] + " !");

                    code = code + alfa[a];
                }

                richTextBoxSource.Text = code;
            }
        }
    }
}
