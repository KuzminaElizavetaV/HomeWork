Console.Write("Введите 1 число: ");
int NumberOne = int.Parse(Console.ReadLine());
Console.Write("Ведите 2 число: ");
int NumberTwo = int.Parse(Console.ReadLine());
if (NumberOne > NumberTwo)
Console.WriteLine($"Максимальное число равно {NumberOne}");
else
Console.WriteLine($"Максимальное число равно {NumberTwo}");