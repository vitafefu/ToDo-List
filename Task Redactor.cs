using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ToDo_List
{
    public partial class TaskRedactor : Form
    {
        public TaskRedactor()
        {
            InitializeComponent();
            TitleBox.Text = "Название задачи";
            TitleBox.ForeColor = Color.Gray;
            TaskBox.Text = "Описание задачи";
            TaskBox.ForeColor = Color.Gray;
        }

        public string Title
        {
            get => TitleBox.Text;
            set => TitleBox.Text = value;
        }
        public Color TitleColor
        {
            get => TitleBox.ForeColor;
            set => TitleBox.ForeColor = value;
        }

        public string Task
        {
            get => TaskBox.Text;
            set => TaskBox.Text = value;
        }
        public Color TaskColor
        {
            get => TaskBox.ForeColor;
            set => TaskBox.ForeColor = value;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleBox.Text) || string.IsNullOrWhiteSpace(TaskBox.Text) ||
                TitleBox.Text == "Название задачи" || TaskBox.Text == "Описание задачи")
            {
                MessageBox.Show("Заполните все пустые поля");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.Green;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.Black;
        }

        private void TitleBox_Enter(object sender, EventArgs e)
        {
            if (TitleBox.Text == "Название задачи")
            {
                TitleBox.Text = "";
                TitleBox.ForeColor = Color.Black;
            }
        }

        private void TitleBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleBox.Text))
            {
                TitleBox.Text = "Название задачи";
                TitleBox.ForeColor = Color.Gray;
            }
        }

        private void TaskBox_Enter(object sender, EventArgs e)
        {
            if (TaskBox.Text == "Описание задачи")
            {
                TaskBox.Text = "";
                TaskBox.ForeColor = Color.Black;
            }
        }

        private void TaskBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaskBox.Text))
            {
                TaskBox.Text = "Описание задачи";
                TaskBox.ForeColor = Color.Gray;
            }
        }
        Point last;
        private void TaskRedactor_MouseDown(object sender, MouseEventArgs e)
        {
            last = new Point(e.X, e.Y);
        }

        private void TaskRedactor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - last.X;
                Top += e.Y - last.Y;
            }
        }
    }
}
