// See https://aka.ms/new-console-template for more information
int code = 4;
int quantity = 11;
decimal productPrice = 3.5m;
decimal sellPrice;

// Ustalanie ceny sprzedaży na podstawie kodu produktu
if (code < 10)
{
    // Produkty o kodach poniżej 10 sprzedawane są po cenie określonej w productPrice
    sellPrice = productPrice;
}
else if (code >= 10 && code <= 15)
{
    // Produkty o kodach od 10 do 15 sprzedawane są po cenie o 5% mniejszej od productPrice
    sellPrice = productPrice * 0.95m;
}
else
{
    // Produkty o kodach powyżej 16 sprzedawane są po cenie zależnej od quantity
    if (quantity <= 10)
    {
        // Dla quantity do 10 cena jest o 5% wyższa od price
        sellPrice = productPrice * 1.05m;
    }
    else if (quantity >= 11 && quantity <= 20)
    {
        // Dla quantity od 11 do 20 cena jest równa price
        sellPrice = productPrice;
    }
    else if (quantity > 20 && quantity < 100)
    {
        // Dla quantity powyżej 20, ale mniejszej od 100
        int discountPercent = (quantity / 10) - 2; // zniżka 2% dla quantity = 20
        sellPrice = productPrice * (1 - (discountPercent * 0.01m));
    }
    else
    {
        // Dla quantity powyżej 100 cena jest niższa o 10%
        sellPrice = productPrice * 0.90m;
    }
}

Console.WriteLine($"Price: {sellPrice}");