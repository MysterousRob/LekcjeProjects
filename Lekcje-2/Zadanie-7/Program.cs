// See https://aka.ms/new-console-template for more information
string firstPart = "This is";
string secondPart = "a string";
string thirdPart = "with capital letters.";
// Złączenie tekstów z dodaniem brakujących odstępów
string combinedString = firstPart + " " + secondPart + " " + thirdPart;

// Wypisanie tekstu DRUKOWANYMI LITERAMI
string upperCaseString = combinedString.ToUpper();
Console.WriteLine(upperCaseString);

// Wypisanie długości ciągu znaków
int length = combinedString.Length;
Console.WriteLine("Długość ciągu: " + length);

/*need to writeout all of the functions*/
//bool IsGreater = false;
//bool IsLower = true;

//bool IsLower = !IsGreater;
//bool IsInRange = IsLower && true;
//bool IsEqual = !IsGreater || !IsLower;

//int counter = 56;
//double temperature = 14;
//bool isGreaterThanLimit = counter > 100;
//bool isCold = temperature < 5;
//bool isEqualZero = counter == 0;
//bool isNotZero = counter != 0;
//bool isGreaterOrEqualZero = temperature >= 0.0;