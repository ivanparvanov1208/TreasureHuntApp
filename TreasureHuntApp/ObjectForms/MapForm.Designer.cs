namespace GoldenQuest.ObjectForms
{
    partial class MapForm
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
            btnClose = new Button();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Arial", 12F);
            btnClose.Location = new Point(450, 600);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Arial", 12F);
            btnSelect.Location = new Point(300, 600);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(150, 40);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select Location";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // MapForm
            // 
            ClientSize = new Size(1169, 700);
            Controls.Add(btnSelect);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MapForm";
            Text = "World Map";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
    }
}
