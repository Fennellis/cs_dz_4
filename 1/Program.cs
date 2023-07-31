Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A в степени B = {Pow(a, b)}");

int Pow(int baseOfPow, int expOfPow)
{
    int pow = 1;
    for (int i = 1; i <= expOfPow; i++)
    {
        pow *= baseOfPow;
    }
    return pow;
}
