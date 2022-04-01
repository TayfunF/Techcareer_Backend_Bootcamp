using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListUsing
{
    public partial class Form1 : Form
    {
        List<int> Numbers;
        List<int> Numbers2;
        List<int[]> Numbers3;
        int[] Ids;
        int[] ElementByList;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Numbers = new List<int>();
            Numbers2 = new List<int>(3);
            Numbers2.Add(1201023);
            Numbers2.Add(3123);
            Numbers2.Add(21155);
            Numbers2.Add(34535);
            //Numbers2[0] = 11;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int InputNumber = Convert.ToInt32(TxtNumber.Text);
            Numbers.Add(InputNumber);
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Numbers.AddRange(Numbers2);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Ids = new int[3];
            Ids[0] = 25;
            Ids[1] = 2424;
            Ids[2] = 100;
            Array.Resize(ref Ids, 4);
            Ids[3] = 555;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Numbers3 = new List<int[]>();
            ElementByList = new int[2];
            ElementByList[0] = 444;
            ElementByList[1] = 555;
            Numbers3.Add(ElementByList);
            Numbers3[0][0] = 999;
            Numbers3[0][1] = 777;
            int RowCount = ElementByList.Length;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Numbers2.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int RecordCount = Numbers2.Count();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ArrayRowCount = ElementByList.Length;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int Findex = Numbers2.FindIndex(g => g == 12);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Numbers.Reverse();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Numbers.Sort();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] ResultArray = Numbers.ToArray();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Numbers.Remove(123);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Numbers.RemoveAt(2);
        }
    }
}
