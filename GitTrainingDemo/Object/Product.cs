using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Object
{
    public class Product
    {
        public string Name{ get; set; }
        public int Price { get; set; }
        private int _stock { get; set; }
        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value >= 0)
                {
                    _stock = value;
                }
            }
        }


        public Product(string name, int price, int stock)
        {
            Name = name;
            Price = price;
            if (_stock >= 0) Stock = stock;
        }
    }
}
