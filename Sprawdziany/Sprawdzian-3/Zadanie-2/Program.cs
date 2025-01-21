void PrintSquare(int sideLength)
{
    for (int i = 0; i < sideLength; i++)
    {
        if(i == 0 || i == sideLength - 1)
        {
            Console.WriteLine(new string('#', sideLength));
        } else
        {
            Console.WriteLine('#' + new string(' ', sideLength - 2) + '#');
        }
    }
}

PrintSquare(120);