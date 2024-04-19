namespace LibraryApp.Entities
{
    public class ComicBook: Book
    {
        public ComicBook() 
        {
            Title = "unknown";
            Author = "unknown";
            Genre = "unknown";
            ReleaseDate = 0;

        }
        public ComicBook(string title, string author, string genre, int releaseDate): base(title, author, genre, releaseDate)
        {
            Title = title;
            Author = author;
            Genre = genre;
            ReleaseDate = releaseDate;
        }

          
       
    }
}
