using System.Windows.Forms;

namespace HW_OOP_28._5
{
    public partial class Form1 : Form
    {
        private List<Task> tasks = new List<Task>();
        public Form1()
        {
            InitializeComponent();
            textBoxStatus.Enabled = false;
        }
        private void UpdateForm()
        {
            dataGridViewTask.DataSource = null;
            dataGridViewTask.DataSource = tasks;
            for (int i = 0; i < dataGridViewTask.Columns.Count; i++)
            {
                dataGridViewTask.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            textBoxTitle.Text = textBoxStatus.Text = string.Empty;
            comboBoxPriority.SelectedIndex = -1;
            dateTimePickerTime.Value = DateTime.Now;
            textBoxStatus.Enabled = false;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text.Length != 0 && comboBoxPriority.SelectedIndex != -1)
            {
                tasks.Add(new Task(textBoxTitle.Text.ToString(), dateTimePickerTime.Value, comboBoxPriority.Text.ToString()));
                UpdateForm();
            }
            else
                MessageBox.Show("Введите корректно Название и Приоритет задачи");
        }

        private void dataGridViewTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTask.SelectedCells.Count > 0)
            {
                int index = dataGridViewTask.SelectedRows[0].Index;
                textBoxTitle.Text = tasks[index].Title;
                textBoxStatus.Text = tasks[index].Status;
                comboBoxPriority.Text = tasks[index].Priority;
                dateTimePickerTime.Text = tasks[index].Time.ToString();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (dataGridViewTask.SelectedCells.Count > 0)
            {
                int index = dataGridViewTask.SelectedRows[0].Index;
                tasks[index].Status = "Выполнено";
                UpdateForm();
            }
            else UpdateForm();
        }
    }
}
