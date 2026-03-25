namespace NumberPartitionExplorer
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInput = new Label();
            txtInput = new TextBox();
            btnCalculate = new Button();
            txtOutput = new TextBox();
            btnClose = new Button();
            txtTask = new TextBox();
            txtTrace = new TextBox();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(18, 63);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(65, 15);
            lblInput.TabIndex = 1;
            lblInput.Text = "Введите N:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(89, 60);
            txtInput.MaxLength = 10;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(133, 23);
            txtInput.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(133, 89);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(89, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(228, 60);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(125, 235);
            txtOutput.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(713, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 6;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtTask
            // 
            txtTask.BorderStyle = BorderStyle.None;
            txtTask.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtTask.Location = new Point(18, 336);
            txtTask.Multiline = true;
            txtTask.Name = "txtTask";
            txtTask.ReadOnly = true;
            txtTask.Size = new Size(770, 89);
            txtTask.TabIndex = 7;
            txtTask.Text = "Вариант 16:...";
            // 
            // txtTrace
            // 
            txtTrace.Location = new Point(359, 60);
            txtTrace.Multiline = true;
            txtTrace.Name = "txtTrace";
            txtTrace.ReadOnly = true;
            txtTrace.ScrollBars = ScrollBars.Both;
            txtTrace.Size = new Size(429, 235);
            txtTrace.TabIndex = 5;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTask);
            Controls.Add(btnClose);
            Controls.Add(txtTrace);
            Controls.Add(txtOutput);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Name = "TaskForm";
            Text = "TaskForm";
            Load += TaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblInput;
        private TextBox txtInput;
        private Button btnCalculate;
        private TextBox txtOutput;
        private Button btnClose;
        private TextBox txtTask;
        private TextBox txtTrace;
    }
}