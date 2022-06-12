using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_proj_2022
{
    internal class SectorDataSamples
    {
        int[] sample0 = {
            1, //D1
            1, //D1L
            1, //D1R        _
            0, //D2        | |
            1, //D2L       |_|
            1, //D2R
            1  //D3
        };

        int[] sample1 = {
            0, //D1
            0, //D1L
            1, //D1R
            0, //D2         |
            0, //D2L        |
            1, //D2R
            0  //D3
        };

        int[] sample2 = {
            1, //D1
            0, //D1L
            1, //D1R        _
            1, //D2         _|
            1, //D2L       |_
            0, //D2R
            1  //D3
        };

        int[] sample3 = {
            1, //D1
            0, //D1L
            1, //D1R        _
            1, //D2         _|
            0, //D2L        _|
            1, //D2R
            1  //D3
        };

        int[] sample4 = {
            0, //D1
            1, //D1L
            1, //D1R
            1, //D2         |_|
            0, //D2L          |
            1, //D2R
            0  //D3
        };

        int[] sample5 = {
            1, //D1
            1, //D1L
            0, //D1R         _
            1, //D2         |_
            0, //D2L         _|
            1, //D2R
            1  //D3
        };

        int[] sample6 = {
            1, //D1
            1, //D1L
            0, //D1R         _
            1, //D2         |_
            1, //D2L        |_|
            1, //D2R
            1  //D3
        };

        int[] sample7 = {
            1, //D1
            0, //D1L
            1, //D1R        _
            0, //D2          |
            0, //D2L         |
            1, //D2R
            0  //D3
        };

        int[] sample8 = {
            1, //D1
            1, //D1L
            1, //D1R         _
            1, //D2         |_|
            1, //D2L        |_|
            1, //D2R
            1  //D3
        };

        int[] sample9 = {
            1, //D1
            1, //D1L
            1, //D1R         _
            1, //D2         |_|
            0, //D2L         _|
            1, //D2R
            1  //D3
        };

        public static int[] getSample(int require)  // int require must be from 0 to 9
        {
            SectorDataSamples smp = new SectorDataSamples();
            switch (require)
            {
                case 0: return smp.sample0;
                case 1: return smp.sample1;
                case 2: return smp.sample2;
                case 3: return smp.sample3;
                case 4: return smp.sample4;
                case 5: return smp.sample5;
                case 6: return smp.sample6;
                case 7: return smp.sample7;
                case 8: return smp.sample8;
                case 9: return smp.sample9;
                default: throw new IndexOutOfRangeException();
            }
        }

    }
}
