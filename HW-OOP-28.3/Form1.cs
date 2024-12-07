using OfficeOpenXml;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_OOP_28._3
{
    public partial class Form1 : Form
    {
        private string filePath = "Контакты.xlsx";
        private List<Contact> contacts = new List<Contact>();
        public Form1()
        {
            InitializeComponent();
            buttonEdit.Visible = false;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            contacts.Add(new Contact(textBoxFirstName.Text, textBoxLastName.Text, textBoxPatronymic.Text,
                                     textBoxAdress.Text, textBoxPhone.Text, textBoxMail.Text));
            UpdateForm(contacts);
        }
        private void UpdateForm(List<Contact> amp)
        {
            dataGridViewContact.DataSource = null;
            dataGridViewContact.DataSource = amp;
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxPatronymic.Text = string.Empty;
            textBoxAdress.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            textBoxMail.Text = string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            using (ExcelPackage newBook = new ExcelPackage("Контакты.xlsx"))
            {
                ExcelWorksheet currentWork1 = newBook.Workbook.Worksheets["Список"];
                int currentRow = 1;
                foreach (Contact contact in contacts)
                {
                    currentWork1.Cells[currentRow, 1].Value = contact.FirstName;
                    currentWork1.Cells[currentRow, 2].Value = contact.LastName;
                    currentWork1.Cells[currentRow, 3].Value = contact.Patronymic;
                    currentWork1.Cells[currentRow, 4].Value = contact.Adress;
                    currentWork1.Cells[currentRow, 5].Value = contact.PhoneNumber;
                    currentWork1.Cells[currentRow, 6].Value = contact.Email;
                    currentRow++;
                }
                newBook.Save();
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            using (ExcelPackage newBook2 = new ExcelPackage("Контакты.xlsx"))
            {
                ExcelWorksheet currentWork = newBook2.Workbook.Worksheets["Список"];
                int colCount = currentWork.Dimension.End.Column;  //get Column Count
                int rowCount = currentWork.Dimension.End.Row;     //get row count
                contacts.Clear();
                for (int row = 1; row <= rowCount; row++)
                {
                    contacts.Add(new Contact(currentWork.Cells[row, 1].Value.ToString(),
                                             currentWork.Cells[row, 2].Value.ToString(),
                                             currentWork.Cells[row, 3].Value.ToString(),
                                             currentWork.Cells[row, 4].Value.ToString(),
                                             currentWork.Cells[row, 5].Value.ToString(),
                                             currentWork.Cells[row, 6].Value.ToString()));
                }

            }
            UpdateForm(contacts);
        }

        private void dataGridViewContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewContact.SelectedRows.Count > 0)
            {
                int index = dataGridViewContact.SelectedRows[0].Index;
                textBoxFirstName.Text = contacts[index].FirstName;
                textBoxLastName.Text = contacts[index].LastName;
                textBoxPatronymic.Text = contacts[index].Patronymic;
                textBoxAdress.Text = contacts[index].Adress;
                textBoxPhone.Text = contacts[index].PhoneNumber;
                textBoxMail.Text = contacts[index].Email;
                buttonEdit.Visible = true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewContact.SelectedRows.Count > 0)
            {
                int index = dataGridViewContact.SelectedRows[0].Index;
                contacts[index].FirstName = textBoxFirstName.Text;
                contacts[index].LastName = textBoxLastName.Text;
                contacts[index].Patronymic = textBoxPatronymic.Text;
                contacts[index].Adress = textBoxAdress.Text;
                contacts[index].PhoneNumber = textBoxPhone.Text;
                contacts[index].Email = textBoxMail.Text;
                UpdateForm(contacts);
            }
        }

        private void dataGridViewContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridViewContact.SelectedRows.Count > 0)
                {
                    int index = dataGridViewContact.SelectedRows[0].Index;
                    contacts.RemoveAt(index);
                    UpdateForm(contacts);
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            List<Contact> result = new List<Contact>();

            string? searchString = textBoxSort.Text;
            searchString = searchString.ToLower();
            foreach (Contact contact in contacts)
            {
                if (contact.FirstName.ToLower().Contains(searchString))
                {
                    result.Add(contact);
                }
            }
            dataGridViewContact.DataSource = null;
            dataGridViewContact.DataSource = result;
            UpdateForm(result);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridViewContact.DataSource = null;
            dataGridViewContact.DataSource = contacts;
            UpdateForm(contacts);
        }
    }
}
