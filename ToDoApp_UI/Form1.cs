namespace ToDoApp_UI
{
    public partial class Form1 : Form
    {
        private string filePath = "todo_list.csv";
        private List<string> tasks = [];

        public Form1()
        {
            InitializeComponent();
            LoadTasks();
            UpdateTaskList();
        }

        private void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                tasks = [.. File.ReadAllLines(filePath)];
            }
        }

        private void SaveTasks()
        {
            File.WriteAllLines(filePath, tasks);
        }

        private void UpdateTaskList()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in tasks)
            {
                listBoxTasks.Items.Add(task);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTask.Text))
            {
                tasks.Add(textBoxTask.Text);
                UpdateTaskList();
                textBoxTask.Clear();
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                tasks.RemoveAt(listBoxTasks.SelectedIndex);
                UpdateTaskList();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveTasks();
            MessageBox.Show("Aufgaben gespeichert!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
