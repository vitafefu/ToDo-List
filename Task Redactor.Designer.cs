namespace ToDo_List
{
    partial class TaskRedactor
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
            panel1 = new Panel();
            TaskLabel = new Label();
            panel2 = new Panel();
            TaskBox = new TextBox();
            Cancel = new Button();
            TitleBox = new TextBox();
            AddButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 34, 245);
            panel1.Controls.Add(TaskLabel);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 64);
            panel1.TabIndex = 0;
            // 
            // TaskLabel
            // 
            TaskLabel.BackColor = Color.FromArgb(195, 201, 249);
            TaskLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TaskLabel.ForeColor = SystemColors.Window;
            TaskLabel.Location = new Point(12, 9);
            TaskLabel.Name = "TaskLabel";
            TaskLabel.Size = new Size(410, 49);
            TaskLabel.TabIndex = 4;
            TaskLabel.Text = "Task Redactor";
            TaskLabel.TextAlign = ContentAlignment.MiddleCenter;
            TaskLabel.MouseDown += TaskRedactor_MouseDown;
            TaskLabel.MouseMove += TaskRedactor_MouseMove;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 435);
            panel2.TabIndex = 1;
            // 
            // TaskBox
            // 
            TaskBox.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            TaskBox.Location = new Point(103, 147);
            TaskBox.Multiline = true;
            TaskBox.Name = "TaskBox";
            TaskBox.Size = new Size(319, 337);
            TaskBox.TabIndex = 1;
            TaskBox.Enter += TaskBox_Enter;
            TaskBox.Leave += TaskBox_Leave;
            // 
            // Cancel
            // 
            Cancel.Cursor = Cursors.Hand;
            Cancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Cancel.Location = new Point(12, 447);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(85, 37);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // TitleBox
            // 
            TitleBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            TitleBox.Location = new Point(103, 83);
            TitleBox.Multiline = true;
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(319, 49);
            TitleBox.TabIndex = 3;
            TitleBox.Enter += TitleBox_Enter;
            TitleBox.Leave += TitleBox_Leave;
            // 
            // AddButton
            // 
            AddButton.Cursor = Cursors.Hand;
            AddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(12, 404);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(85, 37);
            AddButton.TabIndex = 4;
            AddButton.Text = "Save";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            AddButton.MouseEnter += AddButton_MouseEnter;
            AddButton.MouseLeave += AddButton_MouseLeave;
            // 
            // TaskRedactor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 221, 150);
            ClientSize = new Size(434, 496);
            Controls.Add(AddButton);
            Controls.Add(TitleBox);
            Controls.Add(Cancel);
            Controls.Add(TaskBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaskRedactor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task_Redactor";
            MouseDown += TaskRedactor_MouseDown;
            MouseMove += TaskRedactor_MouseMove;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox TaskBox;
        private Button Cancel;
        private TextBox TitleBox;
        public Label TaskLabel;
        private Button AddButton;
    }
}