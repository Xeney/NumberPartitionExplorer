namespace NumberPartitionExplorer
{
    partial class AboutForm
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
            lblInfo = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblInfo.Location = new Point(0, 38);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(800, 413);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "label1";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(713, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Выход";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(lblInfo);
            Name = "AboutForm";
            Text = "AboutForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblInfo;
        private Button btnClose;
    }
}