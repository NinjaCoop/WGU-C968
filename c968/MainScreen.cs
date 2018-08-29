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

        // TEST - BINDINGS UPDATE PROPERLY
        public void MainScreenFormLoad()
        {
            // Pre-populate the lists with dummy data
            Inventory.PopulateDummyLists();

            // All parts in inventory show in the left table
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

        // Redirect Button Functionalities
        private void btnAddPart_Click(object sender, EventArgs e)
        {   
            new AddPartScreen().ShowDialog();
        }

        // TEST - DETERMINE INHOUSE v OUTSOURCED
        private void btnModifyPart_Click(object sender, EventArgs e)
        {

            Part selectedPart = (Part)mainPartsGrid.CurrentRow.DataBoundItem;
            new ModifyPartScreen(selectedPart).ShowDialog();
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

        // Action Button Functionalities
        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this part?");                  // Confirm deletion of part
            foreach (DataGridViewRow row in mainPartsGrid.SelectedRows)
            {
                mainPartsGrid.Rows.RemoveAt(row.Index);
            }
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in mainProductsGrid.SelectedRows)
            {
                mainProductsGrid.Rows.RemoveAt(row.Index);
            }
        }

        private void btnPartsSearch_Click(object sender, EventArgs e)
        {
            // Do nothing if search box is empty
            if (searchBoxPartsText < 1)
                return;

            Part match = Inventory.LookupPart(searchBoxPartsText);
            //take the returned part and show it in DataGridView
        }


        // TO TEST - LE SEARCH - SEARCH CURRENTLY WORKING ONLY ON SELECTED ROW WITH SAME ID #
        private void btnProductsSearch_Click(object sender, EventArgs e)
        {
            // Do nothing if search box is empty
            if (searchBoxProductsText < 1)
                return;

            Product match = Inventory.LookupProduct(searchBoxProductsText);
            int searchID = match.ProductID;
            //take the returned product and show it in DataGridView
            foreach(DataGridViewRow row in mainProductsGrid.Rows)
            {
                Product prod = (Product)row.DataBoundItem;
                //filter the rows
                if (prod.ProductID == searchID)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
