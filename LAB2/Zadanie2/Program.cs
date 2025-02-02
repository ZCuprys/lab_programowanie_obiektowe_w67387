using Zadanie2;

//Zadanie 2
KontoBankowe konto = new KontoBankowe("Jan Kowalski", 1000);
konto.Wplata(500);
konto.Wyplata(200);
Console.WriteLine($"Saldo: {konto.Saldo}");