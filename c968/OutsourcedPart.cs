using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c968
{
    public class OutsourcedPart : Part
    {
        private string companyName;

        public string CompanyName { get; set; }

        // Create Constructor
        public OutsourcedPart() { }
        public OutsourcedPart(int partID, string name, int inStock, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = max;
        }

        public OutsourcedPart(int partID, string name, int inStock, decimal price, int max, int min, string compName)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = max;
            CompanyName = compName;
        }
    }
}
