using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c968
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        public static void PopulateDummyLists()
        {
            Product dummyProd1 = new Product(1, "Product 1", 10, 12.00m, 20, 5);
            Product dummyProd2 = new Product(2, "Product 2", 10, 8.00m, 25, 5);
            Product dummyProd3 = new Product(3, "Product 3", 10, 5m, 25, 5);
            Product dummyProd4 = new Product(4, "Product 4", 10, 3m, 25, 5);

            Products.Add(dummyProd1);
            Products.Add(dummyProd2);
            Products.Add(dummyProd3);
            Products.Add(dummyProd4);

            // add mach ids and comp names
            Part dummyPart1A = new InHousePart(1, "Part 1.A", 15, 15.00m, 30, 10, 9001);
            Part dummyPart1B = new InHousePart(2, "Part 1.B", 10, 12.00m, 25, 10, 9001);
            Part dummyPart2A = new InHousePart(3, "Part 2.A", 12, 10.00m, 25, 10, 9002);
            Part dummyPart2B = new InHousePart(4, "Part 2.B", 15, 5.00m, 25, 10, 9002);
            Part dummyPart3A = new OutsourcedPart(5, "Part 3.A", 15, 15.00m, 30, 10, "ShopCorp");
            Part dummyPart3B = new OutsourcedPart(6, "Part 3.B", 10, 12.00m, 25, 10, "ShopCorp");
            Part dummyPart4A = new OutsourcedPart(7, "Part 4.A", 12, 10.00m, 25, 10, "PPI, LLC");
            Part dummyPart4B = new OutsourcedPart(8, "Part 4.B", 15, 5.00m, 25, 10, "PPI, LLC");

            Parts.Add(dummyPart1A);
            Parts.Add(dummyPart1B);
            Parts.Add(dummyPart2A);
            Parts.Add(dummyPart2B);
            Parts.Add(dummyPart3A);
            Parts.Add(dummyPart3B);
            Parts.Add(dummyPart4A);
            Parts.Add(dummyPart4B);

            // Add parts to respective Products
            dummyProd1.AssociatedParts.Add(dummyPart1A);
            dummyProd1.AssociatedParts.Add(dummyPart1B);
            dummyProd2.AssociatedParts.Add(dummyPart2A);
            dummyProd2.AssociatedParts.Add(dummyPart2B);
            dummyProd3.AssociatedParts.Add(dummyPart3A);
            dummyProd3.AssociatedParts.Add(dummyPart3B);
            dummyProd4.AssociatedParts.Add(dummyPart4A);
            dummyProd4.AssociatedParts.Add(dummyPart4B);
        }

        // Products Methods
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        // TO TEST
        public bool RemoveProduct(int productID)
        {
            bool success = false;
            foreach (Product prod in Products)
            {
                if (productID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("Removal failed.");
                    return false;
                }
            }
            return success;
        }

        // TO FINISH - not all paths return a value
        public static Product LookupProduct(int productID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    return prod;
                }
            }
            Product emptyProd = new c968.Product();
            return emptyProd;
        }

        // TO TEST
        public static void UpdateProduct(int productID, Product updatedProd)
        {
            foreach (Product currentProd in Products)
            {
                if (currentProd.ProductID == productID)
                {
                    currentProd.Name = updatedProd.Name;
                    currentProd.InStock = updatedProd.InStock;
                    currentProd.Price = updatedProd.Price;
                    currentProd.Max = updatedProd.Max;
                    currentProd.Min = updatedProd.Min;
                    return;
                }
            }

        }

        // Parts Methods
        public static void AddPart(Part part)
        {
            Parts.Add(part);   
        }

        // TO TEST
        public bool DeletePart(Part part)
        {
            try
            {
                Parts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // TO FINISH - not all paths return a value
        public static Part LookupPart(int partID)
        {
            foreach (Part part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
                else
                {
                    MessageBox.Show("No matches found.");
                }
            }
            Part emptyPart = new InHousePart();
            return emptyPart;
        }

        // TO TEST - MODIFY PART
        public static void UpdatePart(int partID, Part part)
        {
            foreach (Part updatedPart in Parts)
            {
                if (updatedPart.PartID == partID)
                {
                    updatedPart.Name = part.Name;
                    updatedPart.InStock = part.InStock;
                    updatedPart.Price = part.Price;
                    updatedPart.Max = part.Max;
                    updatedPart.Min = part.Min;
                    return;
                }
            }
        }
    }
}
