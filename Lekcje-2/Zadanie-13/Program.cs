// See https://aka.ms/new-console-template for more information
char hexNum = 'E';

switch (hexNum)
{
    case '0':
        Console.WriteLine($"Decimal number: 0");
        break;
    // ...

    default:
        Console.WriteLine($"Not a valid hexadecimal number!");
        break;
}

// naprawione
char hexNum = 'E';
int decimalNum;

switch (hexNum)
{
    case '0':
        decimalNum = 0;
        break;
    case '1':
        decimalNum = 1;
        break;
    case '2':
        decimalNum = 2;
        break;
    case '3':
        decimalNum = 3;
        break;
    case '4':
        decimalNum = 4;
        break;
    case '5':
        decimalNum = 5;
        break;
    case '6':
        decimalNum = 6;
        break;
    case '7':
        decimalNum = 7;
        break;
    case '8':
        decimalNum = 8;
        break;
    case '9':
        decimalNum = 9;
        break;
    case 'A':
    case 'a':
        decimalNum = 10;
        break;
    case 'B':
    case 'b':
        decimalNum = 11;
        break;
    case 'C':
        decimalNum = 12;
        break;
    case 'D':
    case 'd':
        decimalNum = 13;
        break;
    case 'E':
    case 'e':
        decimalNum = 14;
        break;
    case 'F':
    case 'f':
        decimalNum = 15;
        break;
    default:
        Console.WriteLine($"Not a valid hexadecimal number!");
        return;

    Console.WriteLine($"Decimal number: {decimalNum}");