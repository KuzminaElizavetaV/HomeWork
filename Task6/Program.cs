Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine());
int Remainder = Number % 2;
if (Remainder == 0)
Console.WriteLine($"Число {Number} является четным.");
else
Console.WriteLine($"Число {Number} является нечетным.");