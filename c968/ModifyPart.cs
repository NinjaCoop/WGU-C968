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
    public partial class ModifyPartScreen : Form
    {
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];

        public ModifyPartScreen(InHousePart inPart)
        {
            InitializeComponent();

            ModPartIDBoxText = inPart.PartID;
            ModPartNameBoxText = inPart.Name;
            ModPartInvBoxText = inPart.InStock;
            ModPartPriceBoxText = decimal.Parse(inPart.Price.Substring(1));
            ModPartMaxBoxText = inPart.Max;
            ModPartMinBoxText = inPart.Min;
            ModPartMachComBoxText = inPart.MachineID.ToString();
        }
        public ModifyPartScreen(OutsourcedPart outPart)
        {
            InitializeComponent();

            ModPartIDBoxText = outPart.PartID;
            ModPartNameBoxText = outPart.Name;
            ModPartInvBoxText = outPart.InStock;
            ModPartPriceBoxText = decimal.Parse(outPart.Price.Substring(1));
            ModPartMaxBoxText = outPart.Max;
            ModPartMinBoxText = outPart.Min;
            ModPartMachComBoxText = outPart.CompanyName;

            radioModOutsourced.Checked = true;
        }

        // TEST - SAVED DATA IS BOUND IN LIST
        private void btnModPartSave_Click(object sender, EventArgs e)
        {
            // Exception Control Set 1.3
            if (ModPartMaxBoxText < ModPartMinBoxText)
            {
                MessageBox.Show("Minimum cannot be greate than the Maximum.");
                return;
            }

            if (radioModInhouse.Checked)
            {
                InHousePart inHouse = new InHousePart(ModPartIDBoxText, ModPartNameBoxText, ModPartInvBoxText, ModPartPriceBoxText, ModPartMaxBoxText, ModPartMinBoxText, int.Parse(ModPartMachComBoxText));
                Inventory.UpdateInHousePart(ModPartIDBoxText, inHouse);
                radioModInhouse.Checked = true;
            }
            else
            {
                OutsourcedPart outSourced = new OutsourcedPart(ModPartIDBoxText, ModPartNameBoxText, ModPartInvBoxText, ModPartPriceBoxText, ModPartMaxBoxText, ModPartMinBoxText, ModPartMachComBoxText);
                Inventory.UpdateOutsourcedPart(ModPartIDBoxText, outSourced);
                radioModOutsourced.Checked = true;
            }
            this.Close();

            MainForm.MainScreenFormLoad();
            MainForm.mainPartsGrid.Update();
            MainForm.mainPartsGrid.Refresh();
        }

        // Change final textbox to appropriate type by radio button change
        private void radioModOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Company Name";
        }
        private void radioModInhouse_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Machine ID";
        }

        private void btnModPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
