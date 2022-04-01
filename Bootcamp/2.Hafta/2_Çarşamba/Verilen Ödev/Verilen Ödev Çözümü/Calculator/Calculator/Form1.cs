using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    // Global Degisken Kullanimi
    // Enum Kullanimi
    // 10 Rakam İcin Event  Kullanimi
    // Butonlar İcin İsimleri ve Click Olayi Kullanimi
    // Try-Catch Kullanimi
    // TextBox Kullanimi
    // Method Kullanimi
    // Convert Kullanimi

    public partial class Form1 : Form
    {
        double NumberOne, NumberTwo, Result = 0;

        Operations Operation;

        enum Operations
        {
            Sum = 0, Sub = 1, Mul = 2, Div = 3,
        }

        public Form1()
        {
            InitializeComponent();
        }

        // 0-9 Arasi Tum Butonlar İcin Event
        private void SelectedButtons(object sender, EventArgs e)
        {
            try
            {
                if (TxtNumbers.Text == "0") TxtNumbers.Text = "";

                TxtNumbers.Text += ((Button)sender).Text;
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hatalı Bir Tuşlama Yaptınız");
            }
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNumbers.Text.IndexOf(',') < 1) TxtNumbers.Text += ',';
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hatalı Bir Tuşlama Yaptınız");
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                TxtNumbers.Text = "";

                if (TxtNumbers.Text == "") TxtNumbers.Text = "0";
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Temizlerken Bir Hata Oluştu");
            }
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            try
            {
                NumberOne = Convert.ToDouble(TxtNumbers.Text);
                TxtNumbers.Text = "";
                Operation = Operations.Sum;
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hatalı Bir Tuşlama Yaptınız");
            }
        }

        private void BtnMines_Click(object sender, EventArgs e)
        {
            try
            {
                NumberOne = Convert.ToDouble(TxtNumbers.Text);
                TxtNumbers.Text = "";
                Operation = Operations.Sub;
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hatalı Bir Tuşlama Yaptınız");
            }
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            try
            {
                NumberOne = Convert.ToDouble(TxtNumbers.Text);
                TxtNumbers.Text = "";
                Operation = Operations.Mul;
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hatalı Bir Tuşlama Yaptınız");
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                NumberOne = Convert.ToDouble(TxtNumbers.Text);
                TxtNumbers.Text = "";
                Operation = Operations.Div;
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hatalı Bir Tuşlama Yaptınız");
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                NumberTwo = Convert.ToDouble(TxtNumbers.Text);

                if (Operation == Operations.Sum)
                {
                    Result = NumberOne + NumberTwo;

                    TxtNumbers.Text = Result.ToString();
                }
                else if (Operation == Operations.Sub)
                {
                    Result = NumberOne - NumberTwo;

                    TxtNumbers.Text = Result.ToString();
                }
                else if (Operation == Operations.Mul)
                {
                    Result = NumberOne * NumberTwo;

                    TxtNumbers.Text = Result.ToString();
                }
                else
                {
                    Result = NumberOne / NumberTwo;

                    if (NumberTwo == 0) MessageBox.Show("Sıfıra Bölünemez !!!");

                    TxtNumbers.Text = Result.ToString();
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hatalı Bir Tuşlama Yaptınız");
            }
        }
    }
}
