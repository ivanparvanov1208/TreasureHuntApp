using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GoldenQuest.ObjectForms
{
    public partial class InventoryForm : Form
    {
        public InventoryForm(List<string> inventory)
        {
            InitializeComponent();

            lstInventory.Items.AddRange(inventory.ToArray());
            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

