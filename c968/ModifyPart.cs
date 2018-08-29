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
        public ModifyPartScreen(Part selectedPart)
        {
            InitializeComponent();
            LoadSelectedPartData(selectedPart);
        }
        public void LoadSelectedPartData(Part part)
        {
            //TODO - ADD MACH ID OR COMP NAME
            ModPartIDBoxText = part.PartID;
            ModPartNameBoxText = part.Name;
            ModPartInvBoxText = part.InStock;
            ModPartPriceBoxText = part.Price;
            ModPartMaxBoxText = part.Max;
            ModPartMinBoxText = part.Min;
            //ModPartMachComBoxText = part.;
        }

        // TEST - SAVED DATA IS BOUND IN LIST
        private void btnModPartSave_Click(object sender, EventArgs e)
        {
            if (radioModInhouse.Checked)
            {
                InHousePart inHouse = new InHousePart(ModPartIDBoxText, ModPartNameBoxText, ModPartInvBoxText, ModPartPriceBoxText, ModPartMaxBoxText, ModPartMinBoxText, int.Parse(ModPartMachComBoxText));
                Inventory.UpdatePart(ModPartIDBoxText, inHouse);
            }
            else
            {
                OutsourcedPart outSourced = new OutsourcedPart(ModPartIDBoxText, ModPartNameBoxText, ModPartInvBoxText, ModPartPriceBoxText, ModPartMaxBoxText, ModPartMinBoxText, ModPartMachComBoxText);
                Inventory.UpdatePart(ModPartIDBoxText, outSourced);
            }
            this.Close();
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

        public bool IsPartValid()
        {
            //Check if the part entry is valid - and also whether this method is necessary
            return true;
        }
    }
}
