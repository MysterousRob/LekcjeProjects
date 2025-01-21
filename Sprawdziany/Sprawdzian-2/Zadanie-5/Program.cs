using System;

//had to reinstate ISinger
public interface ISinger
{
    string Sing();
}

public class Child : ISinger
{
    public string Sing()
    {
        return "Baby shark doo doo doo doo doo";
    }
}

public class Singers<T> : List<T> where T : ISinger
{
}

class Program
{
    static void Main()
    {
        Singers<ISinger> singers = new Singers<ISinger>();
        singers.Add(new Child());

        foreach (var singer in singers)
        {
            Console.WriteLine(singer.Sing());
        }
    }
}
