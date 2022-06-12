using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_proj_2022
{
    internal class Digit
    {
        int[] sectorDataCurrent;

        PictureBox D1;  //0
        PictureBox D1L; //1
        PictureBox D1R; //2
        PictureBox D2;  //3
        PictureBox D2L; //4
        PictureBox D2R; //5
        PictureBox D3;  //6

        public Digit(
            PictureBox D1,
            PictureBox D1L,
            PictureBox D1R,
            PictureBox D2,
            PictureBox D2L,
            PictureBox D2R,
            PictureBox D3)
        {
            this.D1 = D1;
            this.D1L = D1L;
            this.D1R = D1R;
            this.D2 = D2;
            this.D2L = D2L;
            this.D2R = D2R;
            this.D3 = D3;

            sectorDataCurrent = SectorDataSamples.getSample(8);
        }

        public int[] getSectorData()
        {
            return sectorDataCurrent;
        }

        private int invert(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void invertBackgroundImage(PictureBox section, int state, string rotate)
        {
            if (state == 1)
            {
                if (rotate == "H")
                {
                    section.BackgroundImage = Properties.Resources.Спичка_обр;
                } else if (rotate == "V")
                {
                    section.BackgroundImage = Properties.Resources.Спичка_обр_В;
                }
                section.BackColor = Color.White;
            } else
            {
                section.BackgroundImage = null;
                section.BackColor = Color.WhiteSmoke;
            }
        }

        public int findDifferents(int quantitySectors, bool add, bool remove)
        {
            string r = " (add)";
            if (remove)
            {
                r = " (remove)";
                if (add)
                {
                    r = " (replace)";
                }
            }
            for (int num = 0; num < 10; num++)
            {
                int[] sample = SectorDataSamples.getSample(num);
                int[] differents = {};
                int summ = 0;
                int summArrItems = 0;
                for (int i = 0; i < sectorDataCurrent.Length; i++)
                {
                    if (sectorDataCurrent[i] != sample[i])
                    {
                        if ((sample[i] == 1 && add) || (sample[i] == 0 && remove))
                        {
                            var list = differents.ToList();
                            list.Add(sample[i]);
                            differents = list.ToArray();
                            summArrItems = summArrItems + sample[i];
                            summ++;
                            if (findNumberByDigit() == 7 && num == 3)
                            {
                                int seven = 7;
                            }
                        } else
                        {
                            differents = new List<int>().ToArray();
                            break;
                        }
                    }
                }
                if ((differents.Length == quantitySectors * 2) && add && remove && summArrItems == quantitySectors)
                {
                    return num;
                }
                if ((differents.Length == quantitySectors) && !(add == remove))
                {
                    if (((differents[0] == 1 && add) || (differents[0] == 0 && remove)))
                    {
                        return num;
                    }
                }
            }
            return -1;
            throw new IndexOutOfRangeException();
        }

        public void setDigitTo(int require)
        {
            sectorDataCurrent = SectorDataSamples.getSample(require);
            invertBackgroundImage(D1, sectorDataCurrent[0], "H");
            invertBackgroundImage(D1L, sectorDataCurrent[1], "V");
            invertBackgroundImage(D1R, sectorDataCurrent[2], "V");
            invertBackgroundImage(D2, sectorDataCurrent[3], "H");
            invertBackgroundImage(D2L, sectorDataCurrent[4], "V");
            invertBackgroundImage(D2R, sectorDataCurrent[5], "V");
            invertBackgroundImage(D3, sectorDataCurrent[6], "H");
        }

        public int findNumberByDigit()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Enumerable.SequenceEqual(sectorDataCurrent, SectorDataSamples.getSample(i)))
                {
                    return i;
                }
            }
            throw new IndexOutOfRangeException();
        }

        public void changeSectorBackground(string sector)
        {
            PictureBox D = null;
            switch (sector)
            {
                case "D1":
                    D = D1;
                    break;
                case "D1L":
                    D = D1L;
                    break;
                case "D1R":
                    D = D1R;
                    break;
                case "D2":
                    D = D2;
                    break;
                case "D2L":
                    D = D2L;
                    break;
                case "D2R":
                    D = D2R;
                    break;
                case "D3":
                    D = D3;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }

            if (D.BackColor != Color.Blue && getSectorValue(sector) == 1)
            {
                D.BackColor = Color.Blue;
            }
            else
            {
                if (getSectorValue(sector) == 1)
                {
                    D.BackColor = Color.White;
                } else
                {
                    D.BackColor = Color.WhiteSmoke;
                }
            }
        }

        public int getSectorValue(string sector)
        {
            switch (sector)
            {
                case "D1":
                    return sectorDataCurrent[0];
                case "D1L":
                    return sectorDataCurrent[1];
                case "D1R":
                    return sectorDataCurrent[2];
                case "D2":
                    return sectorDataCurrent[3];
                case "D2L":
                    return sectorDataCurrent[4];
                case "D2R":
                    return sectorDataCurrent[5];
                case "D3":
                    return sectorDataCurrent[6];
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public void changeSector(string sector)
        {
            switch (sector)
            {
                case "D1": 
                    sectorDataCurrent[0] = invert(sectorDataCurrent[0]);
                    invertBackgroundImage(D1, sectorDataCurrent[0], "H");
                    break;
                case "D1L":
                    sectorDataCurrent[1] = invert(sectorDataCurrent[1]);
                    invertBackgroundImage(D1L, sectorDataCurrent[1], "V");
                    break;
                case "D1R":
                    sectorDataCurrent[2] = invert(sectorDataCurrent[2]);
                    invertBackgroundImage(D1R, sectorDataCurrent[2], "V");
                    break;
                case "D2":
                    sectorDataCurrent[3] = invert(sectorDataCurrent[3]);
                    invertBackgroundImage(D2, sectorDataCurrent[3], "H");
                    break;
                case "D2L":
                    sectorDataCurrent[4] = invert(sectorDataCurrent[4]);
                    invertBackgroundImage(D2L, sectorDataCurrent[4], "V");
                    break;
                case "D2R":
                    sectorDataCurrent[5] = invert(sectorDataCurrent[5]);
                    invertBackgroundImage(D2R, sectorDataCurrent[5], "V");
                    break;
                case "D3":
                    sectorDataCurrent[6] = invert(sectorDataCurrent[6]);
                    invertBackgroundImage(D3, sectorDataCurrent[6], "H");
                    break;
            }
        }
    }
}
