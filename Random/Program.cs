Random rnd = new();
//string[] malePetNames = [ "Rufus", "Bear", "Dakota", "Fido",
//                        "Vanya", "Samuel", "Koani", "Volodya",
//                        "Prince", "Yiska" ];
//string[] femalePetNames = [ "Maggie", "Penny", "Saya", "Princess",
//                          "Abby", "Laila", "Sadie", "Olivia",
//                          "Starlight", "Talla" ];

//// Generate random indexes for pet names.
//int mIndex = rnd.Next(malePetNames.Length);
//int fIndex = rnd.Next(femalePetNames.Length);

//// Display the result.
//Console.WriteLine("Suggested pet name of the day: ");
//Console.WriteLine($"   For a male:     {malePetNames[mIndex]}");
//Console.WriteLine($"   For a female:   {femalePetNames[fIndex]}");

//Console.WriteLine((int)'A');
//Console.WriteLine((int)'z');

//for (int i = 1; i < 123; i++)
//{
//    Console.WriteLine((char)i + " " + i);
//}

Random random = new Random();
string NewPassword="";
for (int i = 0; i < 8; i++)
{
    int n = random.Next(1, 5);
    Console.WriteLine(n);
    switch(n)
    {
        case 1: NewPassword += (char)random.Next(65, 91); break;
        case 2: NewPassword += (char)random.Next(97, 122); break;
        case 3: NewPassword += (char)random.Next(48, 57); break;
        case 4: NewPassword += (char)random.Next(33, 38); break;
        case 5: NewPassword += (char)random.Next(63, 64); break;

    }
}
Console.WriteLine(NewPassword);
