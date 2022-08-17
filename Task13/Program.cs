Console.Write("Введите любое число: ");
int  NumberB = int.Parse(Console.ReadLine());
int Num1 = NumberB % 1000;
if (Num1 > 99 && Num1 < 1000) {
    int Num2 = Num1 / 100;
    Console.WriteLine(Num2);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
