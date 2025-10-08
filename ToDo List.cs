using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace ToDo_List
{
    public partial class ToDoList : Form
    {
        private List<TaskItem> Tasks = new List<TaskItem>();
        private string SaveFilePath = "tasks.json";
        public ToDoList()
        {
            InitializeComponent();
            LoadTasksFromFile();

        }

        Point last;
        private Panel selectedTaskPanel;
        private Label selectedTitleLabel;
        private Label selectedDescriptionLabel;

        private void Table_MouseDown(object sender, MouseEventArgs e)
        {
            last = new Point(e.X, e.Y);
        }

        private void Table_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - last.X;
                Top += e.Y - last.Y;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Red;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Black;
        }

        private void AddTask_MouseEnter(object sender, EventArgs e)
        {
            AddTask.ForeColor = Color.Green;
        }

        private void AddTask_MouseLeave(object sender, EventArgs e)
        {
            AddTask.ForeColor = Color.Black;
        }

        private void SelectTaskPanel(Panel panel, Label title, Label description)
        {
            if (selectedTaskPanel == panel)
            {
                panel.BackColor = Color.FromArgb(240, 240, 255);
                selectedTaskPanel = null;
                selectedTitleLabel = null;
                selectedDescriptionLabel = null;
                return;
            }

            selectedTaskPanel = panel;
            selectedTitleLabel = title;
            selectedDescriptionLabel = description;

            foreach (Panel p in TasksPanel.Controls)
                p.BackColor = Color.FromArgb(240, 240, 255);

            panel.BackColor = Color.LightBlue;
        }
       
        private void AddTaskPanel(TaskItem task)
        {
            Panel taskPanel = new Panel
            {
                Width = TasksPanel.ClientSize.Width - 25,
                BackColor = Color.FromArgb(240, 240, 255),
                BorderStyle = BorderStyle.FixedSingle,
                TabStop = false
            };

            Label titleLabel = new Label
            {
                Text = task.Title,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                ForeColor = ColorTranslator.FromHtml(task.TitleColor),
                Location = new Point(10, 10)
            };

            Label descriptionLabel = new Label
            {
                Text = task.Description,
                Font = new Font("Segoe UI", 10),
                AutoSize = true,
                MaximumSize = new Size(600, 0),
                Location = new Point(10, titleLabel.Bottom + 5),
                ForeColor = ColorTranslator.FromHtml(task.DescriptionColor)
            };

            CheckBox completed = new CheckBox
            {
                Text = "завершено",
                Font = new Font("Segoe UI", 10),
                AutoSize = true,
                Location = new Point(taskPanel.Width - 120, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Checked = task.Completed
            };

            completed.CheckedChanged += (s, ev) =>
            {
                task.Completed = completed.Checked;
                if (completed.Checked)
                {
                    titleLabel.Font = new Font(titleLabel.Font, FontStyle.Strikeout);
                    descriptionLabel.Font = new Font(descriptionLabel.Font, FontStyle.Strikeout);
                }
                else
                {
                    titleLabel.Font = new Font(titleLabel.Font, FontStyle.Regular);
                    descriptionLabel.Font = new Font(descriptionLabel.Font, FontStyle.Regular);
                }
                SaveTasksToFile();
            };

            taskPanel.Controls.Add(titleLabel);
            taskPanel.Controls.Add(descriptionLabel);
            taskPanel.Controls.Add(completed);

            int panelHeight = descriptionLabel.Bottom + 10;
            taskPanel.Height = panelHeight;

            taskPanel.Click += (s, ev) => SelectTaskPanel(taskPanel, titleLabel, descriptionLabel);
            titleLabel.Click += (s, ev) => SelectTaskPanel(taskPanel, titleLabel, descriptionLabel);
            descriptionLabel.Click += (s, ev) => SelectTaskPanel(taskPanel, titleLabel, descriptionLabel);

            TasksPanel.Controls.Add(taskPanel);
        }


        private void AddTask_MouseClick(object sender, MouseEventArgs e)
        {
            TaskRedactor editor = new TaskRedactor();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                var task = new TaskItem
                {
                    Title = editor.Title + " _ _ _ " + DateTime.Now.ToString(),
                    Description = editor.Task,
                    TitleColor = ColorTranslator.ToHtml(editor.TitleColor),
                    DescriptionColor = ColorTranslator.ToHtml(editor.TaskColor),
                    Completed = false
                };

                Tasks.Add(task);
                AddTaskPanel(task);
                SaveTasksToFile();
            }
        }

        private void DeleteTask_MouseEnter(object sender, EventArgs e)
        {
            DeleteTask.ForeColor = Color.Red;
        }

        private void DeleteTask_MouseLeave(object sender, EventArgs e)
        {
            DeleteTask.ForeColor = Color.Black;
        }


        private void DeleteTask_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedTaskPanel != null)
            {
                var result = MessageBox.Show(
                    "Удалить выбранную задачу?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
              
                    string title = selectedTitleLabel.Text;
                    string desc = selectedDescriptionLabel.Text;
                    Tasks.RemoveAll(t => t.Title == title && t.Description == desc);

             
                    TasksPanel.Controls.Remove(selectedTaskPanel);

                    selectedTaskPanel = null;
                    selectedTitleLabel = null;
                    selectedDescriptionLabel = null;

                    SaveTasksToFile();
                }
            }
            else
            {
                var result = MessageBox.Show(
                    "Удалить все завершённые задачи?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    Tasks.RemoveAll(t => t.Completed);

                    var toRemove = new List<Panel>();
                    foreach (Panel panel in TasksPanel.Controls)
                    {
                        foreach (Control c in panel.Controls)
                        {
                            if (c is CheckBox cb && cb.Checked)
                            {
                                toRemove.Add(panel);
                                break;
                            }
                        }
                    }

                    foreach (Panel panel in toRemove)
                    {
                        TasksPanel.Controls.Remove(panel);
                    }

                    SaveTasksToFile();
                }
            }
        }



        private void ChangeTask_MouseEnter(object sender, EventArgs e)
        {
            ChangeTask.ForeColor = Color.White;
        }

        private void ChangeTask_MouseLeave(object sender, EventArgs e)
        {
            ChangeTask.ForeColor = Color.Black;
        }

        private void UpdateTaskPanelHeight(Panel panel, Label titleLabel, Label descriptionLabel)
        {
            descriptionLabel.AutoSize = true;
            descriptionLabel.MaximumSize = new Size(600, 0);
            panel.Height = descriptionLabel.Bottom + 10;
        }

        private void ChangeTask_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedTaskPanel != null)
            {
             
                string oldTitle = selectedTitleLabel.Text;
                string oldDescription = selectedDescriptionLabel.Text;

                TaskRedactor editor = new TaskRedactor
                {
                    Title = selectedTitleLabel.Text,
                    Task = selectedDescriptionLabel.Text,
                    TitleColor = selectedTitleLabel.ForeColor,
                    TaskColor = selectedDescriptionLabel.ForeColor
                };

                if (editor.ShowDialog() == DialogResult.OK)
                {
              
                    selectedTitleLabel.Text = editor.Title;
                    selectedDescriptionLabel.Text = editor.Task;
                    selectedTitleLabel.ForeColor = editor.TitleColor;
                    selectedDescriptionLabel.ForeColor = editor.TaskColor;

                    UpdateTaskPanelHeight(selectedTaskPanel, selectedTitleLabel, selectedDescriptionLabel);

                    var task = Tasks.Find(t => t.Title == oldTitle && t.Description == oldDescription);
                    if (task != null)
                    {
                        task.Title = editor.Title;
                        task.Description = editor.Task;
                        task.TitleColor = ColorTranslator.ToHtml(editor.TitleColor);
                        task.DescriptionColor = ColorTranslator.ToHtml(editor.TaskColor);
                    }

                    SaveTasksToFile();
                }
            }
        }


        private void SaveTasksToFile()
        {
            var json = JsonSerializer.Serialize(Tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(SaveFilePath, json);
        }

        private void LoadTasksFromFile()
        {
            if (!File.Exists(SaveFilePath))
                return;

            string json = File.ReadAllText(SaveFilePath);
            Tasks = JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();

            foreach (var task in Tasks)
            {
                AddTaskPanel(task);
            }
        }

    }
}

