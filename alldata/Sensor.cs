using System;
using System.Collections.Generic;
using System.Text;

namespace SmartFishFarm.alldata
{
    struct Sensor
    {
        public byte sensor_id;
        public sensortypes sensor_type;//temp or ph
        public string date_time;
        public double data_value;
    }
}
