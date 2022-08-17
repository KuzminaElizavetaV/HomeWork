Console.Write("Введите любое трехзначное число: ");
int  NumberA = int.Parse(Console.ReadLine());
int Num1 = NumberA % 100;
int Num2 = Num1 / 10;
Console.WriteLine(Num2);
