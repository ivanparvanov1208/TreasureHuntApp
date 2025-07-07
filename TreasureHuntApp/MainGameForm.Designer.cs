namespace TreasureHuntApp
{
    partial class MainGameForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblLocation = new Label();
            locationImage = new PictureBox();
            btnExplore = new Button();
            btnInventory = new Button();
            btnMap = new Button();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)locationImage).BeginInit();
            SuspendLayout();
            // 
            // lblLocation
            // 
            lblLocation.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblLocation.ForeColor = Color.DarkBlue;
            lblLocation.Location = new Point(25, 20);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(750, 40);
            lblLocation.TabIndex = 0;
            lblLocation.TextAlign = ContentAlignment.MiddleCenter;
            lblLocation.Click += lblLocation_Click;
            // 
            // locationImage
            // 
            locationImage.BorderStyle = BorderStyle.FixedSingle;
            locationImage.Image = Properties.Resources.ruins;
            locationImage.Location = new Point(100, 70);
            locationImage.Name = "locationImage";
            locationImage.Size = new Size(600, 400);
            locationImage.SizeMode = PictureBoxSizeMode.Zoom;
            locationImage.TabIndex = 1;
            locationImage.TabStop = false;
            // 
            // btnExplore
            // 
            btnExplore.BackColor = Color.LightGreen;
            btnExplore.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnExplore.Location = new Point(100, 500);
            btnExplore.Name = "btnExplore";
            btnExplore.Size = new Size(150, 50);
            btnExplore.TabIndex = 2;
            btnExplore.Text = "Explore";
            btnExplore.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.LightGoldenrodYellow;
            btnInventory.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnInventory.Location = new Point(300, 500);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(150, 50);
            btnInventory.TabIndex = 3;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnMap
            // 
            btnMap.BackColor = Color.LightSkyBlue;
            btnMap.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnMap.Location = new Point(500, 500);
            btnMap.Name = "btnMap";
            btnMap.Size = new Size(150, 50);
            btnMap.TabIndex = 4;
            btnMap.Text = "Map";
            btnMap.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.LightGray;
            btnHelp.Font = new Font("Arial", 9F);
            btnHelp.Location = new Point(710, 20);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(80, 30);
            btnHelp.TabIndex = 5;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            // 
            // MainGameForm
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(btnHelp);
            Controls.Add(btnMap);
            Controls.Add(btnInventory);
            Controls.Add(btnExplore);
            Controls.Add(locationImage);
            Controls.Add(lblLocation);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainGameForm";
            Text = "Treasure Hunt Adventure";
            ((System.ComponentModel.ISupportInitialize)locationImage).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox locationImage;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnHelp;
    }
}
