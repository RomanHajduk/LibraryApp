namespace LibraryApp.Entities
{
    public class CD_Music : EntityBase
    {
        public string BandName { get; set; }
        public string AlbumTitle { get; set; }
        public string Genre { get; set; }
        public int ReleaseDate { get; set; }

        public override string ToString() => $"Id: {Id} Band: {BandName} Album: {AlbumTitle} Genre: {Genre} Release Date: {ReleaseDate}";

        public CD_Music()
        {
            BandName = "";
            AlbumTitle = "";
            Genre = "";
            ReleaseDate = 0;
        }
        public CD_Music(string band, string album, string genre, int reldate)
        { 
            BandName= band;
            AlbumTitle = album;
            Genre = genre;
            ReleaseDate = reldate;
        }
    }
}
