using System;
using System.Windows.Forms;
using GoldenQuest.ClassFiles;

namespace GoldenQuest.ObjectForms
{
    public partial class PuzzleForm : Form
    {
        public bool Solved { get; private set; } = false;
        private Puzzle puzzle;

        public PuzzleForm(Puzzle puzzle)
        {
            InitializeComponent();
            this.puzzle = puzzle;

            lblTitle.Text = $"Puzzle: {puzzle.Name}";
            lblDescription.Text = puzzle.Description;

            btnSubmit.Click += BtnSubmit_Click;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (puzzle.Name == "Aaah a riddle... Could you help me solve it?" && txtAnswer.Text.ToLower().Contains("keyhole"))
            {
                Solved = true;
            }
            else if (puzzle.Name == "Riddle" && txtAnswer.Text.ToLower().Contains("book"))
            {
                Solved = true;
            }
            else if (puzzle.Name == "Here we go, a riddle" && txtAnswer.Text.ToLower().Contains("man"))
            {
                Solved = true;
            }
            else
            {
                MessageBox.Show("That doesn't seem correct. Try again!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

