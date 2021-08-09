namespace Songs
{
    public class SongModel
    {

        public string Title;
        public string Artist;
        public int Duration;
        public static int SongCount = 0;

        public SongModel(string aTitle, string aArtist, int aDuration)
        {
            Title = aTitle;
            Artist = aArtist;
            Duration = aDuration;
            SongCount++;

        }

        public int GetSongCount()
        {
            return SongCount;
        }

    }
}