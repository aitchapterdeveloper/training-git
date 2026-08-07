using System;

namespace GitTrainingDemo.Models
{
    public class Product
    {
        public string Name { get; set; }
        private int _price;
        private DateTime _createdAt;

        public Product(string name)
        {
            Name = name;
            _createdAt = DateTime.Now;
        }

        public int Price
        {
            get {  return _price; }
            set {
                if (value > 0)
                    _price = value;
            }
        }

        public DateTime CreatedAt {
            get { return _createdAt; }
        }
    }
}