using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0707
{
    public partial class Form1 : Form
    {
        int[] data = new int[3];
        int gk, hk;
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //★のランダム化
            data[0] = rand.Next(10);
            data[0] = rand.Next(10);
            data[1] = rand.Next(101);
            data[1] = rand.Next(10);
            data[2] = rand.Next(10);
            data[2] = rand.Next(10);

            MessageBox.Show($"初期化数値\tdata[0]:{data[0]}\tdata[1]:{data[1]}\tdata[2]:{data[2] }");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gk = 0;
            gk = data[0] + data[1] + data[2];
            MessageBox.Show($"合計{gk }です");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gk = 0;
            hk = 0;
            gk = data[0] + data[1] + data[2];
            hk = gk / 3;
            MessageBox.Show($"平均{hk}です");
        }
    }
}
