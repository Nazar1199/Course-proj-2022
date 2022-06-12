using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_proj_2022
{
    internal class NumberClass
    {
        Digit D1;
        Digit D2;
        public NumberClass(int myNum, Digit d1, Digit d2)
        {
            D1 = d1;
            D2 = d2;

            D1.setDigitTo(myNum / 10);
            D2.setDigitTo(myNum % 10);
        }

        public int getNumber()
        {
            return (D1.findNumberByDigit() * 10) + D2.findNumberByDigit();
        }
    }
}
