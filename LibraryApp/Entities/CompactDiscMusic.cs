namespace LibraryApp.Entities
{
    public class CompactDiscMusic : EntityBase
    {
        public string BandName { get; set; }
        public string AlbumTitle { get; set; }
        public string Genre { get; set; }
        public int ReleaseDate { get; set; }

        public override string ToString() => $"Id: {Id} Band: {BandName} Album: {AlbumTitle} Genre: {Genre} Release Date: {ReleaseDate}";

        public CompactDiscMusic()
        {
            BandName = "";
            AlbumTitle = "";
            Genre = "";
            ReleaseDate = 0;
        }
        public CompactDiscMusic(string band, string album, string genre, int reldate)
        { 
            BandName= band;
            AlbumTitle = album;
            Genre = genre;
            ReleaseDate = reldate;
        }
    }
}
