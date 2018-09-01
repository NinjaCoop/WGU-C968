using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c968
{
    public class InHousePart : Part
    {
        private int machineID;

        public int MachineID { get; set; }

        // Create Constructor

        public InHousePart() { }
        public InHousePart(int partID, string name, int inStock, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = max;
        }

        public InHousePart(int partID, string name, int inStock, decimal price, int max, int min, int machineID)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = max;
            MachineID = machineID;
        }
    }
}
