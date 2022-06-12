using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_proj_2022
{
    public partial class SimpleForm : Form
    {
        string currentSector = null;
        Digit currentDigit = null;
        Digit num1;
        Digit num2;
        Digit numR1;
        Digit numR2;
        int correctNum1;
        int correctNum2;
        int correctNumR1;
        int correctNumR2;
        int startNum1;
        int startNum2;
        int startNumR1;
        int startNumR2;
        NumberClass resultNumb;
        string answer;
        int diffOp = 0;
        int differenting = 1;
        int operation = 0;

        public SimpleForm()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;

            numR1 = new Digit(
                numR_digit1_section1,
                numR_digit1_section1L,
                numR_digit1_section1R,
                numR_digit1_section2,
                numR_digit1_section2L,
                numR_digit1_section2R,
                numR_digit1_section3
                );

            numR2 = new Digit(
                numR_digit2_section1,
                numR_digit2_section1L,
                numR_digit2_section1R,
                numR_digit2_section2,
                numR_digit2_section2L,
                numR_digit2_section2R,
                numR_digit2_section3
                );

            startGame();
        }

        private void startGame()
        {
            var rand = new Random();
            int diff = 2;
            int a = 0;
            int b = 0;
            while (diff != 0)
            {
                a = rand.Next(10);
                b = rand.Next(10);
                operation = rand.Next(5);

                num1 = new Digit(
                    num1_digit1_section1,
                    num1_digit1_section1L,
                    num1_digit1_section1R,
                    num1_digit1_section2,
                    num1_digit1_section2L,
                    num1_digit1_section2R,
                    num1_digit1_section3
                    );

                num2 = new Digit(
                    num2_digit1_section1,
                    num2_digit1_section1L,
                    num2_digit1_section1R,
                    num2_digit1_section2,
                    num2_digit1_section2L,
                    num2_digit1_section2R,
                    num2_digit1_section3
                    );

                if (operation == 0)
                {
                    if (a < b)
                    {
                        a = a + b;
                        b = a - b;
                        a = a - b;
                    }
                    num1.setDigitTo(a);
                    num2.setDigitTo(b);
                    resultNumb = new NumberClass(a - b, numR1, numR2);
                    pictureBox2.Visible = false;
                    answer = (a + "-" + b + "=" + (a - b));
                    correctNumR1 = (a - b) / 10;
                    correctNumR2 = (a - b) % 10;
                }
                else
                {
                    num1.setDigitTo(a);
                    num2.setDigitTo(b);
                    resultNumb = new NumberClass(a + b, numR1, numR2);
                    pictureBox2.Visible = true;
                    answer = (a + "+" + b + "=" + (a + b));
                    correctNumR1 = (a + b) / 10;
                    correctNumR2 = (a + b) % 10;
                }

                diff = diff - setDifferent(num1);
                if (diff > 0)
                {
                    diff = diff - setDifferent(num2);
                }
                if (diff != 0)
                {
                    diff = 2;
                }
                else
                {
                    correctNum1 = a;
                    correctNum2 = b;
                    startNum1 = num1.findNumberByDigit();
                    startNum2 = num2.findNumberByDigit();
                }
                diffOp = 0;
            }
        }

        private int setDifferent(Digit D){ // Controller
            int diffNum;
            differenting++;
            //Replace
            diffNum = D.findDifferents(1, true, true);
            if (diffNum >= 0 && diffOp == 0)
            {
                diffOp = 0;
                D.setDigitTo(diffNum);
                return 2;
            }
            //Adding
            diffNum = D.findDifferents(1, true, false);
            if (diffNum >= 0 && diffOp < 1)
            {
                diffOp = 1;
                D.setDigitTo(diffNum);
                return 1;
            }
            //Removing
            diffNum = D.findDifferents(1, false, true);
            if (diffNum >= 0 && diffOp > -1)
            {
                diffOp = -1;
                D.setDigitTo(diffNum);
                return 1;
            }
            return 0;
        }

        private void sectorClick(Digit D, string sector)
        {
            if (currentSector == null && D.getSectorValue(sector) == 1)
            {
                currentDigit = D;
                currentSector = sector;
                D.changeSectorBackground(sector);
            } else if (sector == currentSector && D == currentDigit)
            {
                D.changeSectorBackground(sector);
                currentDigit = null;
                currentSector = null;
            }
            else if (currentSector != null && D.getSectorValue(sector) == 0)
            {
                D.changeSector(sector);
                currentDigit.changeSector(currentSector);
                currentDigit.changeSectorBackground(currentSector);
                currentDigit = null;
                currentSector = null;
            }
        }

        private void checkAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                if ((numR1.findNumberByDigit() == correctNumR1) && (numR2.findNumberByDigit() == correctNumR2))
                {
                    if ((num1.findNumberByDigit() == correctNum1) && (num2.findNumberByDigit() == correctNum2))
                    {
                        MessageBox.Show("Ответ правильный!");
                        startGame();
                    } else if ((num1.findNumberByDigit() == correctNum2) && (num2.findNumberByDigit() == correctNum1) && operation > 0)
                    {
                        MessageBox.Show("Ответ правильный!");
                        startGame();
                    } else
                    {
                        MessageBox.Show("Ответ не правильный!");
                    }
                }
                else
                {
                    MessageBox.Show("Ответ не правильный!");
                }
            }
            catch
            {
                MessageBox.Show("Ответ не правильный!");
            }
        }

        private void resetNumbs_Click(object sender, EventArgs e)
        {
            num1.setDigitTo(startNum1);
            num2.setDigitTo(startNum2);
            numR1.setDigitTo(correctNumR1);
            numR2.setDigitTo(correctNumR2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void getAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(answer);
        }

        private void num1_digit1_section1_Click(object sender, EventArgs e)
        {
            sectorClick(num1, "D1");
        }

        private void num1_digit1_section1L_Click(object sender, EventArgs e)
        {
            sectorClick(num1, "D1L");
        }

        private void num1_digit1_section1R_Click(object sender, EventArgs e)
        {
            sectorClick(num1, "D1R");
        }

        private void num1_digit1_section2_Click(object sender, EventArgs e)
        {
            sectorClick(num1, "D2");
        }

        private void num1_digit1_section2L_Click(object sender, EventArgs e)
        {
            sectorClick(num1, "D2L");
        }

        private void num1_digit1_section2R_Click(object sender, EventArgs e)
        {
            sectorClick(num1, "D2R");
        }

        private void num1_digit1_section3_Click(object sender, EventArgs e)
        {
            sectorClick(num1, "D3");
        }

        private void num2_digit1_section1_Click(object sender, EventArgs e)
        {
            sectorClick(num2, "D1");
        }

        private void num2_digit1_section1L_Click(object sender, EventArgs e)
        {
            sectorClick(num2, "D1L");
        }

        private void num2_digit1_section1R_Click(object sender, EventArgs e)
        {
            sectorClick(num2, "D1R");
        }

        private void num2_digit1_section2_Click(object sender, EventArgs e)
        {
            sectorClick(num2, "D2");
        }

        private void num2_digit1_section2L_Click(object sender, EventArgs e)
        {
            sectorClick(num2, "D2L");
        }

        private void num2_digit1_section2R_Click(object sender, EventArgs e)
        {
            sectorClick(num2, "D2R");
        }

        private void num2_digit1_section3_Click(object sender, EventArgs e)
        {
            sectorClick(num2, "D3");
        }

        private void numR_digit1_section1_Click(object sender, EventArgs e)
        {
            sectorClick(numR1, "D1");
        }

        private void numR_digit1_section1L_Click(object sender, EventArgs e)
        {
            sectorClick(numR1, "D1L");
        }

        private void numR_digit1_section1R_Click(object sender, EventArgs e)
        {
            sectorClick(numR1, "D1R");
        }

        private void numR_digit1_section2_Click(object sender, EventArgs e)
        {
            sectorClick(numR1, "D2");
        }

        private void numR_digit1_section2L_Click(object sender, EventArgs e)
        {
            sectorClick(numR1, "D2L");
        }

        private void numR_digit1_section2R_Click(object sender, EventArgs e)
        {
            sectorClick(numR1, "D2R");
        }

        private void numR_digit1_section3_Click(object sender, EventArgs e)
        {
            sectorClick(numR1, "D3");
        }

        private void numR_digit2_section1_Click(object sender, EventArgs e)
        {
            sectorClick(numR2, "D1");
        }

        private void numR_digit2_section1L_Click(object sender, EventArgs e)
        {
            sectorClick(numR2, "D1L");
        }

        private void numR_digit2_section1R_Click(object sender, EventArgs e)
        {
            sectorClick(numR2, "D1R");
        }

        private void numR_digit2_section2_Click(object sender, EventArgs e)
        {
            sectorClick(numR2, "D2");
        }

        private void numR_digit2_section2L_Click(object sender, EventArgs e)
        {
            sectorClick(numR2, "D2L");
        }

        private void numR_digit2_section2R_Click(object sender, EventArgs e)
        {
            sectorClick(numR2, "D2R");
        }

        private void numR_digit2_section3_Click(object sender, EventArgs e)
        {
            sectorClick(numR2, "D3");
        }

        private void restartGame_Click(object sender, EventArgs e)
        {
            startGame();
        }
    }
}
