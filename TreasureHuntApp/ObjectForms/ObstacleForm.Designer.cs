namespace TreasureHuntApp.ObjectForms
{
    partial class ObstacleForm
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
            lblTitle = new Label();
            lblDescription = new Label();
            cmbInventory = new ComboBox();
            btnUseItem = new Button();
            btnGoAround = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 32);
            lblTitle.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Arial", 12F);
            lblDescription.Location = new Point(20, 60);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 23);
            lblDescription.TabIndex = 1;
            // 
            // cmbInventory
            // 
            cmbInventory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInventory.Font = new Font("Arial", 12F);
            cmbInventory.FormattingEnabled = true;
            cmbInventory.Location = new Point(20, 100);
            cmbInventory.Name = "cmbInventory";
            cmbInventory.Size = new Size(200, 31);
            cmbInventory.TabIndex = 2;
            // 
            // btnUseItem
            // 
            btnUseItem.BackColor = Color.LightSkyBlue;
            btnUseItem.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUseItem.Location = new Point(20, 150);
            btnUseItem.Name = "btnUseItem";
            btnUseItem.Size = new Size(150, 40);
            btnUseItem.TabIndex = 3;
            btnUseItem.Text = "Use Selected Item";
            btnUseItem.UseVisualStyleBackColor = false;
            // 
            // btnGoAround
            // 
            btnGoAround.BackColor = Color.LightSalmon;
            btnGoAround.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnGoAround.Location = new Point(200, 150);
            btnGoAround.Name = "btnGoAround";
            btnGoAround.Size = new Size(150, 40);
            btnGoAround.TabIndex = 4;
            btnGoAround.Text = "Try to Go Around";
            btnGoAround.UseVisualStyleBackColor = false;
            // 
            // ObstacleForm
            // 
            ClientSize = new Size(500, 300);
            Controls.Add(btnGoAround);
            Controls.Add(btnUseItem);
            Controls.Add(cmbInventory);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ObstacleForm";
            Text = "Obstacle";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbInventory;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.Button btnGoAround;
    }
}
