using System;
using System.Collections.Generic;
using System.Text;

namespace SmartFishFarm.io
{
    class ParentSensorIO
    {
        protected virtual void collectTempData()
        {
            Console.WriteLine("Starting temparaturre sensor data collection.");
        }

        protected virtual void collectPHData()
        {
            Console.WriteLine("Starting PH sensor data collection.");
        }

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
