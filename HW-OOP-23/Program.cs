Keyboard simbol = new Keyboard();
simbol.KeyPressed += DisplayChar;
do
{
    char ch = Console.ReadKey(true).KeyChar;
    if ((int)ch == 27) break;
    simbol.Put(ch);
}
while (true);

void DisplayChar(string message) => Console.Write(message);

class Keyboard
{
    public delegate void KeyEventArgs(string message);
    public event KeyEventArgs? KeyPressed;
    public int Key { get; private set; }
    //public Keyboard(int key) => Key = key;
    public void Put(char key)
    {
        KeyPressed?.Invoke($"Вы нажали Клавишу: {key}\n");
    }
}