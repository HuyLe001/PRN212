using System;
using System.Collections.Generic;
namespace Baitap5
{
    // Interface cho động vật
    internal interface IAnimal
    {
        void AboutMe();
    }
    // Lớp Lion
    public class Lion : IAnimal
    {
        public void AboutMe() => Console.WriteLine("This is a Lion.");
    }
    // Lớp Tiger
    public class Tiger : IAnimal
    {
        public void AboutMe() => Console.WriteLine("This is a Tiger.");
    }
    // Abstract Class cho Factory
    internal abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
    // Factory cho Lion
    internal class LionFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Lion();
    }
    // Factory cho Tiger
    internal class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Tiger();
    }
}