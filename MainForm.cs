namespace NumberPartitionExplorer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Обработчик: "О программе"
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Лабораторная работа №1\nРекурсивные алгоритмы\n\n" +
                             "Вариант 16: Разбиение числа на слагаемые\n\n" +
                             "Выполнил: Варламов Дамир Алексеевич\n" +
                             "Группа: 6105-090301D";

            MessageBox.Show(message, "О программе",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }

        // Обработчик: "Задание"
        private void taskMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вариант 16:\n\n" +
                             "Реализуйте рекурсивный алгоритм, распечатывающий " +
                             "различные представления заданного натурального числа N " +
                             "в виде суммы не менее двух натуральных слагаемых. " +
                             "Представления, отличающиеся лишь порядком слагаемых, " +
                             "различными не считаются.";

            MessageBox.Show(message, "Задание",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }

        // Обработчик: "Выход"
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
