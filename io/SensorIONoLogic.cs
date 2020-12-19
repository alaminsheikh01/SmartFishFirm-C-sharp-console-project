using System;
using SmartFishFarm.alldata;

namespace SmartFishFarm.io
{

    class SensorIONoLogic : ParentSensorIOAbstract//ParentSensorIO
    {
        //SmartPonds pond = null;
        SmartPondsWithFile pond = null;
        protected override void collectTempData()
        {

            int tempdata = pond.getTotalTempData();
            try
            {
                for (int i = 0; i < pond.getTotalTempData(); i++)
                {
                    Console.WriteLine("Please enter TEMP sensor id - ");
                    Sensor tempsensor;
                    tempsensor.sensor_id = Byte.Parse(Console.ReadLine());
   
                    tempsensor.sensor_type = sensortypes.TEMP;//Console.ReadLine();

                    Console.WriteLine("Please enter first date and time for data - ");
                    tempsensor.date_time = Console.ReadLine();

                    Console.WriteLine("Please enter sensor1 temp - ");
                    tempsensor.data_value = double.Parse(Console.ReadLine());//in future - try-catch

                    pond.saveSensorData(tempsensor);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected override void collectPHData()
        {

            try
            {

                for (int i = 0; i < pond.getTotalPHData(); i++)
                {
                    Console.WriteLine("Please enter PH sensor id - ");
                    Sensor phsensor;
                    phsensor.sensor_id = Byte.Parse(Console.ReadLine());
                    phsensor.sensor_type = sensortypes.PH;//Console.ReadLine();

                    Console.WriteLine("Please enter first date and time for data - ");
                    phsensor.date_time = Console.ReadLine();

                    Console.WriteLine("Please enter sensor1 PH - ");
                    phsensor.data_value = double.Parse(Console.ReadLine());//in future - try-catch

                    pond.saveSensorData(phsensor);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public override void beginOperation()
        {
            base.beginOperation();
            pond = new SmartPondsWithFile(PondSize.SMALL);//need to define size of the pond.
            //call method to collect temparature data
            collectTempData();
            //call method to collect Ph data
            collectPHData();
            //now display the data

            ////now we have total of all temp and we can average
            //Console.WriteLine("Average temp is " + pond.getTempAverage());

            //use for loop to pint ph data and get average
            //but reset data_total first
            //data_total = 0.0;
            //for (??ki hobe tumi ber koro)
            //{

            //}
        }
    }
}
