using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TreasureHuntApp.ClassFiles;

namespace TreasureHuntApp.ObjectForms
{
    public partial class MapForm : Form
    {
        public int SelectedLocationIndex { get; private set; } = -1;
        private List<Button> locationButtons = new List<Button>();
        private List<Location> locations;
        private int currentLocationIndex;

        public MapForm(List<Location> locations, int currentLocationIndex)
        {
            InitializeComponent();

            this.locations = locations;
            this.currentLocationIndex = currentLocationIndex;
            CreateMapButtons();

            btnClose.Click += BtnClose_Click;
            btnSelect.Click += BtnSelect_Click;
        }

        private void CreateMapButtons()
        {
            // Column 1
            CreateLocationButton(0, 100, 100, Color.Red);
            CreateLocationButton(1, 100, 250, Color.LightBlue);
            CreateLocationButton(2, 100, 400, Color.LightYellow);

            // Column 2
            CreateLocationButton(3, 300, 50, Color.LightPink);
            CreateLocationButton(4, 300, 200, Color.LightSlateGray);
            CreateLocationButton(5, 300, 350, Color.LightSeaGreen);
            CreateLocationButton(6, 300, 500, Color.LightSteelBlue);

            // Column 3
            CreateLocationButton(7, 500, 100, Color.LightGoldenrodYellow);
            CreateLocationButton(8, 500, 250, Color.LightSalmon);
            CreateLocationButton(9, 500, 400, Color.LightSkyBlue);

            // Column 4
            CreateLocationButton(10, 700, 50, Color.LightCoral);
            CreateLocationButton(11, 700, 200, Color.LightGray);
            CreateLocationButton(12, 700, 350, Color.LightGreen);

            // Column 5
            CreateLocationButton(13, 900, 100, Color.LightCyan);
            CreateLocationButton(14, 900, 250, Color.LightPink);
        }

        private void CreateLocationButton(int index, int x, int y, Color color)
        {
            Button btn = new Button()
            {
                Text = locations[index].Name,
                Size = new Size(150, 60),
                Location = new Point(x, y),
                Font = new Font("Arial", 10),
                BackColor = index == currentLocationIndex ? Color.Green : color,
                Tag = index
            };
            btn.Click += LocationButton_Click;
            locationButtons.Add(btn);
            this.Controls.Add(btn);
        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            foreach (Button btn in locationButtons)
            {
                btn.BackColor = (int)btn.Tag == currentLocationIndex ? Color.Green : Color.LightBlue;
            }
            clickedButton.BackColor = Color.Red;
            SelectedLocationIndex = (int)clickedButton.Tag;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (SelectedLocationIndex >= 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a location first!", "No Location Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            SelectedLocationIndex = currentLocationIndex;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

