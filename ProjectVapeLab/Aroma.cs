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
        public int percentage;
        public Aroma(string aromaName,int aromaPercentage)
        {
            name = aromaName;
            percentage = aromaPercentage;
        }
    }
}
