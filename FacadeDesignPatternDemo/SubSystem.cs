using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPatternDemo
{
    //Class SubSystemA
    public class SubSystemA
    {
        public void MethodA()
        {
            Console.WriteLine("This is method A in SubSystemA Class ");
        }
    }

    //Class SubSystemB
    public class SubSystemB
    {
        public void MethodB()
        {
            Console.WriteLine("This is method B in SubSystemB Class ");
        }
    }

    //Class SubSystemC
    public class SubSystemC
    {
        public void MethodC()
        {
            Console.WriteLine("This is method C in SubSystemC Class");
        }
    }

}
