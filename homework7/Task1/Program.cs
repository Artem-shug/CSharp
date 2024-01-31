//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.


Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int ack = Ackkerman(n, m);
Console.WriteLine(ack);

int Ackkerman (int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0)
    {
        return Ackkerman(num1 - 1, 1);
    }
    else
    {
        return Ackkerman(num1 - 1, Ackkerman(num1, num2 - 1));
    }
}