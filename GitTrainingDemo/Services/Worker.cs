using System;

namespace GitTrainingDemo.Services{
    interface IWorkable
    {
        void doWork();
    }

    interface ISleep
    {
        void sleep();
    }

    interface IEat
    {
        void eat();
    }

    class HumanWorker(string name) : IWorkable, IEat, ISleep
    {   
        string name = name;
        public void doWork()
        {
            Console.WriteLine($"{name} working for 9 to 5");
        }

        public void eat()
        {
            Console.WriteLine($"{name} eat soto ayam bu carti");            
        }

        public void sleep()
        {
            Console.WriteLine($"{name} sleeps for 8 hours");
        }
    }

    class UndeadWorker(string name) : IWorkable
    {
        string name = name;
        public void doWork()
        {
            Console.WriteLine($"The corpse of {name} is working tirelessly");
        }
    }
}