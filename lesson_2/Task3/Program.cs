
int n = 10;
int[] array = { 3, 8, 46, 35, 23, 16, 7, 9, 12, 13 };
int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}