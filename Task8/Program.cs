Console.Write("Введите число: ");
int  NumberN = int.Parse(Console.ReadLine());
int Count = 1;
while (Count <= NumberN)
{
int Quotient = Count % 2;
    if (Quotient == 0)
    {
    Console.WriteLine(Count);
    Count = Count + 1;
    }
    else
    {
    Count = Count + 1;   
    } 
}

