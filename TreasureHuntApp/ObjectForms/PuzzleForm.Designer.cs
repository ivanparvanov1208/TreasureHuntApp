namespace TreasureHuntApp.ObjectForms
{
    partial class PuzzleForm
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
            txtAnswer = new TextBox();
            btnSubmit = new Button();
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
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Arial", 12F);
            txtAnswer.Location = new Point(20, 100);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(751, 30);
            txtAnswer.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.LightGreen;
            btnSubmit.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnSubmit.Location = new Point(318, 154);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 40);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit Answer";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // PuzzleForm
            // 
            ClientSize = new Size(783, 300);
            Controls.Add(btnSubmit);
            Controls.Add(txtAnswer);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PuzzleForm";
            Text = "Puzzle";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmit;
    }
}
