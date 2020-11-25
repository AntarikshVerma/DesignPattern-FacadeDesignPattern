using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPatternDemo
{
    public class FacadeUnifiedClass
    {
        private readonly SubSystemA _one;
        private readonly SubSystemB _two;
        private readonly SubSystemC _three;

        public FacadeUnifiedClass()
        {
            _one = new SubSystemA();
            _two = new SubSystemB();
            _three = new SubSystemC();
        }

        public void Operation()
        {
            Console.WriteLine("Operation method get called");
            _one.MethodA();
            _two.MethodB();
            _three.MethodC();
        }
    }


}
