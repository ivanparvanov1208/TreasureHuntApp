namespace GoldenQuest.ClassFiles
{
    public class Location
    {
        public string Name { get; }
        public string ImagePath { get; }
        public string Description { get; }
        public bool HasTreasure { get; set; }
        public string Treasure { get; set; }
        public bool HasObstacle { get; set; }
        public KeyValuePair<string, string> Obstacle { get; set; }
        public bool HasPuzzle { get; set; }
        public Puzzle Puzzle { get; set; }

        public Location(string name, string imagePath, string description)
        {
            Name = name;
            ImagePath = imagePath;
            Description = description;
            HasTreasure = false;
            Treasure = null;
            HasObstacle = false;
            HasPuzzle = false;
        }
    }
}

