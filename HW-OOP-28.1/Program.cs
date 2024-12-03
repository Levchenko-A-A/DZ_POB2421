using HW_OOP_28._1;
using OfficeOpenXml;
using System.Diagnostics.Metrics;
using System.Drawing.Drawing2D;

string filePath = "СписокКлиентов.xlsx";
ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
ExcelPackage newBook = new ExcelPackage(filePath);
//newBook.Workbook.Worksheets.Add("Клиенты");
ExcelWorksheet currentWork = newBook.Workbook.Worksheets["Клиенты"];
List<Client> clients = new List<Client>();
clients.Add(new Client("Иван", "Иванов", "ivan@example.com"));
clients.Add(new Client("Петр", "Петров", "peter@example.com"));
clients.Add(new Client("Мария", "Сидорова", "maria@example.com"));
clients.Add(new Client("Анна", "Кузнецова", "anna@example.com"));
clients.Add(new Client("Алексей", "Смирнов", "alex@example.com"));
clients.Add(new Client("Наталья", "Васильева", "natalia@example.com"));
clients.Add(new Client("Сергей", "Морозов", "sergey@example.com"));
clients.Add(new Client("Ольга", "Павлова", "olga@example.com"));
clients.Add(new Client("Денис", "Жуков", "denis@example.com"));
clients.Add(new Client("Екатерина", "Макарова", "ekaterina@example.com"));
currentWork.Cells["A1"].Value = "Имя";
currentWork.Cells["B1"].Value = "Фамилия";
currentWork.Cells["C1"].Value = "Почта";

int currentRow = 2;
foreach (Client client in clients)
{
    currentWork.Cells[currentRow, 1].Value = client.Name;
    currentWork.Cells[currentRow, 2].Value = client.SurName;
    currentWork.Cells[currentRow, 3].Value = client.Email;
    currentRow++;
}
newBook.SaveAs("СписокКлиентов.xlsx");