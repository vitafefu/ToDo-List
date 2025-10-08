namespace ToDo_List
{
    partial class ToDoList
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
            Topp = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            Exit = new Button();
            DeleteTask = new Button();
            ChangeTask = new Button();
            AddTask = new Button();
            TasksPanel = new FlowLayoutPanel();
            Topp.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Topp
            // 
            Topp.BackColor = Color.FromArgb(7, 34, 245);
            Topp.Controls.Add(label1);
            Topp.Controls.Add(panel1);
            Topp.Dock = DockStyle.Top;
            Topp.Location = new Point(0, 0);
            Topp.Name = "Topp";
            Topp.Size = new Size(940, 69);
            Topp.TabIndex = 0;
            Topp.MouseDown += Table_MouseDown;
            Topp.MouseMove += Table_MouseMove;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(195, 201, 249);
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(916, 46);
            label1.TabIndex = 2;
            label1.Text = "ToDo List";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.MouseDown += Table_MouseDown;
            label1.MouseMove += Table_MouseMove;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(117, 133, 251);
            panel1.Location = new Point(0, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 410);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(117, 133, 251);
            panel2.Controls.Add(Exit);
            panel2.Controls.Add(DeleteTask);
            panel2.Controls.Add(ChangeTask);
            panel2.Controls.Add(AddTask);
            panel2.Location = new Point(12, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 500);
            panel2.TabIndex = 1;
            panel2.MouseDown += Table_MouseDown;
            panel2.MouseMove += Table_MouseMove;
            // 
            // Exit
            // 
            Exit.Cursor = Cursors.Hand;
            Exit.Font = new Font("Segoe UI", 14F);
            Exit.Location = new Point(21, 434);
            Exit.Name = "Exit";
            Exit.Size = new Size(164, 55);
            Exit.TabIndex = 4;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            Exit.MouseEnter += Exit_MouseEnter;
            Exit.MouseLeave += Exit_MouseLeave;
            // 
            // DeleteTask
            // 
            DeleteTask.Cursor = Cursors.Hand;
            DeleteTask.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeleteTask.Location = new Point(21, 93);
            DeleteTask.Name = "DeleteTask";
            DeleteTask.Size = new Size(164, 55);
            DeleteTask.TabIndex = 2;
            DeleteTask.Text = "Delete Task";
            DeleteTask.UseVisualStyleBackColor = true;
            DeleteTask.MouseClick += DeleteTask_MouseClick;
            DeleteTask.MouseEnter += DeleteTask_MouseEnter;
            DeleteTask.MouseLeave += DeleteTask_MouseLeave;
            // 
            // ChangeTask
            // 
            ChangeTask.Cursor = Cursors.Hand;
            ChangeTask.Font = new Font("Segoe UI", 14F);
            ChangeTask.Location = new Point(21, 164);
            ChangeTask.Name = "ChangeTask";
            ChangeTask.Size = new Size(164, 55);
            ChangeTask.TabIndex = 3;
            ChangeTask.Text = "Change Task";
            ChangeTask.UseVisualStyleBackColor = true;
            ChangeTask.MouseClick += ChangeTask_MouseClick;
            ChangeTask.MouseEnter += ChangeTask_MouseEnter;
            ChangeTask.MouseLeave += ChangeTask_MouseLeave;
            // 
            // AddTask
            // 
            AddTask.Cursor = Cursors.Hand;
            AddTask.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddTask.Location = new Point(21, 18);
            AddTask.Name = "AddTask";
            AddTask.Size = new Size(164, 55);
            AddTask.TabIndex = 2;
            AddTask.Text = "Add Task";
            AddTask.UseVisualStyleBackColor = true;
            AddTask.MouseClick += AddTask_MouseClick;
            AddTask.MouseEnter += AddTask_MouseEnter;
            AddTask.MouseLeave += AddTask_MouseLeave;
            // 
            // TasksPanel
            // 
            TasksPanel.AutoScroll = true;
            TasksPanel.BackColor = Color.FromArgb(255, 115, 5);
            TasksPanel.FlowDirection = FlowDirection.TopDown;
            TasksPanel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            TasksPanel.Location = new Point(230, 88);
            TasksPanel.Name = "TasksPanel";
            TasksPanel.Size = new Size(698, 500);
            TasksPanel.TabIndex = 2;
            TasksPanel.WrapContents = false;
            TasksPanel.MouseDown += Table_MouseDown;
            TasksPanel.MouseMove += Table_MouseMove;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 600);
            Controls.Add(TasksPanel);
            Controls.Add(panel2);
            Controls.Add(Topp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToDoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDo List";
            MouseDown += Table_MouseDown;
            MouseMove += Table_MouseMove;
            Topp.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Topp;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button DeleteTask;
        private Button ChangeTask;
        private Button AddTask;
        private Button Exit;
        private FlowLayoutPanel TasksPanel;
    }
}
