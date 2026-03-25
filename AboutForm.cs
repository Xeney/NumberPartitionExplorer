using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NumberPartitionExplorer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            string message = "Лабораторная работа №1\n" +
                            "Рекурсивные алгоритмы\n\n" +
                            "Вариант 16: Разбиение числа на слагаемые\n\n" +
                            "Выполнил: Варламов Дамир Алексеевич\n" +
                            "Группа: 6105-090301D\n" +
                            "Подгруппа: 1\n\n" +
                            "Самарский университет им. Королёва\n" +
                            "2026";

            lblInfo.Text = message;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
