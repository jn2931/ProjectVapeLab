using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectVapeLab
{
    class Aroma
    {
        public string name;
        private int percentage;
        public Aroma(string aromaName,int aromaPercentage)
        {
            name = aromaName;
            percentage = aromaPercentage;
        }
    }
}
