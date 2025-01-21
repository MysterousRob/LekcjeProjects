int GetUserInput()
{
    int input;
    while (true)
    {
        Console.WriteLine("Enter a digit from 1 to 5: ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out input))
        {
            if (input >= 1 && input <= 5)
            {
                return input;
            } else
            {
               Console.WriteLine("No data, please enter a digit from 1 to 5.");
            }
        } else
        {
              Console.WriteLine("Invalid format. Please enter a digit from 1 to 5.");
        }
    }
}

void PrintColorMessage(int number)
{
    switch (number)
    {
        case 1:
            Console.WriteLine("Red");
        break;
        case 2:
            Console.WriteLine("Green");
        break;
        case 3:
            Console.WriteLine("Blue");
        break;
        case 4:
            Console.WriteLine("Gold");
        break;
        case 5:
            Console.WriteLine("White");
        break;
    }
}


int userChoice = GetUserInput();
PrintColorMessage(userChoice);