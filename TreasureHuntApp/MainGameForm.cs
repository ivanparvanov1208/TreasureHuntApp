using System;
using System.Drawing;
using System.Windows.Forms;
using GoldenQuest.ClassFiles;
using GoldenQuest.ObjectForms;

namespace GoldenQuest
{
    partial class MainGameForm : Form
    {
        private GameState gameState;

        public MainGameForm()
        {
            InitializeComponent();
            gameState = new GameState();
            UpdateLocationDisplay();

            btnExplore.Click += BtnExplore_Click;
            btnInventory.Click += BtnInventory_Click;
            btnMap.Click += BtnMap_Click;
            btnHelp.Click += BtnHelp_Click;
        }

        private void UpdateLocationDisplay()
        {
            Location currentLocation = gameState.CurrentLocation;
            lblLocation.Text = currentLocation.Name;
            locationImage.Image = Image.FromFile(currentLocation.ImagePath);
        }

        private void BtnExplore_Click(object sender, EventArgs e)
        {
            Location currentLocation = gameState.CurrentLocation;

            if (currentLocation.HasPuzzle)
            {
                PuzzleForm puzzleForm = new PuzzleForm(currentLocation.Puzzle);
                puzzleForm.ShowDialog();

                if (puzzleForm.Solved)
                {
                    MessageBox.Show("Puzzle solved! You found a treasure!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gameState.Inventory.Add(currentLocation.Treasure);
                    currentLocation.HasPuzzle = false;
                    currentLocation.Treasure = null;
                }
            }
            else if (currentLocation.HasTreasure && !currentLocation.HasPuzzle)
            {
                MessageBox.Show($"You found a {currentLocation.Treasure}!", "Treasure Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gameState.Inventory.Add(currentLocation.Treasure);
                currentLocation.Treasure = null;
            }
            else if (currentLocation.HasObstacle)
            {
                ObstacleForm obstacleForm = new ObstacleForm(currentLocation.Obstacle);
                obstacleForm.ShowDialog();

                if (obstacleForm.Overcome)
                {
                    currentLocation.HasObstacle = false;
                }
            }
            else
            {
                MessageBox.Show("You explore the area but find nothing of interest.", "Exploration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            gameState.MoveToNextLocation();
            UpdateLocationDisplay();

            if (gameState.CheckWinCondition())
            {
                WinForm winForm = new WinForm(gameState);
                winForm.ShowDialog();
                this.Close();
            }
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(gameState.Inventory);
            inventoryForm.ShowDialog();
        }

        private void BtnMap_Click(object sender, EventArgs e)
        {
            MapForm mapForm = new MapForm(gameState.Locations, gameState.CurrentLocationIndex);
            mapForm.ShowDialog();

            if (mapForm.SelectedLocationIndex >= 0 && mapForm.SelectedLocationIndex != gameState.CurrentLocationIndex)
            {
                gameState.MoveToLocation(mapForm.SelectedLocationIndex);
                UpdateLocationDisplay();
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void lblLocation_Click(object sender, EventArgs e)
        {

        }
    }
}
