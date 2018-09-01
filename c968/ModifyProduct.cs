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
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];

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
            ModProdPriceBoxText = decimal.Parse(selectedProd.Price.Substring(1));
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search by part ID
            int searchValue = int.Parse(searchBoxModProd.Text);

            Part match = Inventory.LookupPart(searchValue);

            foreach(DataGridViewRow row in modifyProductGrid1.Rows)
            {
                Part part = (Part)row.DataBoundItem;

                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)modifyProductGrid1.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);
        }

        private void btnSaveModProduct_Click(object sender, EventArgs e)
        {
            // Exception Control Set 1.3
            if (ModProdMaxBoxText < ModProdMinBoxText)
            {
                MessageBox.Show("Minimum cannot be greate than the Maximum.");
                return;
            }

            Product updatedProduct = new Product(ModProdIDBoxText, ModProdNameBoxText, ModProdInvBoxText, ModProdPriceBoxText, ModProdMaxBoxText, ModProdMinBoxText);

            foreach (Part newPart in partsToAdd)
            {
                updatedProduct.AddAssociatedPart(newPart);
            }

            Inventory.UpdateProduct(ModProdIDBoxText, updatedProduct);
            this.Close();

            MainForm.MainScreenFormLoad();
            MainForm.mainProductsGrid.Update();
            MainForm.mainProductsGrid.Refresh();
        }

        private void btnCancelModProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
