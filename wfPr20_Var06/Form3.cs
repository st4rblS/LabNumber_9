using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace wfPr20_Var06
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "n_letterDBDataSet.Sender". При необходимости она может быть перемещена или удалена.
            this.senderTableAdapter.Fill(this.n_letterDBDataSet.Sender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "n_letterDBDataSet.Recipient". При необходимости она может быть перемещена или удалена.
            this.recipientTableAdapter.Fill(this.n_letterDBDataSet.Recipient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "n_letterDBDataSet.Recipient". При необходимости она может быть перемещена или удалена.
            this.recipientTableAdapter.Fill(this.n_letterDBDataSet.Recipient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "n_letterDBDataSet.Sender". При необходимости она может быть перемещена или удалена.
            this.senderTableAdapter.Fill(this.n_letterDBDataSet.Sender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "n_letterDBDataSet.Recipient". При необходимости она может быть перемещена или удалена.
            this.recipientTableAdapter.Fill(this.n_letterDBDataSet.Recipient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "n_letterDBDataSet.Letter". При необходимости она может быть перемещена или удалена.
            this.letterTableAdapter.Fill(this.n_letterDBDataSet.Letter);

        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            letterBindingSource.EndEdit();
            letterTableAdapter.Update(n_letterDBDataSet);
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            recipientBindingSource.EndEdit();
            recipientTableAdapter.Update(n_letterDBDataSet);
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            senderBindingSource.EndEdit();
            senderTableAdapter.Update(n_letterDBDataSet);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;
            printPreviewDialog.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            DataGridViewCellCollection cells = row.Cells;

            string dataToPrint = "";

            foreach (DataGridViewCell cell in cells)
            {
                dataToPrint += cell.Value.ToString() + "\t"; // добавляем значение ячейки и табуляцию
            }

            e.Graphics.DrawString(dataToPrint, new Font("Arial", 12), Brushes.Black, 100, 100);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Отображаем диалоговое окно с вопросом о завершении работы программы
                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Завершение работы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Если пользователь подтверждает желание завершить работу, закрываем форму
                if (result == DialogResult.Yes)
                {
                    // Закрываем главную форму
                    e.Cancel = false;
                }
                else
                {
                    // Отменяем закрытие формы
                    e.Cancel = true;
                }
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Файлы Word (*.doc; *.docx)|*.doc?";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Экспорт в Word
                    string fn = System.IO.Directory.GetCurrentDirectory() + "\\letter_record.docx";
                    int r = dataGridView2.CurrentCell.RowIndex;
                    var Recipient_Code = dataGridView2.Rows[r].Cells[0].FormattedValue.ToString();
                    var Recipient_Surname = dataGridView2.Rows[r].Cells[1].FormattedValue.ToString();
                    var Recipient_Name = dataGridView2.Rows[r].Cells[2].FormattedValue.ToString();
                    var Recipient_Lastname = dataGridView2.Rows[r].Cells[3].FormattedValue.ToString();
                    var Recipient_PhoneNumber = dataGridView2.Rows[r].Cells[4].FormattedValue.ToString();

                    Word.Application wordApp = new Word.Application();
                    wordApp.Visible = false;
                    Word.Document wordDocument = wordApp.Documents.Open(fn);

                    ReplaceWordStub("{Recipient_Code}", Recipient_Code, wordDocument);
                    ReplaceWordStub("{Recipient_Surname}", Recipient_Surname, wordDocument);
                    ReplaceWordStub("{Recipient_Name}", Recipient_Name, wordDocument);
                    ReplaceWordStub("{Recipient_Lastname}", Recipient_Lastname, wordDocument);
                    ReplaceWordStub("{Recipient_PhoneNumber}", Recipient_PhoneNumber, wordDocument);

                    wordDocument.SaveAs2(sd.FileName);
                    wordApp.Quit();

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при экспорте в Word: " + ex.Message);
                }
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document
        wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Экспорт в Excel
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Файлы Word (*.xls; *.xlsx)|*.xls?";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = workbook.ActiveSheet;

                    excelApp.Visible = false;

                    for (int i = 1; i < dataGridView1.RowCount + 1; i++)
                        for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                            worksheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].FormattedValue;

                    excelApp.AlertBeforeOverwriting = false;
                    excelApp.DisplayAlerts = false;
                    workbook.SaveAs(sd.FileName);
                    excelApp.Quit();

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при экспорте в Excel: " + ex.Message);
                }
            }
        }
    }
}