using OfficeOpenXml;

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
            UpdateForm();
        }
        private void UpdateForm()
        {
            dataGridViewContact.DataSource = null;
            dataGridViewContact.DataSource = contacts;
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxPatronymic.Text = string.Empty;
            textBoxAdress.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            textBoxMail.Text = string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(filePath);
            if (file.Exists) {file.Delete();}
            ExcelPackage newBook = new ExcelPackage(filePath);
            newBook.Workbook.Worksheets.Add("Список");
            ExcelWorksheet currentWork = newBook.Workbook.Worksheets["Список"];
            int currentRow = 1;
            foreach (Contact contact in contacts)
            {
                currentWork.Cells[currentRow, 1].Value = contact.FirstName;
                currentWork.Cells[currentRow, 2].Value = contact.LastName;
                currentWork.Cells[currentRow, 3].Value = contact.Patronymic;
                currentWork.Cells[currentRow, 4].Value = contact.Adress;
                currentWork.Cells[currentRow, 5].Value = contact.PhoneNumber;
                currentWork.Cells[currentRow, 6].Value = contact.Email;
                currentRow++;
            }
            newBook.SaveAs(filePath);
        }
    }
}
