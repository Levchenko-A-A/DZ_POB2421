using OfficeOpenXml;
using System.Data;

namespace HW_OOP_28._6
{
    public partial class Form1 : Form
    {
        private ExcelWorksheet currentWork;
        DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Excel files(*.xlsx)|*.xlsx";
            saveFileDialog1.Filter = "Excel files(*.xlsx)|*.xlsx";
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            dataTable = new DataTable();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                string fileName = openFileDialog1.FileName;
                dataTable.Clear();
                ImportExcelToDataTable(fileName);
                UpdateForm();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                string saveFileName = saveFileDialog1.FileName;
                using (ExcelPackage package = new ExcelPackage(new FileInfo(saveFileName)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                        worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                    for (int i = 1; i < dataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 1, j + 1].Value = dataTable.Rows[i - 1][j].ToString();
                        }
                    }
                    package.Save();
                    MessageBox.Show("Файл сохранен");
                }
            }
        }
        private void UpdateForm()
        {
            dataGridViewExcel.DataSource = null;
            dataGridViewExcel.DataSource = dataTable;
        }
        public void ImportExcelToDataTable(string filePath)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                {
                    dataTable.Columns.Add(firstRowCell.Text);
                }
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    var rowCollection = worksheet.Cells[row, 1, row, worksheet.Dimension.End.Column];
                    DataRow newRow = dataTable.Rows.Add();
                    foreach (var cell in rowCollection)
                    {
                        newRow[cell.Start.Column - 1] = cell.Text;
                    }
                }
                MessageBox.Show("Файл открыт и загружен.");
            }
        }

        private void dataGridViewExcel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewExcel.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridViewExcel.CurrentCell.RowIndex;
                int columnIndex = dataGridViewExcel.CurrentCell.ColumnIndex;
                textBoxValue.Text = dataTable.Rows[rowIndex][columnIndex].ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewExcel.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridViewExcel.CurrentCell.RowIndex;
                int columnIndex = dataGridViewExcel.CurrentCell.ColumnIndex;
                if (!string.IsNullOrEmpty(textBoxValue.Text))
                    if (textBoxValue.Text != dataTable.Rows[rowIndex][columnIndex].ToString()!)
                    {
                        dataTable.Rows[rowIndex][columnIndex] = textBoxValue.Text;
                    }
            }
            UpdateForm();
        }

        private void buttonAddColums_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNameColums.Text))
                dataTable.Columns.Add(textBoxNameColums.Text);
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add();
        }
    }
}
