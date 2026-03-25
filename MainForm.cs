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
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        // Обработчик: "Задание"
        private void taskMenuItem_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.ShowDialog();
        }

        // Обработчик: "Выход"
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
