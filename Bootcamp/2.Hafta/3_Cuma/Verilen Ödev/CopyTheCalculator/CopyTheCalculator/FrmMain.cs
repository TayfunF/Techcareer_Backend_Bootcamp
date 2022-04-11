using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyTheCalculator
{
    public partial class FrmMain : Form
    {

        private enum TOperationType { OtNone, OtSum, OtSub, OtMul, OtDiv };
        private TOperationType OperationType = TOperationType.OtNone;
        double Result = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            DialogResult DialogResult;
            if (e.KeyChar == 27)
            {
                DialogResult = MessageBox.Show("Çıkma istediğinizden emin misiniz ?", "Çıkış Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DoOffSetButton();
        }

        private void DoOffSetButton()
        {
            Button Btn;
            foreach (Control BtnControl in PnlNumbers.Controls)
            {
                Btn = BtnControl as Button;
                Btn.Click += NumbersButtonClick;
                string Number = Btn.Name.Replace("Btn", "").Replace("Dot", "");
                Btn.Text = Number;
            }
        }
        private void NumbersButtonClick(object sender, EventArgs e)
        {
            string ANumber = ((Button)sender).Text;
            DoAddTextInfoTxtResult(ANumber);
        }
        private void DoAddTextInfoTxtResult(string AKey)
        {
            if (AKey.Trim() == "")
                return;
            if (AKey == ",")
            {
                if (TxtResult.Text.IndexOf(",") > -1)
                    return;
                if (TxtResult.Text.Length == 0)
                    AKey = "0";
            }

            if (TxtResult.Text == "0")
                TxtResult.Text = "0";

            TxtResult.Text += AKey;
        }
        private void DoGetResultFromTxtResult()
        {
            Result = Convert.ToDouble(TxtResult.Text);
            TxtResult.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtResult.Clear();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            OperationType = TOperationType.OtSub;
            DoGetResultFromTxtResult();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            OperationType = TOperationType.OtSub;
            DoGetResultFromTxtResult();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            OperationType = TOperationType.OtMul;
            DoGetResultFromTxtResult();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            OperationType = TOperationType.OtDiv;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            DoCalculate();
        }

        private void DoCalculate()
        {
            switch (OperationType)
            {
                case TOperationType.OtNone:
                    break;
                case TOperationType.OtSum:
                    DoCalculateSum();
                    break;
                case TOperationType.OtSub:
                    DoCalculateSub();
                    break;
                case TOperationType.OtMul:
                    DoCalculateMul();
                    break;
                case TOperationType.OtDiv:
                    DoCalculateDiv();
                    break;
                default:
                    break;
            }
        }

        private void DoCalculateSum()
        {
            double AValue = Convert.ToDouble(TxtResult.Text);
            double AResult = Result + AValue;
            TxtResult.Text = AResult.ToString();
        }
        private void DoCalculateSub()
        {
            double AValue = Convert.ToDouble(TxtResult.Text);
            double AResult = Result - AValue;
            TxtResult.Text = AResult.ToString();
        }
        private void DoCalculateMul()
        {
            double AValue = Convert.ToDouble(TxtResult.Text);
            double AResult = Result * AValue;
            TxtResult.Text = AResult.ToString();
        }
        private void DoCalculateDiv()
        {
            double AValue = Convert.ToDouble(TxtResult.Text);
            double AResult = Result / AValue;
            TxtResult.Text = AResult.ToString();
        }
    }
}
