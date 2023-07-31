Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел = {SumOfDigits(number)}");

int SumOfDigits(int num)
{
    int sum = 0;
    while(num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
