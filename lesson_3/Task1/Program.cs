
double CalculateFormula(int a, int b, int c, int d)
{
    double numenet = a * b;
    int denumenet = c + d;
    double result = numenet / denumenet;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);
