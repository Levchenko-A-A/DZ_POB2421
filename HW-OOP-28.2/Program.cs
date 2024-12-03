using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

string filePath = "Календарь.xlsx";
ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
ExcelPackage newBook = new ExcelPackage(filePath);
newBook.Workbook.Worksheets.Add("Календарь 2023");
ExcelWorksheet currentWork = newBook.Workbook.Worksheets["Календарь 2023"];
DateOnly dateOnly = new DateOnly(2023, 1, 1);
while (dateOnly.Year!=2024)
{
    currentWork.Cells[dateOnly.Day, dateOnly.Month+1].Value = dateOnly.Day;
    if(dateOnly.DayOfWeek == DayOfWeek.Sunday || dateOnly.DayOfWeek == DayOfWeek.Saturday)
    {
        currentWork.Cells[dateOnly.Day, dateOnly.Month + 1].Style.Font.Color.SetColor(Color.Red);
        currentWork.Cells[dateOnly.Day, dateOnly.Month + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
        currentWork.Cells[dateOnly.Day, dateOnly.Month + 1].Style.Fill.BackgroundColor.SetColor(Color.GreenYellow);
        currentWork.Cells[dateOnly.Day, dateOnly.Month + 1].Style.Font.Bold = true;
    }
    dateOnly = dateOnly.AddDays(1);
}
newBook.SaveAs(filePath);