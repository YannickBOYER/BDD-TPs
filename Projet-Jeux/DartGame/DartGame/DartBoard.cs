namespace DartGame
{
    public class DartBoard
    {
        public String GameMode { get; set; }
        public List<Player> Players { get; set; }

        // Define a list with the areas of the dart board
        public List<int> Areas { get; set; }
        public List<int> Multipliers { get; set; }

        public DartBoard(String gameMode)
        {
            // Initialize the list of areas
            Areas = new List<int>
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 
                12, 13, 14, 15, 16, 17, 18, 19, 20, 25
            };
            Multipliers = new List<int> { 1, 2, 3 };

            // Initialize the game
            Players = new List<Player>();
            GameMode = gameMode;
            if (GameMode=="501")
            {
                Players.Add(new Player(1, 501, 3));
                Players.Add(new Player(2, 501, 3));
            }


        }
    }
}
