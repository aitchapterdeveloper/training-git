namespace GitTrainingDemo.Services
{
    public class Animal
    {
        protected string Name;
        protected int Age;

        public virtual string MakeSound()
        {
            return "Animal Sound";
        }
    }

    public class Dog : Animal
    {
        private string Breed;

        public Dog(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public override string MakeSound()
        {
            return "Whoop Whoop Whoop!!!";
        }
    }


    public class Cat : Animal
    {
        private string Breed;

        public Cat(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public override string MakeSound()
        {
            return "Miaw Miaw Miaw!!!";
        }
    }
}