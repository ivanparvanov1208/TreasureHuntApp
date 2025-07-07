using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TreasureHuntApp
{
    public partial class ObstacleForm : Form
    {
        public bool Overcome { get; private set; } = false;
        private KeyValuePair<string, string> obstacle;

        public ObstacleForm(KeyValuePair<string, string> obstacle)
        {
            InitializeComponent();
            this.obstacle = obstacle;

            lblTitle.Text = $"Obstacle: {obstacle.Key}";
            lblDescription.Text = obstacle.Value;

            // Populate inventory combo box
            cmbInventory.Items.AddRange(new string[] { "Rope", "Key", "Shovel", "Wings", "Boat" });

            btnUseItem.Click += BtnUseItem_Click;
            btnGoAround.Click += BtnGoAround_Click;
        }

        private void BtnUseItem_Click(object sender, EventArgs e)
        {
            if (cmbInventory.SelectedItem == null)
            {
                MessageBox.Show("Please select an item first!", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = cmbInventory.SelectedItem.ToString();

            if ((obstacle.Key == "Locked Gate" && selectedItem == "Key") ||
                (obstacle.Key == "River" && selectedItem == "Boat") ||
                (obstacle.Key == "Landslide" && selectedItem == "Shovel") ||
                (obstacle.Key == "Bottomless Chasm" && selectedItem == "Rope") ||
                (obstacle.Key == "Sleeping Dragon" && selectedItem == "Wings"))
            {
                MessageBox.Show($"The {selectedItem} worked! You overcame the obstacle!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Overcome = true;
            }
            else
            {
                MessageBox.Show($"{selectedItem} doesn't seem effective here.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnGoAround_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (random.Next(0, 2) == 1) // 50% chance
            {
                MessageBox.Show("You successfully went around the obstacle!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Overcome = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Going around didn't work this time.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

