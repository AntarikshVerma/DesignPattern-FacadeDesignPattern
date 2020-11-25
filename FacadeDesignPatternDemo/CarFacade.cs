using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPatternDemo
{
    public class CarFacade
    {
        private readonly CreateBody _createBody;
        private readonly CreateEngine _createEngine;
        private readonly CreateInterior _createInterior;

        public CarFacade()
        {
            _createBody = new CreateBody();
            _createEngine = new CreateEngine();
            _createInterior = new CreateInterior();
        }

        public void CreateCompleteCar()
        {
            _createBody.BodyCreation();
            _createEngine.EngineCreation();
            _createInterior.InteriorCreation();
            Console.WriteLine("**********The car has been Designed completely************");
        }
    }
}
