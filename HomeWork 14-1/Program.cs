Random random = new Random();
char[] symbol = { '1','2','3','4','5','6','7','8','9','0','q','Q',
                  'w','W','e','E','r','R','t','T','y','Y','u','U',
                  'i','I','o','O','p','P','a','A','s','S','d','D',
                  'f','F','g','G','h','H','j','J','k','K','l','L',
                  'z','Z','x','X','c','C','v','V','b','B','n','N','m','M'};
Console.Write("Введите длину генерируемого пароля: ");
int quantSymbol = int.Parse(Console.ReadLine()!);
char[] newPassword = new char[quantSymbol];
newPassword[0] = symbol[5];
for (int i = 0; i < quantSymbol; i++)
    newPassword[i] = symbol[random.Next(symbol.Length)];
Console.WriteLine();
foreach (var item in newPassword)
    Console.Write(item);
