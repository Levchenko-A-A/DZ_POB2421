Keyboard simbol = new Keyboard();
simbol.KeyPressed += DisplayChar;
ConsoleKeyInfo ch;
do
{
    ch = Console.ReadKey(true);
    if (ch.Key == ConsoleKey.Escape) break;
    simbol.Put(ch);
}
while (true);

void DisplayChar(string message) => Console.Write(message);

class Keyboard
{
    public delegate void KeyEventArgs(string message);
    public event KeyEventArgs? KeyPressed;
    public void Put(ConsoleKeyInfo key)
    {
        KeyPressed?.Invoke($"Вы нажали Клавишу: {key.KeyChar}\n");
    }
}