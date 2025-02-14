//Zadanie 1
using System.Text.Json.Serialization;

Console.WriteLine("Podaj nazwę pliku");
string path = Console.ReadLine();
Console.WriteLine("Podaj nr albumu");
string nrAlbumu =  Console.ReadLine();

try
{
    File.WriteAllText(path, nrAlbumu);
    Console.WriteLine("Zapisano dane do pliku");

}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}


//Zadanie 2
Console.WriteLine("Podaj nazwę pliku do odczytu");
string path2 = Console.ReadLine();

try
{
    string zawartosc = File.ReadAllText(path2);
    Console.WriteLine("Zawartość pliku:");
    Console.WriteLine(zawartosc);

}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}

//Zadanie 3

string path3 = "pesele.txt";

try
{
    if (!File.Exists(path3))
    {
        Console.WriteLine($"Plik {path3} nie istnieje.");
        return;
    }
    string[] pesele = File.ReadAllLines(path3);
    int liczbaKobieta = pesele.Count(isKobieta);
    int liczbaMezczyzn = pesele.Length - liczbaKobieta;
    Console.WriteLine($"Liczba kobieta: {liczbaKobieta}");
    Console.WriteLine($"Liczba mezczyzn: {liczbaMezczyzn}");

}
catch (Exception ex)
{
    Console.WriteLine("Wystąpił nieoczekiwany błąd" + ex.Message);
}

static bool isKobieta(string pesel) //metoda jest statyczna bo całość kodu jest w Main (bez tworzenia obiektu klasy)
{
    if (pesel.Length != 11 || !pesel.All(char.IsDigit))
        return false;
    char cyfra = pesel[9];
    return cyfra % 2 == 0;
}

//Zadanie 4

using ConsoleApp1;
using Newtonsoft.Json;

string filePath = "db.json";

var data = LoadData(filePath);


static List<PopulationData> LoadData(string filePath)
{
    var jsonData = File.ReadAllText(filePath);
    return JsonConverter.DeserializeObject<List<PopulationData>>(jsonData)
}

static int PopulationDifferent(List<PopulationData> populationData, string countryCode, int year1, int year2)
{
    var Year1 = GetPopulation(populationData, countryCode, year1);
    var Year2 = GetPopulation(populationData, countryCode, year2);

    if (inputYear1.HasValue && inputYear2.HasValue)
        return inputYear2.Value - inputYear1.Value;
}

static int? GetPopulation(List<PopulationData> populationData, string countryCode, int year)
{
    var entry = populationData.FirstOrDefault(d => d._Country.Id == countryCode && d.Date == year.ToString());
    if (entry != null && int.TryParse(entry.Value, out int population))
    {
        return population;
    }
    return null;
}