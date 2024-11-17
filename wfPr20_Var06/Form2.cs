using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wfPr20_Var06
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;

        Form1 f1;
        public Form2(Form1 f)
        {
            InitializeComponent();
            f1 = f;

            colorDialog1 = new System.Windows.Forms.ColorDialog();
            fontDialog1 = new System.Windows.Forms.FontDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            textBox1.AppendText("КОНТАКТЫ" + Environment.NewLine);
            textBox1.AppendText("Телефон: " + f1.tb_phone.Text + Environment.NewLine);
            textBox1.AppendText("Дополнительный телефон: " + f1.tb_dopphone.Text + Environment.NewLine);
            textBox1.AppendText("Адрес электронной почты: " + f1.tb_email.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);

            textBox1.AppendText("ХРАНИЛИЩЕ ПИСЕМ:" + Environment.NewLine);
            textBox1.AppendText("Входящие:" + Environment.NewLine);
            textBox1.AppendText("Какое письмо: " + f1.lb_input.Text + Environment.NewLine);
            textBox1.AppendText("Количество: " + f1.nud_input.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText("Исходящие:" + Environment.NewLine);
            textBox1.AppendText("Какое письмо: " + f1.lb_output.Text + Environment.NewLine);
            textBox1.AppendText("Количество: " + f1.nud_output.Text + Environment.NewLine);

            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText("РЕДАКЦИЯ" + Environment.NewLine);
            textBox1.AppendText("Название: " + f1.tb_name.Text + Environment.NewLine);
            textBox1.AppendText("Писем на указанную дату: " + f1.nud_date.Text + Environment.NewLine);
            textBox1.AppendText("Писем в заданный населенный пункт: " + f1.nud_route.Text + Environment.NewLine);
            textBox1.AppendText("Груз (посылка): " + (f1.cb_cargo.Checked ? "Да" : "Нет") + Environment.NewLine);
            textBox1.AppendText("Индекс: " + f1.mtb_index.Text + Environment.NewLine);
            textBox1.AppendText("Список населенных пунктов: " + f1.cb_list.Text + Environment.NewLine);
            textBox1.AppendText("Дата: " + f1.dtp_date.Text + Environment.NewLine);

            string warrantyText = "Тип письма: ";
            if (f1.radioButton1.Checked) warrantyText += f1.radioButton1.Text;
            else if (f1.radioButton2.Checked) warrantyText += f1.radioButton2.Text;
            else if (f1.radioButton3.Checked) warrantyText += f1.radioButton3.Text;
            else if (f1.radioButton4.Checked) warrantyText += f1.radioButton4.Text;
            textBox1.AppendText(warrantyText + Environment.NewLine);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //создаем новый файл для записи
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create,
                FileAccess.Write);
                //создаем поток записи
                StreamWriter sw = new StreamWriter(fs);
                //записываем данные
                sw.WriteLine(textBox1.Text);
                //закрываем стримы
                sw.Close();
                fs.Close();
            }
        }

        private void загрузитьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //создаем новый файл для чтения
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open,
                FileAccess.Read);
                //создаем поток чтения
                StreamReader sr = new StreamReader(fs);
                textBox1.Text = sr.ReadToEnd();
                //закрываем стримы
                sr.Close();
                fs.Close();
            }
        }

        private void распечататьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // обработчик события печати
            printDocument1.PrintPage += PrintPageHandler;
            printPreviewDialog1.Document = printDocument1;
            // если в диалоге было нажато ОК
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) printPreviewDialog1.Document.Print();
        }

        // Функция для настройки печати
        private void PrintPageHandler(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Устанавливаем шрифт для печати такой же, как в textBox1
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, 100, 100);
        }

        private void сохранитьВФайлToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //создаем новый файл для записи
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create,
                FileAccess.Write);
                //создаем поток записи
                StreamWriter sw = new StreamWriter(fs);
                //записываем данные
                sw.WriteLine(textBox1.Text);
                //закрываем стримы
                sw.Close();
                fs.Close();
            }
        }

        private void параметрыСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();

            // Установка начальных параметров страницы (необязательно)
            pageSetupDialog.PageSettings = new PageSettings();

            // Отображение диалогового окна и обработка результата
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                // Обработка выбранных пользователем параметров страницы
                // Например, можно получить параметры страницы так:
                PageSettings selectedPageSettings = pageSetupDialog.PageSettings;
                PrinterSettings selectedPrinterSettings = pageSetupDialog.PrinterSettings;

                // Здесь можно добавить код для обработки выбранных параметров страницы
            }
        }

        private void выборПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Здесь можно добавить код для работы с выбранным принтером
                // Например, можно сохранить выбранный принтер в переменную и использовать его для печати
                PrinterSettings printerSettings = printDialog.PrinterSettings;
            }
        }
    }
}