using System;
using GitTrainingDemo.Interfaces;

namespace GitTrainingDemo.Services
{
    public class RegularDiscount : IDiscount
    {
        public double Apply(double price) => price * 0.9;
    }

    public class VIPDiscount : IDiscount
    {
        public double Apply(double price) => price * 0.8;
    }
}