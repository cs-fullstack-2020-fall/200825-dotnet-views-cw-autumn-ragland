namespace GameCollection.Models
{
    public class VideoGame 
    {
        public int videoGameID;
        public string videoGameName;
        public string videoGameDescription;
        public string videoGamePlatform;
        public VideoGame(int videoGameID, string videoGameName, string videoGameDescription, string videoGamePlatform)
        {
            this.videoGameID = videoGameID;
            this.videoGameName = videoGameName;
            this.videoGameDescription = videoGameDescription;
            this.videoGamePlatform = videoGamePlatform;
        }
    }
}
