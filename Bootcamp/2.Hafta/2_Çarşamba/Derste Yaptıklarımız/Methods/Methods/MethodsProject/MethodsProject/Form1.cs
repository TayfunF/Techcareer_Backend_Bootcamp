using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            DoSum();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double FirstNumber = Convert.ToDouble(TxtFirstNumber.Text);
            double SecondNumber = Convert.ToDouble(TxtSecondNumber.Text);
            DoSum(FirstNumber, SecondNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double FirstNumber = Convert.ToDouble(TxtFirstNumber.Text);
            double SecondNumber = Convert.ToDouble(TxtSecondNumber.Text);
            DoSum(FirstNumber, SecondNumber, 0);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            double SumTotal = DoMinds();
            LblSonuc.Text = SumTotal.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double FirstNumber = Convert.ToDouble(TxtFirstNumber.Text);
            double SecondNumber = Convert.ToDouble(TxtSecondNumber.Text);
            double SumTotal = DoMinds(FirstNumber, SecondNumber);
            LblSonuc.Text = SumTotal.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double FirstNumber = Convert.ToDouble(TxtFirstNumber.Text);
            double SecondNumber = Convert.ToDouble(TxtSecondNumber.Text);
            double SumTotal = DoMinds(FirstNumber, SecondNumber, 1);
            LblSonuc.Text = SumTotal.ToString();
        }

        #region Procedures

        private void DoSum()
        {
            double Sum = 0;
            double FirstNumber = Convert.ToDouble(TxtFirstNumber.Text);
            double SecondNumber = Convert.ToDouble(TxtSecondNumber.Text);
            Sum = FirstNumber + SecondNumber;
            LblSonuc.Text = Sum.ToString();
        }

        private void DoSum(double FirstNumber, double SecondNumber)
        {
            double Sum = 0;
            Sum = FirstNumber + SecondNumber;
            LblSonuc.Text = Sum.ToString();
        }

        private void DoSum(double FirstNumber, double SecondNumber = 0, double ThirdNumber = 3)
        {
            double Sum = 0;
            Sum = FirstNumber + SecondNumber;
            LblSonuc.Text = Sum.ToString();
        }

        private void DoSumByRef(double FirstNumber, double SecondNumber, ref double RefResult)
        {
            double result = FirstNumber + SecondNumber;
            RefResult = result;
        }

        private void DoSumByOut(double FirstNumber, double SecondNumber, out double OutResult)
        {
            double result = FirstNumber + SecondNumber;
            OutResult = result;
        }




        #endregion


        #region Functions
        private double DoMinds()
        {
            double result = 0;
            double FirstNumber = Convert.ToDouble(TxtFirstNumber.Text);
            double SecondNumber = Convert.ToDouble(TxtSecondNumber.Text);
            result = FirstNumber - SecondNumber;
            return result;
        }

        private double SumAndMinds(double FirstNumber, double SecondNumber, ref double RefMindsResult)
        {
            double SumResult = 0;
            SumResult = FirstNumber + SecondNumber;
            RefMindsResult = FirstNumber - SecondNumber;
            return SumResult;
        }




        private double DoMinds(double FirstNumber, double SecondNumber)
        {
            double result = 0;
            result = FirstNumber - SecondNumber;
            return result;
        }

        private double DoMinds(double FirstNumber, double SecondNumber = 0, double ThirdNumber = 3)
        {
            double result = 0;
            result = FirstNumber - SecondNumber - ThirdNumber;
            return result;
        }


        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            double Sum = 0;
            double FirstNumber = Convert.ToDouble(TxtFirstNumber.Text);
            double SecondNumber = Convert.ToDouble(TxtSecondNumber.Text);
            //Sum = FirstNumber + SecondNumber;
            DoSumByRef(FirstNumber, SecondNumber, ref Sum);
            LblSonuc.Text = Sum.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double Sum = 0;
            double FirstNumber = Convert.ToDouble(TxtFirstNumber.Text);
            double SecondNumber = Convert.ToDouble(TxtSecondNumber.Text);
            DoSumByOut(FirstNumber, SecondNumber, out Sum);
            LblSonuc.Text = Sum.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int outValue;
            int.TryParse("asd", out outValue);

            if (outValue == 0)
            {

            }

            int[] arr = new int[1];
            Array.Resize(ref arr, 2);

            int count = arr.Length;






        }

        private void button9_Click(object sender, EventArgs e)
        {
            double MindsResult = 0;
            double FirstNumber = Convert.ToDouble(TxtFirstNumber.Text);
            double SecondNumber = Convert.ToDouble(TxtSecondNumber.Text);
            double SumTotal = SumAndMinds(FirstNumber, SecondNumber, ref MindsResult);

            MessageBox.Show("Toplama sonucu = " + SumTotal.ToString() 
                          + "\nÇıkartma Sonucu:" + MindsResult.ToString());

        }
    }
}
