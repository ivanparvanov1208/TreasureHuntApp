using System;
using System.Windows.Forms;

namespace TreasureHuntApp.ObjectForms
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            lblTitle.Text = "Treasure Hunt Adventure Help";
            txtHelp.Text = @"Welcome to Treasure Hunt Adventure!

Game Objective:
Find all 5 hidden treasures scattered across 15 different
locations. Explore each location to discover treasures,
solve puzzles, and overcome obstacles.

How to Play:
1. Click 'Explore' to investigate your current location
2. Check 'Map' to see all available locations
3. View 'Inventory' to see items you've collected
4. Some locations contain obstacles or puzzles you'll 
   need to overcome to find the treasure

Controls:
- Explore Button: Investigate current location
- Inventory Button: View collected treasures and items
- Map Button: View world map and travel to other locations
- Help Button: View this help screen

Tips:
1. Some obstacles require specific items to overcome
2. Puzzles have clues in their descriptions
3. Some locations may hide multiple items
4. You can return to previously visited locations

Good luck on your treasure hunt!";

            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
