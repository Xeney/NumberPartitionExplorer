namespace NumberPartitionExplorer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            aboutMenuItem = new ToolStripMenuItem();
            taskMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            lblInput = new Label();
            txtInput = new TextBox();
            btnCalculate = new Button();
            txtOutput = new TextBox();
            txtTrace = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutMenuItem, taskMenuItem, exitMenuItem });
            menuStrip1.Location = new Point(9, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(220, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new Size(94, 20);
            aboutMenuItem.Text = "О программе";
            aboutMenuItem.Click += aboutMenuItem_Click;
            // 
            // taskMenuItem
            // 
            taskMenuItem.Name = "taskMenuItem";
            taskMenuItem.Size = new Size(64, 20);
            taskMenuItem.Text = "Задание";
            taskMenuItem.Click += taskMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(54, 20);
            exitMenuItem.Text = "Выход";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(29, 83);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(200, 15);
            lblInput.TabIndex = 1;
            lblInput.Text = "Введите натуральное число N (>1):";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(235, 80);
            txtInput.MaxLength = 10;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(124, 23);
            txtInput.TabIndex = 2;
            txtInput.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(269, 109);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(90, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtOutput.Location = new Point(365, 80);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(194, 161);
            txtOutput.TabIndex = 4;
            // 
            // txtTrace
            // 
            txtTrace.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtTrace.Location = new Point(565, 80);
            txtTrace.Multiline = true;
            txtTrace.Name = "txtTrace";
            txtTrace.ReadOnly = true;
            txtTrace.ScrollBars = ScrollBars.Both;
            txtTrace.Size = new Size(194, 161);
            txtTrace.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 347);
            Controls.Add(txtTrace);
            Controls.Add(txtOutput);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(797, 386);
            MinimumSize = new Size(797, 386);
            Name = "MainForm";
            Text = "NumberPartitionExplorer";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutMenuItem;
        private ToolStripMenuItem taskMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private Label lblInput;
        private TextBox txtInput;
        private Button btnCalculate;
        private TextBox txtOutput;
        private TextBox txtTrace;
    }
}
