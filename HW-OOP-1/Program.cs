using HW_OOP_1;

Time time = new Time() { Hour = 20, Minute = 15, Second = 30 };
time.Print();
time.AddHour(10);
time.Print();
time.SubMinutes(50);
time.SubHours(12);
time.Print();

double a = 3;
double b = 4;
double c = 5;
Triangle triangle = new Triangle(a, b, c);
triangle.Print();
triangle.A = 8;
triangle.Print();
triangle.Median(a, b, c);