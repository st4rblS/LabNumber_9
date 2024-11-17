using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPr20_Var06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void вызовСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Данная функция программы временно не реализована…",
            "Внимание"
,
            MessageBoxButtons.OK,
            MessageBoxIcon.Hand,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
        }

        private void toolStripComboBox1_CLick(object sender, EventArgs e)
        {
            string selectedItem = toolStripComboBox1.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Сверху":
                    toolStrip1.Visible = true;
                    toolStrip1.Dock = DockStyle.Top;
                    break;
                case "Снизу":
                    toolStrip1.Visible = true;
                    toolStrip1.Dock = DockStyle.Bottom;
                    break;
                case "Слева":
                    toolStrip1.Visible = true;
                    toolStrip1.Dock = DockStyle.Left;
                    break;
                case "Справа":
                    toolStrip1.Visible = true;
                    toolStrip1.Dock = DockStyle.Right;
                    break;
                case "Не отображать":
                    toolStrip1.Visible = false;
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnDB_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}