using NumberPartitionExplorer.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NumberPartitionExplorer
{
    public partial class TaskForm : Form
    {
        private PartitionLogic _logic;
        private const int MaxTraceSize = 1000;

        public TaskForm()
        {
            InitializeComponent();
            _logic = new PartitionLogic(MaxTraceSize);
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            txtTask.Text = "Вариант 16:\nРеализуйте рекурсивный алгоритм, распечатывающий " +
                          "различные представления заданного натурального числа N " +
                          "в виде суммы не менее двух натуральных слагаемых. " +
                          "Представления, отличающиеся лишь порядком слагаемых, " +
                          "различными не считаются.";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int n;
            bool isValid = InputValidator.ValidateNumber(txtInput.Text, out n);

            if (isValid)
            {
                _logic.FindPartitions(n);
                txtOutput.Text = _logic.GetResults();
                ShowTrace(_logic.GetTrace(), _logic.GetTraceCount());
            }
            else
            {
                MessageBox.Show(InputValidator.GetErrorMessage(), "Ошибка ввода",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOutput.Text = "";
                txtTrace.Text = "";
            }
        }

        private void ShowTrace(TraceEntry[] trace, int count)
        {
            string traceText = "Уровень\tОстаток\tМин.слагаемое\tБуфер\tДействие\r\n";
            traceText += "-------\t-------\t-------------\t-------\t--------\r\n";

            int i = 0;
            int limit = count;
            if (limit > 50)
            {
                limit = 50;
            }

            while (i < limit)
            {
                traceText += trace[i].Level + "\t" +
                            trace[i].Remaining + "\t" +
                            trace[i].MinSummand + "\t" +
                            trace[i].CurrentPartition + "\t" +
                            trace[i].Action + "\r\n";
                i = i + 1;
            }

            if (count > 50)
            {
                traceText += "\r\n... (показано 50 из " + count + " шагов)";
            }

            txtTrace.Text = traceText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}