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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            MainScreenFormLoad();
        }

        public void MainScreenFormLoad()
        {
            // Pre-populate the lists with dummy data
            Inventory.PopulateDummyLists();

            // All Parts in inventory show in the left table
            var bsPart = new BindingSource();
            bsPart.DataSource = Inventory.Parts;
            mainPartsGrid.DataSource = bsPart;

            mainPartsGrid.Columns["PartID"].HeaderText = "Part ID";
            mainPartsGrid.Columns["Name"].HeaderText = "Part Name";
            mainPartsGrid.Columns["InStock"].HeaderText = "Inventory";
            mainPartsGrid.Columns["Price"].HeaderText = "Price/Cost per Unit";
            mainPartsGrid.Columns["Max"].Visible = false;
            mainPartsGrid.Columns["Min"].Visible = false;

            // All Products in inventory show in the right table
            var bsProd = new BindingSource();
            bsProd.DataSource = Inventory.Products;
            mainProductsGrid.DataSource = bsProd;

            mainProductsGrid.Columns["ProductID"].HeaderText = "Product ID";
            mainProductsGrid.Columns["Name"].HeaderText = "Product Name";
            mainProductsGrid.Columns["InStock"].HeaderText = "Inventory";
            mainProductsGrid.Columns["Price"].HeaderText = "Price/Cost per Unit";
            mainProductsGrid.Columns["Max"].Visible = false;
            mainProductsGrid.Columns["Min"].Visible = false;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {   
            new AddPartScreen().ShowDialog();
        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            // Opens the modify parts screen with selected part after checking part type
            if(mainPartsGrid.CurrentRow.DataBoundItem.GetType() == typeof(c968.InHousePart))
            {
                InHousePart inPart = (InHousePart)mainPartsGrid.CurrentRow.DataBoundItem;
                new ModifyPartScreen(inPart).ShowDialog();
            }
            else
            {
                OutsourcedPart outPart = (OutsourcedPart)mainPartsGrid.CurrentRow.DataBoundItem;
                new ModifyPartScreen(outPart).ShowDialog();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)mainProductsGrid.CurrentRow.DataBoundItem;
            new AddProductScreen().ShowDialog();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)mainProductsGrid.CurrentRow.DataBoundItem;
            new ModifyProductScreen(selectedProduct).ShowDialog();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in mainPartsGrid.SelectedRows)
            {
                mainPartsGrid.Rows.RemoveAt(row.Index);
            }
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Exception Control Set 2.1
            Product prod = (Product)mainProductsGrid.CurrentRow.DataBoundItem;
            if (prod.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete a Product with a part assigned to it.\nPlease removed assigned parts.");
                return;
            }

            foreach (DataGridViewRow row in mainProductsGrid.SelectedRows)
            {
                mainProductsGrid.Rows.RemoveAt(row.Index);
            }
        }

        private void btnPartsSearch_Click(object sender, EventArgs e)
        {
            if (searchBoxPartsText < 1)
                return;

            Part match = Inventory.LookupPart(searchBoxPartsText);

            // Take the returned part and show it in DataGridView
            foreach(DataGridViewRow row in mainPartsGrid.Rows)
            {
                Part part = (Part)row.DataBoundItem;

                if(part.PartID == match.PartID)
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

        private void btnProductsSearch_Click(object sender, EventArgs e)
        {
            if (searchBoxProductsText < 1)
                return;

            Product match = Inventory.LookupProduct(searchBoxProductsText);

            // Take the returned product and show it in DataGridView
            foreach (DataGridViewRow row in mainProductsGrid.Rows)
            {
                Product prod = (Product)row.DataBoundItem;

                if (prod.ProductID == match.ProductID)
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
