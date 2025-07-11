using System;
using System.Collections.Generic;

namespace TreasureHuntApp.ClassFiles
{
    public class GameState
    {
        public List<Location> Locations { get; } = new List<Location>();
        public List<string> Inventory { get; } = new List<string>();
        public int CurrentLocationIndex { get; private set; } = 0;
        public Location CurrentLocation => Locations[CurrentLocationIndex];
        public TimeSpan TotalGameTime { get; private set; }

        private Random random = new Random();
        private int treasuresFound = 0;
        private const int totalTreasures = 5;
        private DateTime startTime;

        public GameState()
        {
            startTime = DateTime.Now;
            InitializeLocations();
            PlaceTreasures();
            PlaceObstacles();
            PlacePuzzles();
        }

        private void InitializeLocations()
        {
            Locations.Add(new Location("Ancient Ruins", "ruins.jpg", "A crumbling ancient city full of mysteries."));
            Locations.Add(new Location("Dense Jungle", "jungle.jpg", "A thick jungle with winding paths and hidden dangers."));
            Locations.Add(new Location("Desert Oasis", "oasis.jpg", "A beautiful oasis in the middle of an endless desert."));
            Locations.Add(new Location("Mountain Peak", "mountain.jpg", "The highest point with a breathtaking view."));
            Locations.Add(new Location("Abandoned Mine", "mine.jpg", "Dark tunnels that may hold precious minerals."));
            Locations.Add(new Location("Hidden Cave", "cave.jpg", "A mysterious underground cave system."));
            Locations.Add(new Location("Fishing Village", "village.jpg", "A peaceful settlement by the water."));
            Locations.Add(new Location("Haunted Forest", "forest.jpg", "A place that sends chills down your spine."));
            Locations.Add(new Location("Royal Gardens", "garden.jpg", "Manicured gardens from a forgotten kingdom."));
            Locations.Add(new Location("Ancient Temple", "temple.jpg", "A sacred place filled with ancient artifacts."));
            Locations.Add(new Location("Pirate Cove", "cove.jpg", "A hidden bay where pirates once anchored."));
            Locations.Add(new Location("Volcano", "volcano.jpg", "A steaming mountain of molten rock."));
            Locations.Add(new Location("Underwater City", "underwater.jpg", "A city lost beneath the waves."));
            Locations.Add(new Location("Space Station", "space.jpg", "An orbital outpost looking over the planet."));
            Locations.Add(new Location("Wild West Town", "western.jpg", "A dusty frontier town from the old west."));
        }

        private void PlaceTreasures()
        {
            string[] treasures = { "Golden Idol", "Diamond Necklace", "Ancient Scroll", "Pirate's Chest", "Mysterious Orb" };

            for (int i = 0; i < totalTreasures; i++)
            {
                int locationIndex;
                do
                {
                    locationIndex = random.Next(0, Locations.Count);
                } while (Locations[locationIndex].HasTreasure);

                Locations[locationIndex].Treasure = treasures[i];
                Locations[locationIndex].HasTreasure = true;
            }
        }

        private void PlaceObstacles()
        {
            Dictionary<string, string> obstacles = new Dictionary<string, string>
            {
                { "Locked Gate", "A heavy gate blocks your path. Looks like it needs a key." },
                { "River", "A fast-moving river prevents you from crossing." },
                { "Landslide", "Rocks have fallen, blocking the path forward." },
                { "Sleeping Dragon", "A massive dragon slumbers in your path. Best not wake it." },
                { "Bottomless Chasm", "A deep chasm stretches before you." }
            };

            foreach (var obstacle in obstacles)
            {
                int locationIndex = random.Next(0, Locations.Count);
                Locations[locationIndex].HasObstacle = true;
                Locations[locationIndex].Obstacle = obstacle;
            }
        }

        private void PlacePuzzles()
        {
            Dictionary<Puzzle, string> puzzles = new Dictionary<Puzzle, string>
            {
                { new Puzzle("Riddle", "What walks on four legs in the morning, two legs at noon, and three legs in the evening?"), "Philosopher's Stone" },
            };

            foreach (var puzzle in puzzles)
            {
                int locationIndex;
                do
                {
                    locationIndex = random.Next(0, Locations.Count);
                } while (Locations[locationIndex].HasPuzzle || Locations[locationIndex].HasTreasure);

                Locations[locationIndex].HasPuzzle = true;
                Locations[locationIndex].Puzzle = puzzle.Key;
                Locations[locationIndex].Treasure = puzzle.Value;
            }
        }

        public void MoveToNextLocation()
        {
            CurrentLocationIndex = (CurrentLocationIndex + 1) % Locations.Count;
        }

        public void MoveToLocation(int index)
        {
            CurrentLocationIndex = index;
        }

        public bool CheckWinCondition()
        {
            TotalGameTime = DateTime.Now - startTime;
            return treasuresFound >= totalTreasures;
        }
    }
}
