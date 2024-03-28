using static System.Console;
//
//WriteLine("Press any key combination: ");
//ConsoleKeyInfo key = ReadKey();
//WriteLine();
//WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);

if (args.Length<3)
{
    WriteLine("You must specify two colors and cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return;
}
ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);
CursorSize = int.Parse(args[2]);

