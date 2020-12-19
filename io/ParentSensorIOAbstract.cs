using System;
using System.Collections.Generic;
using System.Text;

namespace SmartFishFarm.io
{
    abstract class ParentSensorIOAbstract
    {
        protected abstract void collectTempData();

        protected abstract void collectPHData();

        public virtual void beginOperation()
        {
            showWelcomeMessage();
            Console.WriteLine("Beginning operation.");
        }

        protected void showWelcomeMessage()
        {
            Console.WriteLine("welcome to sensor program.");
            Console.WriteLine("Welcome to the pond monitoring system");
            Console.WriteLine("-------------------------------------");
        }
    }
}
