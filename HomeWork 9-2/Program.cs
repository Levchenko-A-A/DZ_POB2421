//1.Произведите операцию инверсии со следующими числами,
//используя тип данных long:
//264895468854;
//256;
Console.WriteLine("Задача 1");
long value1 = 264895468854;
long value2 = 256;
long result1 = ~value1 + 1;
long result2 = ~value2 + 1;
string binary1 = Convert.ToString(value1, 2);
string binary2 = Convert.ToString(value2, 2);
Console.WriteLine($"DEC: {value1,40}\n" +
                  $"DEC: {value2,40}\n" +
                  $"BIN: {binary1,40}\n" +
                  $"BIN: {binary2,40}\n" +
                  $"Результат ~:\n" +
                  $"DEC: {~value1+1,40}\n" +
                  $"BIN: {Convert.ToString(~value1+1, 2),40}\n" +
                  $"DEC: {~value2+1,40}\n" +
                  $"BIN: {Convert.ToString(~value2+1, 2),40}\n");
Console.WriteLine($"Результат обратной инверсии ~:\n" +
                  $"DEC: {~result1+1,40}\n" +
                  $"BIN: {Convert.ToString(~result1+1, 2),40}\n" +
                  $"DEC: {~result2+1,40}\n" +
                  $"BIN: {Convert.ToString(~result2+1, 2),40}\n");

//2.Произведите операцию сдвига вправо и влево со следующими
//числами:
//256;
//32856;
Console.WriteLine("Задача 2");
value1 = 256;
value2 = 32856;
binary1 = Convert.ToString(value1, 2);
binary2 = Convert.ToString(value2, 2);
Console.WriteLine($"Исходное число 1:\n" +
                  $"DEC: {value1,20}\n" +
                  $"BIN: {binary1,20}\n" +
                  $"Результат сдвига влево на 1 разряд:\n" +
                  $"DEC: {value1 << 1,20}\n" +
                  $"BIN: {Convert.ToString(value1 << 1, 2),20}\n" +
                  $"Результат сдвига влево на 2 разряда:\n" +
                  $"DEC: {value1 << 2,20}\n" +
                  $"BIN: {Convert.ToString(value1 << 2, 2),20}\n" +
                  $"Исходное число 2:\n" +
                  $"DEC: {value2,20}\n" +
                  $"BIN: {binary2,20}\n" +
                  $"Результат сдвига влево на 1 разряд:\n" +
                  $"DEC: {value2 << 1,20}\n" +
                  $"BIN: {Convert.ToString(value2 << 1, 2),20}\n" +
                  $"Результат сдвига влево на 2 разряда:\n" +
                  $"DEC: {value2 << 2,20}\n" +
                  $"BIN: {Convert.ToString(value2 << 2, 2),20}\n\n");
Console.WriteLine($"Исходное число 1:\n" +
                  $"DEC: {value1,20}\n" +
                  $"BIN: {binary1,20}\n" +
                  $"Результат сдвига вправо на 1 разряд:\n" +
                  $"DEC: {value1 >> 1,20}\n" +
                  $"BIN: {Convert.ToString(value1 >> 1, 2),20}\n" +
                  $"Результат сдвига вправо на 2 разряда:\n" +
                  $"DEC: {value1 >> 2,20}\n" +
                  $"BIN: {Convert.ToString(value1 >> 2, 2),20}\n" +
                  $"Исходное число 2:\n" +
                  $"DEC: {value2,20}\n" +
                  $"BIN: {binary2,20}\n" +
                  $"Результат сдвига вправо на 1 разряд:\n" +
                  $"DEC: {value2 >> 1,20}\n" +
                  $"BIN: {Convert.ToString(value2 >> 1, 2),20}\n" +
                  $"Результат сдвига вправо на 2 разряда:\n" +
                  $"DEC: {value2 >> 2,20}\n" +
                  $"BIN: {Convert.ToString(value2 >> 2, 2),20}\n");

//3.Произведите операцию присваивания со следующими числами:
//289, 144, 36274;
//С изменением на 2487;
Console.WriteLine("Задача 3");
int a = 289;
int b = 144;
int c = 36274;
const int d = 2487;
a += d;
b += d;
c += d;
Console.WriteLine($"{a,16}{b,16}{c,16}");
a -= d;
b -= d;
c -= d;
Console.WriteLine($"{a,16}{b,16}{c,16}");
a *= d;
b *= d;
c *= d;
Console.WriteLine($"{a,16}{b,16}{c,16}");
a /= d;
b /= d;
c /= d;
Console.WriteLine($"{a,16}{b,16}{c,16}");
a %= d;
b %= d;
c %= d;
Console.WriteLine($"{a,16}{b,16}{c,16}");
a &= d;
b &= d;
c &= d;
Console.WriteLine($"{a,16}{b,16}{c,16}");
a |= d;
b |= d;
c |= d;
Console.WriteLine($"{a,16}{b,16}{c,16}");
a ^= d;
b ^= d;
c ^= d;
Console.WriteLine($"{a,16}{b,16}{c,16}");
a <<= d;
b <<= d;
c <<= d;
Console.WriteLine($"{a,16}{b,16}{c,16}");
a >>= d;
b >>= d;
c >>= d;
Console.WriteLine($"{a,16}{b,16}{c,16}");