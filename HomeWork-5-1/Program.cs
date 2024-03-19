// See https://aka.ms/new-console-template for more information

const double Ksm = 0.1;             // Коэффициент пересчета в самтиметры
const double Km = 0.001;            // Коэффициент пересчета в метры
const double Kkm = 0.000001;        // Коэффициент пересчета в километры
const double Kmile = 0.000000621;   // Коэффициент пересчета в мили
const double Kyard = 0.0009144;     // Коэффициент пересчета в ярды

Console.Write("Введите значение в мм: ");
double mm = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Значение в сантиметрах: {mm * Ksm} см\n" +
    $"Значение в метрах: {mm * Km} м\n" +
    $"Значение в километрах: {mm * Kkm} км\n" +
    $"Значение в милях: {mm * Kmile} ми\n" +
    $"Значение в ярдах: {mm * Kyard} ");
Console.ReadLine();
