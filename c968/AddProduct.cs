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
    public partial class AddProductScreen : Form
    {
        BindingList<Part> partsToAdd = new BindingList<Part>();
        public AddProductScreen()
        {
            InitializeComponent();
            AddProductScreenLoad();
        }
        
        public void AddProductScreenLoad()
        {
            // The top table contains a list of all parts
            var bs1 = new BindingSource();
            bs1.DataSource = Inventory.Parts;
            addProductGrid1.DataSource = bs1;
            addProductGrid1.Columns["PartID"].HeaderText = "Part ID";
            addProductGrid1.Columns["Name"].HeaderText = "Part Name";
            addProductGrid1.Columns["InStock"].HeaderText = "Inventory Level";
            addProductGrid1.Columns["Price"].HeaderText = "Price per Unit";
            addProductGrid1.Columns["Max"].Visible = false;
            addProductGrid1.Columns["Min"].Visible = false;

            // The lower table contains all parts belonging to the selected Product from the main screen
            var bs2 = new BindingSource();
            bs2.DataSource = partsToAdd;
            addProductGrid2.DataSource = bs2;
            addProductGrid2.Columns["PartID"].HeaderText = "Part ID";
            addProductGrid2.Columns["Name"].HeaderText = "Part Name";
            addProductGrid2.Columns["InStock"].HeaderText = "Inventory Level";
            addProductGrid2.Columns["Price"].HeaderText = "Price per Unit";
            addProductGrid2.Columns["Max"].Visible = false;
            addProductGrid2.Columns["Min"].Visible = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in addProductGrid2.SelectedRows)
            {
                addProductGrid2.Rows.RemoveAt(row.Index);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchValue = int.Parse(searchBoxAddProd.Text);

            Part match = Inventory.LookupPart(searchValue);

            foreach (DataGridViewRow row in addProductGrid1.Rows)
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
            Part partToAdd = (Part)addProductGrid1.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Exception Control Set 1.3
            if (AddProdMaxBoxText < AddProdMinBoxText)
            {
                MessageBox.Show("Minimum cannot be greate than the Maximum.");
                return;
            }

            // Creates new product with given values from textboxes and adds that product to the inventory.
            Product productToAdd = new Product((Inventory.Products.Count + 1), AddProdNameBoxText, AddProdInvBoxText, AddProdPriceBoxText, AddProdMaxBoxText, AddProdMinBoxText);
            Inventory.AddProduct(productToAdd);

            foreach(Part part in partsToAdd)
            {
                productToAdd.AddAssociatedPart(part);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
