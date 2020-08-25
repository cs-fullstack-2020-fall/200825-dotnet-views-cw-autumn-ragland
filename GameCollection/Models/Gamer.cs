namespace GameCollection.Models
{
    public class Gamer
    {
        public int gamerID;
        public string gamerFName;
        public string gamerLName;
        public Gamer(int gamerID, string gamerFName, string gamerLName)
        {
            this.gamerID = gamerID;
            this.gamerFName = gamerFName;
            this.gamerLName = gamerLName;
        }
    }
}