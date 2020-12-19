using System;

namespace SmartFishFarm
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            io.ParentSensorIOAbstract sio = null;
            Console.WriteLine("Please enter the type of IO class you want to use:");
            String whatioclass = Console.ReadLine();

            if(whatioclass.Equals("NOARR"))
            {
                sio = new io.SensorIO();
            }
            else if(whatioclass.Equals("ARR"))
            {
                sio = new io.SensorIOArr();
            }
            else
            {
                Console.WriteLine("Creating cleaner no logic sensor io");
                sio = new io.SensorIONoLogic();
            }
            //
            sio.beginOperation();
        }
    }
}
