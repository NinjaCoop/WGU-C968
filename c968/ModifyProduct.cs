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
    public partial class ModifyProductScreen : Form
    {
        BindingList<Part> partsToAdd = new BindingList<Part>();
        public ModifyProductScreen(Product prod)
        {
            InitializeComponent();
            ModifyProductScreenLoad(prod);
        }

        public void ModifyProductScreenLoad(Product selectedProd)
        {
            // The boxes on the left are pre-populated with selected Product data
            ModProdIDBoxText = selectedProd.ProductID;
            ModProdNameBoxText = selectedProd.Name;
            ModProdInvBoxText = selectedProd.InStock;
            ModProdPriceBoxText = selectedProd.Price;
            ModProdMaxBoxText = selectedProd.Max;
            ModProdMinBoxText = selectedProd.Min;

            // The top table contains a list of all parts
            var bs1 = new BindingSource();
            bs1.DataSource = Inventory.Parts;
            modifyProductGrid1.DataSource = bs1;
            modifyProductGrid1.Columns["PartID"].HeaderText = "Part ID";
            modifyProductGrid1.Columns["Name"].HeaderText = "Part Name";
            modifyProductGrid1.Columns["InStock"].HeaderText = "Inventory Level";
            modifyProductGrid1.Columns["Price"].HeaderText = "Price per Unit";
            modifyProductGrid1.Columns["Max"].Visible = false;
            modifyProductGrid1.Columns["Min"].Visible = false;

            // The lower table contains all parts belonging to the selected Product from the main screen
            foreach(Part part in selectedProd.AssociatedParts)
            {
                partsToAdd.Add(part);
            }

            var bs2 = new BindingSource();
            bs2.DataSource = partsToAdd;
            modifyProductGrid2.DataSource = bs2;
            modifyProductGrid2.Columns["PartID"].HeaderText = "Part ID";
            modifyProductGrid2.Columns["Name"].HeaderText = "Part Name";
            modifyProductGrid2.Columns["InStock"].HeaderText = "Inventory Level";
            modifyProductGrid2.Columns["Price"].HeaderText = "Price per Unit";
            modifyProductGrid2.Columns["Max"].Visible = false;
            modifyProductGrid2.Columns["Min"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Part currentPart = (Part)modifyProductGrid2.CurrentRow.DataBoundItem;

            int lookupID = this.ModProdIDBoxText;
            Product currentProd = Inventory.LookupProduct(lookupID);
            currentProd.RemoveAssociatedPart(currentPart.PartID);

            foreach (DataGridViewRow row in modifyProductGrid2.SelectedRows)
            {
                modifyProductGrid2.Rows.RemoveAt(row.Index);
            }
        }

        // FIX - SEARCH BUTTON
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = searchBoxModProd.Text;
            foreach(DataGridViewRow row in modifyProductGrid1.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(searchValue))
                {
                    row.Selected = true;
                    break;
                }
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)modifyProductGrid1.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);
            partsToAdd.ResetBindings();
        }

        private void btnSaveModProduct_Click(object sender, EventArgs e)
        {
            // This part of it works
            Product updatedProduct = new Product(ModProdIDBoxText, ModProdNameBoxText, ModProdInvBoxText, ModProdPriceBoxText, ModProdMaxBoxText, ModProdMinBoxText);

            // This isn't saving added parts to the product itself
            foreach (Part newPart in partsToAdd)
            {
                updatedProduct.AddAssociatedPart(newPart);
            }

            Inventory.UpdateProduct(ModProdIDBoxText, updatedProduct);
            this.Close();
        }

        private void btnCancelModProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
