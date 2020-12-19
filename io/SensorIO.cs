using System;
using SmartFishFarm.alldata;

namespace SmartFishFarm.io
{

    class SensorIO : ParentSensorIOAbstract//ParentSensorIO
    {
 
        Sensor tempsensor1, tempsensor2, phsensor1, phsensor2;


        protected override void collectTempData()
        {

            try
            {
                Console.WriteLine("Please enter sensor1 id - ");
                tempsensor1.sensor_id = Byte.Parse(Console.ReadLine());
  
                tempsensor1.sensor_type = sensortypes.TEMP;

                Console.WriteLine("Please enter first date and time for data - ");
                tempsensor1.date_time = Console.ReadLine();

                Console.WriteLine("Please enter sensor1 temp - ");
                tempsensor1.data_value = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter sensor2 id - ");
                tempsensor2.sensor_id = Byte.Parse(Console.ReadLine());

                tempsensor2.sensor_type = sensortypes.TEMP;

                Console.WriteLine("Please enter sensor1 date and time for data - ");
                tempsensor2.date_time = Console.ReadLine();

                Console.WriteLine("Please enter sensor2 temp - ");
                tempsensor2.data_value = double.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        protected override void collectPHData()
        {

        }
        public override void beginOperation()
        {
            base.beginOperation();
            //call method to collect temparature data
            collectTempData();
            //call method to collect Ph data
            collectPHData();
            //now display the data
            Console.WriteLine("Temp data 1 " + tempsensor1.sensor_id + "-" + tempsensor1.sensor_type
                            + " Date & time=" + tempsensor1.date_time + " Temp=" + tempsensor1.data_value);

            Console.WriteLine("Temp data 2 " + tempsensor2.sensor_id + "-" + tempsensor2.sensor_type
                            + " Date & time=" + tempsensor2.date_time + " Temp=" + tempsensor2.data_value);
        }
    }
}
