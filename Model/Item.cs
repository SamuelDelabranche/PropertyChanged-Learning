using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChanged.Model
{
    public class Item
    {
        public Item(string name, string serialNumber, int quantity)
        {
            Name = name;
            SerialNumber = serialNumber;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int Quantity { get; set; }
    }
}
