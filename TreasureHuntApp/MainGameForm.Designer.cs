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
            this.lblLocation = new System.Windows.Forms.Label();
            this.locationImage = new System.Windows.Forms.PictureBox();
            this.btnExplore = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.locationImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLocation.Location = new System.Drawing.Point(25, 20);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(750, 40);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationImage
            // 
            this.locationImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationImage.Location = new System.Drawing.Point(100, 70);
            this.locationImage.Name = "locationImage";
            this.locationImage.Size = new System.Drawing.Size(600, 400);
            this.locationImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.locationImage.TabIndex = 1;
            this.locationImage.TabStop = false;
            // 
            // btnExplore
            // 
            this.btnExplore.BackColor = System.Drawing.Color.LightGreen;
            this.btnExplore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExplore.Location = new System.Drawing.Point(100, 500);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(150, 50);
            this.btnExplore.TabIndex = 2;
            this.btnExplore.Text = "Explore";
            this.btnExplore.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnInventory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInventory.Location = new System.Drawing.Point(300, 500);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(150, 50);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMap.Location = new System.Drawing.Point(500, 500);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(150, 50);
            this.btnMap.TabIndex = 4;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.LightGray;
            this.btnHelp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.Location = new System.Drawing.Point(710, 20);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(80, 30);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // MainGameForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.locationImage);
            this.Controls.Add(this.lblLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainGameForm";
            this.Text = "Treasure Hunt Adventure";
            ((System.ComponentModel.ISupportInitialize)(this.locationImage)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox locationImage;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnHelp;
    }
}
