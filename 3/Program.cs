int[] array = new int[8];

array = Filling(array, array.Length);
Console.WriteLine("[{0}]", string.Join(", ", array));

int[] Filling(int[] arr, int count)
{
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(20);
    }

    return arr;
}
