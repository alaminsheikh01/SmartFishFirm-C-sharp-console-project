using System;
using System.IO;
using SmartFishFarm.alldata;

namespace SmartFishFarm
{

    class SmartPondsWithFile
    {
        const int BIGPONDSENSORS = 10;
        const int MEDIUMPONDSENSORS = 6;
        const int SMALLPONDSENSORS = 4;
        PondSize mysize;
        int current_index = 0;
        int totalTempData;

        //the file where we will keep all our sensor data saved
        const string SENSOR_FILE = @"E:\Users\alami\source\repos\SmartFishFarm\text.txt";
        //create a constructor that will accept the size of the pond so that the array size can be determined
        public SmartPondsWithFile(PondSize sz)
        {
            this.mysize = sz;
            //BIG will have sensor data array with 10 elements
            //MEDIUM  will have sensor data array with 6 elements
            //SMALL  will have sensor data array with 4 element
            if(this.mysize == PondSize.BIG)
            {
                this.totalTempData = 5;
            }
            else if (this.mysize == PondSize.MEDIUM)
            {
                this.totalTempData = 3;
            }
            else
            {
                this.totalTempData = 2;
            }
            //check if data file exists - if not, then create it
            if(!File.Exists(SENSOR_FILE))
            {
                File.Create(SENSOR_FILE);
            }
        }

        public int getTotalTempData()
        {
            return this.totalTempData;
        }

        public void saveSensorData(Sensor sensordata)
        {
            //now data will be saved in file.
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(SENSOR_FILE, true);
                string sensorinfo = sensordata.sensor_type + "~"
                                    + sensordata.sensor_id + "~"
                                    + sensordata.date_time + "~"
                                    + sensordata.data_value;
                sw.WriteLine(sensorinfo);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                sw.Close();
            }
        }

        public double getTempAverage()
        {

            double data_total = 0.0;
            string line = "";
            try
            {
                StreamReader srd = new StreamReader(SENSOR_FILE);
                while (true)
                {
                    line = srd.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    //nwo you have to get the data out from each line
                    //remember each line represent one sensor data (structure)
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            for (int i = 0; i < sensor_data.Length; i++)
            {
                if (sensor_data[i].sensor_type == sensortypes.TEMP)
                {
                    Console.WriteLine("Temp data-> id:" + sensor_data[i].sensor_id + "-" + sensor_data[i].sensor_type
                                    + " Date & time=" + sensor_data[i].date_time + " Temp=" + sensor_data[i].data_value);
                    data_total += sensor_data[i].data_value;
                }
            }
            return data_total / totalTempData;
        }

        internal int getTotalPHData()
        {
            throw new NotImplementedException();
        }
    }
}
