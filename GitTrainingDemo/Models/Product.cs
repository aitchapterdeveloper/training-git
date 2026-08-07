using System;

namespace GitTrainingDemo.Models
{
    public class Product
    {
        public string Name { get; set; }
        protected decimal _price;
        private DateTime _createdAt;

        public Product(string name)
        {
            Name = name;
            _createdAt = DateTime.Now;
        }

        public decimal Price
        {
            get {  return _price; }
            set {
                SetPrice(value);
            }
        }

        protected void SetPrice (decimal value)
        {
            if (value > 0)
                _price = value;
        }

        public DateTime CreatedAt {
            get { return _createdAt; }
        }

        public virtual void GetDescription ()
        {
            Console.WriteLine("A generic product");
        }
    }

    public class PotatoChips : Product
    {
        public string Flavor { get; set; }

        public PotatoChips(string name, string flavor):base(name) 
        {   
            Flavor = flavor;
        }

        public override void GetDescription()
        {
            Console.WriteLine("Potato chips");
        }
    }
}