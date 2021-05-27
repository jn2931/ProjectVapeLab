using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectVapeLab
{
    class Aroma
    {
        public Aroma()
        {

        }
        public string name;
        public float percentage;
        public float volume;
        public Aroma(string aromaName,int aromaPercentage)
        {
            name = aromaName;
            percentage = aromaPercentage;
        }
    }
}
