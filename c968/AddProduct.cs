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

        // TEST - SEARCH BUTTON
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = searchBoxAddProd.Text;
            foreach (DataGridViewRow row in addProductGrid1.Rows)
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
            Part partToAdd = (Part)addProductGrid1.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product productToAdd = new Product((Inventory.Products.Count + 1), AddProdNameBoxText, AddProdInvBoxText, AddProdPriceBoxText, AddProdMaxBoxText, AddProdMinBoxText);
            Inventory.AddProduct(productToAdd);

            // Loop through the lower table to add parts to the given Product's associated parts list.
            foreach(DataGridViewRow row in addProductGrid2.Rows)
            {
                Part newPart = (Part)row.DataBoundItem;
                productToAdd.AddAssociatedPart(newPart);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
