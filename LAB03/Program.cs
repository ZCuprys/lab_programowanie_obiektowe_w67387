using LAB03;

//tworzenie obiektów klas

Person autor1 = new Person("Jan", "Kowalski", 40);

Book book1 = new Book("Morze", autor1, new DateTime(1985, 7, 29));
Book book2 = new Book("Kosmos", autor1, new DateTime(1995, 7, 22));
Book book3 = new Book("Pustynia", autor1, new DateTime(1985, 5, 20));

// Tworzenie czytelników
Reader reader1 = new Reader("Piotr", "Zieliński", 25);
Reader reader2 = new Reader("Anna", "Nowak", 30);

// Przypisywanie książek do czytelników
reader1.Przeczytane.Add(book1);
reader1.Przeczytane.Add(book3);

reader2.Przeczytane.Add(book2);

// Wyświetlanie danych czytelników i ich książek
Console.WriteLine("Informacje o czytelnikach");
reader1.View();
reader2.View();

//Zadanie 1d
Person o = new Reader("Anna", "Wisienka", 30);
o.View();