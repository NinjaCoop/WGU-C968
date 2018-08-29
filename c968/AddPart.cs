using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c968
{
    public partial class AddPartScreen : Form
    {
        public AddPartScreen()
        {
            InitializeComponent();
        }

        // Convert price from double to decimal?
        // TO TEST
        private void btnAddPartSave_Click(object sender, EventArgs e)
        {
            if (radioAddInHouse.Checked)
            {
                Part inHouse = new InHousePart((Inventory.Parts.Count + 1), AddPartNameBoxText, AddPartInvBoxText, AddPartPriceBoxText, AddPartMaxBoxText, AddPartMinBoxText, int.Parse(AddPartMachComBoxText));
                Inventory.AddPart(inHouse);
            }
            else
            {
                Part outsourced = new OutsourcedPart((Inventory.Parts.Count + 1), AddPartNameBoxText, AddPartInvBoxText, AddPartPriceBoxText, AddPartMaxBoxText, AddPartMinBoxText, AddPartMachComBoxText);
                Inventory.AddPart(outsourced);
            }
            this.Close();
        }

        // Radio buttons determine whether part in made in-house or outsourced
        private void radioAddOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Company Name";
            addPartMachComBox.Text = "Comp Nm";
        }
        private void radioAddInHouse_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Machine ID";
            addPartMachComBox.Text = "Mach ID";
        }

        private void btnAddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public void RemoveText(object sender, EventArgs e)
        //{
        //    addPartMachComBox.Text = "";
        //}
    }
}
