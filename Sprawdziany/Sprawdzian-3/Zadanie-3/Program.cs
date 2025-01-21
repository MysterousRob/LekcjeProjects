double FindMaxCosine(double[] numbers)
{
    double maxCosine = double.MinValue;
    double maxNumber = numbers[0];

    foreach (var number in numbers)
    {
        double cosine = Math.Cos(number);
        if (cosine > maxCosine)
        {
            maxCosine = cosine;
            maxNumber = number;
        }
    }
    return maxNumber;
}

double[] numbers = { 0.5, 4.5, -0.1, 5.25, -2.33, -5 };
double result = FindMaxCosine(numbers);
Console.WriteLine($"The highest cosine function value is for the parameter {result}");