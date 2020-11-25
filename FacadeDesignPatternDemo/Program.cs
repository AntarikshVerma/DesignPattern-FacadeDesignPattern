using System;

namespace FacadeDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFacade facade = new CarFacade();
            facade.CreateCompleteCar();
            Console.ReadLine();

        }
    }
}
