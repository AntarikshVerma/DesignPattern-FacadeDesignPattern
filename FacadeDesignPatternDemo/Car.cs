using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPatternDemo
{
    public class CreateBody
    {
        public void BodyCreation()
        {
            Console.WriteLine("The body has created");
        }
    }

    public class CreateEngine
    {
        public void EngineCreation()
        {
            Console.WriteLine("The Engine has created");
        }
    }

    public class CreateInterior
    {
        public void InteriorCreation()
        {
            Console.WriteLine("The Interior has created");
        }
    }

}
