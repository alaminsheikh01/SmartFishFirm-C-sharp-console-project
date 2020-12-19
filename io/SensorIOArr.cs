using System;
using SmartFishFarm.alldata;

namespace SmartFishFarm.io
{
    class SensorIOArr : ParentSensorIOAbstract//ParentSensorIO
    {
        private const int TOTAL_SENSORS = 4;
        private const int TOTAL_TEMP_SENSORS = 2;
        private const int TOTAL_PH_SENSORS = 2;
        //create two structs for temp data and ph data
        //BUT WHAT IF WE HAVE A LOT SENSORS???  SHOULD USE AN ARRAY
        //Sensor tempsensor1, tempsensor2, phsensor1, phsensor2;
        Sensor[] sensor_data_arr = new Sensor[TOTAL_SENSORS];//5 temps and 5 phs

        protected override void collectTempData()
        {
            try
            {
                for (int i = 0; i < TOTAL_TEMP_SENSORS; i++)
                {
                    Sensor tempsensor;

                    Console.WriteLine("Please enter TEMP sensor id - "); 
                    tempsensor.sensor_id = Byte.Parse(Console.ReadLine());

                    tempsensor.sensor_type = sensortypes.TEMP;

                    Console.WriteLine("Please enter first date and time for data - ");
                    tempsensor.date_time = Console.ReadLine();

                    Console.WriteLine("Please enter sensor1 temp - ");
                    tempsensor.data_value = double.Parse(Console.ReadLine());//in future - try-catch

                    sensor_data_arr[i] = tempsensor;
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
                for (int i = TOTAL_TEMP_SENSORS; i < TOTAL_SENSORS; i++)
                {
                    Sensor phsensor;

                    Console.WriteLine("Please enter PH sensor id - ");
                    phsensor.sensor_id = Byte.Parse(Console.ReadLine());

                    phsensor.sensor_type = sensortypes.PH;

                    Console.WriteLine("Please enter first date and time for data - ");
                    phsensor.date_time = Console.ReadLine();

                    Console.WriteLine("Please enter sensor1 PH - ");
                    phsensor.data_value = double.Parse(Console.ReadLine());

                    sensor_data_arr[i] = phsensor;
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
            //call method to collect temparature data
            collectTempData();
            //call method to collect Ph data
            collectPHData();

            double data_total = 0.0;
            for(int i = 0; i < TOTAL_SENSORS; i++)
            {
                if (sensor_data_arr[i].sensor_type == sensortypes.TEMP)
                {
                    Console.WriteLine("Temp data-> id:" + sensor_data_arr[i].sensor_id + "-" + sensor_data_arr[i].sensor_type
                                    + " Date & time=" + sensor_data_arr[i].date_time + " Temp=" + sensor_data_arr[i].data_value);
                    data_total += sensor_data_arr[i].data_value;
                }
            }
            //now we have total of all temp and we can average
            Console.WriteLine("Average temp is " + (data_total/TOTAL_TEMP_SENSORS));


            data_total = 0.0;
            for(int i=0; i < TOTAL_SENSORS; i++)
            {
                if(sensor_data_arr[i].sensor_type == sensortypes.PH)
                {
                    Console.WriteLine("PH data-> id:" + sensor_data_arr[i].sensor_id + "-" + sensor_data_arr[i].sensor_type
                                   + " Date & time=" + sensor_data_arr[i].date_time + " PH=" + sensor_data_arr[i].data_value);
                    data_total += sensor_data_arr[i].data_value;

                }
            }
            //now we have total of all temp and we can average
            Console.WriteLine("Average temp is " + (data_total / TOTAL_PH_SENSORS));

        }
    }
}
