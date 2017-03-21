using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace international_reference_number
{
    class CreateRefNumber
    {
        public string setNumber()
        {
            string number = "2348236";
            number = number + "2715" + "00";
            return number;
            
        }

        public string setRfNumber()
        {
            string number = "RF712348231";
            return number;
        }
    }
}
