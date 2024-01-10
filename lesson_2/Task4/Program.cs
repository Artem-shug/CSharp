
int n = 5;
int[] array = {3, 9, 4, 15, 1};
int i = 0;
int max = array[0];

while(i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
//Console.Write(max);

max = array[0];
for (int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
//Console.Write(max);

max = array[0];
foreach(int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.Write(max);