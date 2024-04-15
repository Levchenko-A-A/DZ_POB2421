Console.WriteLine("Выберите аромат духов:\n" +
                  "1 - Chanek.\n" +
                  "2 - Dior.\n" +
                  "3 - Tom Ford.\n" +
                  "4 - Gucci." +
                  "5 - Yves Saint Laurent.");
Console.Write("Введите Ваш выбор:");
int choice=int.Parse(Console.ReadLine()!);
switch (choice)
{
    case 1: Console.WriteLine("Ароматы CHANEL сопровождают жизнь смелой, сияющей женщины в постоянном движении."); break;
    case 2: Console.WriteLine("Восточный, пряный, чувственный, волнующий. Его чарующий аромат раскрывает все секреты Востока и тайны женственности."); break;
    case 3: Console.WriteLine("Tom Ford Lost Cherry – цветочно-восточная новинка 2018 года от американского бренда селективной парфюмерии"); break;
    case 4: Console.WriteLine("пафрюмерная вода класса люкс с восточно-древесным ароматом для женщин, представленная в 2019 году итальянским модным домом Gucci"); break;
    case 5: Console.WriteLine("YSL Black Opium - новая молодежная, «рок-н-рольная» версия оригинального аромата Opium"); break;
}