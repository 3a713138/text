using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double x, y, z, a,t,i;
        List<Image> list = new List<Image>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(Resources._1);
            list.Add(Resources._2);
            list.Add(Resources._3);
            list.Add(Resources._4);
            list.Add(Resources._5);
            list.Add(Resources._6);
            list.Add(Resources._7);
            list.Add(Resources._8);
            list.Add(Resources._9);
            list.Add(Resources._10);
            list.Add(Resources._11);
            list.Add(Resources._12);
            list.Add(Resources._13);
            list.Add(Resources._14);
            list.Add(Resources._15);
            list.Add(Resources._16);
            list.Add(Resources._17);
            list.Add(Resources._18);
            list.Add(Resources._19);
            list.Add(Resources._20);
            list.Add(Resources._21);
            list.Add(Resources._22);
            list.Add(Resources._23);
            list.Add(Resources._24);
            list.Add(Resources._25);
            list.Add(Resources._26);
            list.Add(Resources._27);
            list.Add(Resources._28);
            list.Add(Resources._29);
            list.Add(Resources._30);
            list.Add(Resources._31);
            list.Add(Resources._32);
            list.Add(Resources._33);
            list.Add(Resources._34);
            list.Add(Resources._35);
            list.Add(Resources._36);
            list.Add(Resources._37);
            list.Add(Resources._38);
            list.Add(Resources._39);
            list.Add(Resources._40);
            list.Add(Resources._41);
            list.Add(Resources._42);
            list.Add(Resources._43);
            list.Add(Resources._44);
            list.Add(Resources._45);
            list.Add(Resources._46);
            list.Add(Resources._47);
            list.Add(Resources._48);
            list.Add(Resources._49);
            list.Add(Resources._50);
            list.Add(Resources._51);
            list.Add(Resources._52);
            list.Add(Resources._53);
        }
       

        private void bnt0_Click(object sender, EventArgs e)
        {
          
            
            int index = new Random().Next(51);
            //模擬隨機產生 一個值;
            pictureBox1.Image = list[index];
            x = index;
            x = (index % 13) + 1;
            if (x >= 10)
                x = 0.5;
        }
        private void button1_Click(object sender, EventArgs e)
                {
                    int index = new Random().Next(51) ;
                    //模擬隨機產生 一個值;
                    pictureBox2.Image = list[index];
                    y = (index%13)+1;
                    if (y > 10)
                        y = 0.5;
                    t = y + x;
                    if(t>10.5)
                    MessageBox.Show($"爆了", "Random Num", MessageBoxButtons.OK);
                    else
                    MessageBox.Show($"{t}", "Random Num", MessageBoxButtons.OK);
                }
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = list[52];
            pictureBox2.Image = list[52];
            pictureBox3.Image = list[52];
            pictureBox4.Image = list[52];
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            int index = new Random().Next(51);
            //模擬隨機產生 一個值;
            pictureBox4.Image = list[index];
            z = (index % 13) + 1;
            if (z >= 10)
                z = 0.5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = new Random().Next(51);
            //模擬隨機產生 一個值;
            pictureBox3.Image = list[index];
            a = (index % 13) + 1;
            if (a > 10)
                a = 0.5;
            i = a + z;
            if (i > 10.5)
                MessageBox.Show($"爆了", "Random Num", MessageBoxButtons.OK);
            else
                MessageBox.Show($"{i}", "Random Num", MessageBoxButtons.OK);
        }

    }
}
