using LibraryApp.Data;
using LibraryApp.Entities;
using LibraryApp.Repositories;

var sqlBookRepository = new SQLRepository<Book>(new LibraryAppDbContext());
var sqlComicBookRepository = new SQLRepository<ComicBook>(new LibraryAppDbContext());
var sqlCompactDiscMusicRepository = new SQLRepository<CompactDiscMusic>(new LibraryAppDbContext());
var sqlDVDGamesRepository = new SQLRepository<DVD_Game>(new LibraryAppDbContext());

static void AddBooks(IRepository<Book> sqlBookRepository)
{
    sqlBookRepository.Add(new Book { Title = "Krew elfów", Author = "Andrzej Sapkowski", Genre = "Fantasy", ReleaseDate = 1994 });
    sqlBookRepository.Add(new Book { Title = "Potop", Author = "Henryk Sienkiewicz", Genre = "Powieść historyczna", ReleaseDate = 1886 });
    sqlBookRepository.Add(new Book { Title = "Igła", Author = "Ken Follett", Genre = "Powieść wojenna", ReleaseDate = 1978 });
    sqlBookRepository.Save();
}
static void AddComicBooks(IWriteRepository<ComicBook> sqlComicBookRepository)
{

    sqlComicBookRepository.Add(new ComicBook { Title = "Kajko i Kokosz: Szkoła latania", Author = "Janusz Christa", Genre = "Fantasy", ReleaseDate = 1981 });
    sqlComicBookRepository.Add(new ComicBook { Title = "Tytus, Romek i A’Tomek – Księga XIX. Tytus aktorem", Author = "Henryk Jerzy Chmielewski", Genre = "Fantasy", ReleaseDate = 1992 });
    sqlComicBookRepository.Add(new ComicBook { Title = "Batman vs Predator", Author = "Dave Gibbons", Genre = "Sensacja/Fantasy", ReleaseDate = 1993 });
    sqlComicBookRepository.Save();
}
static void DisplayAllItems(IReadRepository<IEntity> repository)
{ 
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }

}
void CreateDataForAllRepositories()
{

    Console.Clear();
    sqlBookRepository.Add(new Book { Title = "Krew elfów", Author = "Andrzej Sapkowski", Genre = "Fantasy", ReleaseDate = 1994 });
    sqlBookRepository.Add(new Book { Title = "Potop", Author = "Henryk Sienkiewicz", Genre = "Powieść historyczna", ReleaseDate = 1886 });
    sqlBookRepository.Add(new Book { Title = "Igła", Author = "Ken Follett", Genre = "Powieść wojenna", ReleaseDate = 1978 });
    sqlBookRepository.Add(new Book { Title = "Akademia pana Kleksa", Author = "Jan Brzechwa", Genre = "Literatura dziecięca", ReleaseDate = 1946 });
    sqlBookRepository.Add(new Book { Title = "Zakazana archeologia ", Author = "Michael Cremo", Genre = "Paranauka", ReleaseDate = 1998 });
    sqlBookRepository.Save();
    Console.WriteLine("Added Book To Repository");
    sqlComicBookRepository.Add(new ComicBook { Title = "Kajko i Kokosz: Szkoła latania", Author = "Janusz Christa", Genre = "Fantasy", ReleaseDate = 1981 });
    sqlComicBookRepository.Add(new ComicBook { Title = "Tytus, Romek i A’Tomek – Księga XIX. Tytus aktorem", Author = "Henryk Jerzy Chmielewski", Genre = "Fantasy", ReleaseDate = 1992 });
    sqlComicBookRepository.Add(new ComicBook { Title = "Batman vs Predator", Author = "Dave Gibbons", Genre = "Sensacja/Fantasy", ReleaseDate = 1993 });
    sqlComicBookRepository.Add(new ComicBook { Title = "Jonka, Jonek i Kleks. Złoto Alaski", Author = "Szarlota Pawel", Genre = "Adventure Fantasy", ReleaseDate = 1986 });
    sqlComicBookRepository.Add(new ComicBook { Title = "Superman Doomsday", Author = "Dan Jurgens", Genre = "SF", ReleaseDate = 1996 });
    sqlComicBookRepository.Save();
    Console.WriteLine("Added ComicBook To Repository");
    sqlCompactDiscMusicRepository.Add(new CompactDiscMusic { BandName = "Moonspell", AlbumTitle = "Night Eternal", Genre = "Black Gothic Romantic Metal", ReleaseDate = 2008 });
    sqlCompactDiscMusicRepository.Add(new CompactDiscMusic { BandName = "Therion", AlbumTitle = "Theli", Genre = "Symphonic Metal", ReleaseDate = 1996 });
    sqlCompactDiscMusicRepository.Add(new CompactDiscMusic { BandName = "Bon Jovi", AlbumTitle = "Keep The Faith", Genre = "Rock", ReleaseDate = 1992 });
    sqlCompactDiscMusicRepository.Add(new CompactDiscMusic { BandName = "Modern Talking", AlbumTitle = "Let’s Talk About Love", Genre = "Dance Pop", ReleaseDate = 1985 });
    sqlCompactDiscMusicRepository.Add(new CompactDiscMusic { BandName = "Enigma", AlbumTitle = "The Screen Behind The Mirror", Genre = "Pop", ReleaseDate = 1999 });
    sqlCompactDiscMusicRepository.Save();
    Console.WriteLine("Added CompactDiscMusic To Repository");
    sqlDVDGamesRepository.Add(new DVD_Game { Title = "Wiedźmin 3: Dziki Gon", PEGI = 19, Genre = "Fantasy Action", ReleaseDate = 2015 });
    sqlDVDGamesRepository.Add(new DVD_Game { Title = "Crash Bandicoot N Sane Trilogy", PEGI = 0, Genre = "Arcade", ReleaseDate = 2017 });
    sqlDVDGamesRepository.Add(new DVD_Game { Title = "Mortal Kombat 11", PEGI = 18, Genre = "Fight", ReleaseDate = 2019 });
    sqlDVDGamesRepository.Add(new DVD_Game { Title = "Total Annihilation", PEGI = 12, Genre = "RTS", ReleaseDate = 1997 });
    sqlDVDGamesRepository.Add(new DVD_Game { Title = "Risen", PEGI = 16, Genre = "RPG", ReleaseDate = 2009 });
    sqlDVDGamesRepository.Save();
    Console.WriteLine("Added DVDGame To Repository");

}
ConsoleKeyInfo DisplayMenu()
{
    Console.WriteLine("*************************************************\n" +
                      "*   Adding Stuff For Rental Books Music Games   *\n" +
                      "*************************************************");
    Console.Write("-----------Menu----------\n" +
                  "1. Add Book\n" +
                  "2. Add ComicBook\n" +
                  "3. Add CD Music\n" +
                  "4. Add DVD Game\n" +
                  "5. Create objects for all repositories(automatic)\n" +
                  "6. Create objects (Covariance and Contravariance using)\n" +
                  "7. Display all repositories\n" +
                  "8. Exit the application\n" +
                  "Choose option:");
    return Console.ReadKey();
}
bool AddBook()
{
    Console.Clear();
    Console.WriteLine("Adding Book");
    Console.Write("Enter Title: ");
    var title = Console.ReadLine();
    Console.Write("Enter Author: ");
    var author = Console.ReadLine();
    Console.Write("Enter Genre: ");
    var genre = Console.ReadLine();
    Console.Write("Enter Release Date(Year): ");
    var date = Console.ReadLine();
    if (title != null && author != null && genre != null && date != null)
    {
        if (title == "")
        {
            title = "unknown";
        }
        if (author == "")
        {
            author = "unknown";
        }
        if (genre == "")
        {
            genre = "unknown";
        }
        if (date == "")
        {
            date = "0";
        }
        
        sqlBookRepository.Add(new Book { Title = title, Author = author, Genre = genre, ReleaseDate = int.Parse(date) });
        sqlBookRepository.Save();
        return true;
    }
    else
    { 
        return false;
    }       
}
bool AddComicBook()
{
    Console.Clear();
    Console.WriteLine("Adding ComicBook");
    Console.Write("Enter Title: ");
    var title = Console.ReadLine();
    Console.Write("Enter Author: ");
    var author = Console.ReadLine();
    Console.Write("Enter Genre: ");
    var genre = Console.ReadLine();
    Console.Write("Enter Release Date: ");
    var date = Console.ReadLine();
    if (title != null && author != null && genre != null && date != null)
    {
        if (title == "")
        {
            title = "unknown";
        }
        if (author == "")
        {
            author = "unknown";
        }
        if (genre == "")
        {
            genre = "unknown";
        }
        if (date == "")
        {
            date = "0";
        }

        sqlComicBookRepository.Add(new ComicBook { Title = title, Author = author, Genre = genre, ReleaseDate = int.Parse(date) });
        sqlComicBookRepository.Save();
        return true;
    }
    else
    {
        return false;
    }
}

bool AddCompactDiscMusic()
{
    Console.Clear();
    Console.WriteLine("Adding CD Music");
    Console.Write("Enter Band: ");
    var band = Console.ReadLine();
    Console.Write("Enter Album :");
    var album = Console.ReadLine();
    Console.Write("Enter Genre: ");
    var genre = Console.ReadLine();
    Console.Write("Enter Release Date: ");
    var date = Console.ReadLine();
    if (band != null && album != null && genre != null && date != null)
    {
        if (band == "")
        {
            band = "unknown";
        }
        if (album == "")
        {
            album = "unknown";
        }
        if (genre == "")
        {
            genre = "unknown";
        }
        if (date == "")
        {
            date = "0";
        }
        sqlCompactDiscMusicRepository.Add(new CompactDiscMusic { BandName = band, AlbumTitle = album, Genre = genre, ReleaseDate = int.Parse(date) });
        sqlCompactDiscMusicRepository.Save();  
        return true;
    }
    else
    {
        return false;
    }
}

bool AddDVDGame()
{
    Console.Clear();
    Console.WriteLine("Adding DVD Game");
    Console.Write("Enter Title: ");
    var title = Console.ReadLine();
    Console.Write("Enter PEGI classification: ");
    var pegiclass = Console.ReadLine();
    Console.Write("Enter Genre: ");
    var genre = Console.ReadLine();
    Console.Write("Enter Release Date: ");
    var date = Console.ReadLine();
    if (title != null && pegiclass != null && genre != null && date != null)
    {
        if (title == "")
        {
            title = "unknown";
        }
        if (pegiclass == "")
        {
            pegiclass = "unknown";
        }
        if (genre == "")
        {
            genre = "unknown";
        }
        if (date == "")
        {
            date = "0";
        }

        sqlDVDGamesRepository.Add(new DVD_Game { Title = title, PEGI = int.Parse(pegiclass), Genre = genre, ReleaseDate = int.Parse(date) });
        sqlDVDGamesRepository.Save();
        return true;
    }
    else
    {
        return false;
    }
}
void DisplayInfo(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("------------------------------------------");
    Console.WriteLine($"{message}");
    Console.WriteLine("------------------------------------------");
    Console.ForegroundColor= ConsoleColor.White;
}
void DisplayReturnToMenu()
{
    Console.WriteLine("Press any key to return to menu..");
    Console.ReadKey();
}
void ShowMessage(string message)
{
    Console.SetCursorPosition(0, Console.GetCursorPosition().Top);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}

while (true)
{
    var choose = DisplayMenu();
    switch (choose.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            try
            {
                if (AddBook())
                {
                    Console.WriteLine("Book Added to Repository");
                }
            }
            catch (Exception)
            {
                ShowMessage("Incorrect Data! The object was not created.");
            }
            DisplayReturnToMenu();
            Console.Clear();
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            try
            {
                if (AddComicBook())
                {
                    Console.WriteLine("ComicBook Added to Repository");
                }
            }
            catch (Exception)
            {
                ShowMessage("Incorrect Data! The object was not created.");
            }
            DisplayReturnToMenu();
            Console.Clear();
            break;
        case ConsoleKey.D3:
        case ConsoleKey.NumPad3:
            try
            {
                if (AddCompactDiscMusic())
                {
                    Console.WriteLine("CompactDiscMusic Added to Repository");
                }
            }
            catch (Exception)
            {
                ShowMessage("Incorrect Data! The object was not created.");
            }
            DisplayReturnToMenu();
            Console.Clear();
            break;
        case ConsoleKey.D4:
        case ConsoleKey.NumPad4:
            try
            {
                if (AddDVDGame())
                {
                    Console.WriteLine("DVDGame Added to Repository");
                }
            }
            catch (Exception)
            {
                ShowMessage("Incorrect Data! The object was not created.");
            }
            DisplayReturnToMenu();
            Console.Clear();
            break;
        case ConsoleKey.D5:
        case ConsoleKey.NumPad5:
            Console.Clear();
            CreateDataForAllRepositories();      
            DisplayReturnToMenu();
            Console.Clear();
            break;
        case ConsoleKey.D6:
        case ConsoleKey.NumPad6:
            Console.Clear();
            AddBooks(sqlBookRepository);
            AddComicBooks(sqlBookRepository);
            DisplayReturnToMenu();
            break;
        case ConsoleKey.D7:
        case ConsoleKey.NumPad7:
            Console.Clear();
            DisplayInfo("Pozycje w repozytorium książek i komiksów:");
            DisplayAllItems(sqlBookRepository);
            //wyświetlanie samego repozytorium z komiksami
            //DisplayInfo("Pozycje w repozytorium komiksów:");
            //DisplayAllItems(sqlComicBookRepository);
            DisplayInfo("Pozycje w repozytorium płyt CD z muzyką:");
            DisplayAllItems(sqlCompactDiscMusicRepository);
            DisplayInfo("Pozycje w repozytorium płyt DVD z grami:");
            DisplayAllItems(sqlDVDGamesRepository);
            DisplayReturnToMenu();
            Console.Clear();
            break;
        case ConsoleKey.D8:
        case ConsoleKey.NumPad8:
            Environment.Exit(0);
            break;
        default:
            ShowMessage("Incorrect option.Please again choose correct option!!");
            await Task.Delay(2000);
            Console.Clear();
            break;
    }
}


