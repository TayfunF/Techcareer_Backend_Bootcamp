using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class FrmChess : Form
    {
        Button[,] Btn = new Button[8, 8];
        int i, j, MarginTop = 0, MarginLeft = 0;

        public FrmChess()
        {
            InitializeComponent();
        }

        private void FrmChess_Load(object sender, EventArgs e)
        {
            CreateBoard();
        }

        private void CreateBoard()
        {
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    CreateBox();

                    if ((i + j) % 2 == 0)
                        FillWhite();
                    if ((i + j) % 2 == 1)
                        FillBlack();

                    PnlSqrt.Controls.Add(Btn[i, j]);
                }
                MarginTop += 50;
                MarginLeft = 0;
            }
        }

        private void CreateBox()
        {
            Btn[i, j] = new Button();
            Btn[i, j].Height = 50;
            Btn[i, j].Width = 50;
            Btn[i, j].Left = MarginLeft;
            Btn[i, j].Top = MarginTop;
            MarginLeft += 50;
        }

        private void FillWhite()
        {
            Btn[i, j].BackColor = Color.White;
        }

        private void FillBlack()
        {
            Btn[i, j].BackColor = Color.Black;
        }

    }
}
