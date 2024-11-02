void Swap(ref double a, ref double b)
{
    double temp = a;
    a = b;
    b = temp;
}

double x = 10;
double y = 20;

Swap(ref x, ref y);
Console.WriteLine($"x = {x}, y = {y}");