using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GoldenQuest.ClassFiles;

namespace GoldenQuest.ObjectForms
{
    public partial class WinForm : Form
    {
        public WinForm(GameState gameState)
        {
            InitializeComponent();

            lblTitle.Text = "Congratulations!";
            lblSubtitle.Text = "You found all the treasures!";
            lstFoundTreasures.Items.AddRange(gameState.Inventory.ToArray());
            lblScore.Text = $"Time Taken: {(int)gameState.TotalGameTime.TotalMinutes} minutes";

            btnNewGame.Click += BtnNewGame_Click;
            btnQuit.Click += BtnQuit_Click;
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
