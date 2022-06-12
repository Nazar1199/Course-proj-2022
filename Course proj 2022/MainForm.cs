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
    public partial class MainForm : Form
    {
        string rules =  "Игра генерирует равенство, однако равенство включает в себя ошибку! \n" +
                        "Чтобы исправить ошибку - требуется переместить всего лишь одну спичку, однако вам дана свобода перемещать любые из них. \n" + 
                        "Приятной игры!";
        string inDevelop = "Данный раздел в разработке!";
        public MainForm()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
        }

        private void simpleModeBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rules);
            SimpleForm simpleForm = new SimpleForm();
            simpleForm.ShowDialog();
        }

        private void middleModeBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inDevelop);
            //MiddleForm middleForm = new MiddleForm();
            //middleForm.ShowDialog();
        }

        private void hardModeBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inDevelop);
            //HardForm hardForm = new HardForm();
            //hardForm.ShowDialog();
        }
    }
}
