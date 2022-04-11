using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootcampLessonOne
{
    public partial class Form1 : Form
    {
        //Merhaba
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int x += 1;
            //x++
            //1 == 0 //false
            //1 > 0 //true
            //0 > 1 //false
            //0 >= 0 //true
            //1 < -1 //false
            //2 <= 1 //false
            //2 != 2 //false
            //!(1 > 2) //true
            //(1 == 2) && (2 <= 5) //false
            //(5 <= 1) && !(2 >= 2) //false
            //!(8 + 5 == 14) //true
            //(!true) //false
            //!(1 <= 13) //
            //!(false) //
            //!(2 <=5 && !false) //false
            //(!true && 1 >= -5 && !1) //false
            //(false && true && false) //false
            //(false && true) //false
            //!(!(true && 1 <= 5)) //true
            //(!(9 >= 1) && (true) && (0 !=2)) //false
            //!(true && !false && !true) //true
            //!((5 <= 3 && !true) && ((8==7) && !(!true))) //true
            //!((false) && ((false) && (false))) //true
            //!(false && !0 && !((1 != 0) && (!true))) //true
            //&& //and
            //|| //or
            //1 || 0 //true
            //1 || 1 //true
            //0 || 0 //false
            //0 >= 1 || 1 == -1 //false
            //!((1 >= 5 && 3 >= 3)) //true
            //!(2 == 3 || (4 >= 5 && !false)) //true
            //(5 >= 4) && !(true) || !(5 < 6) //false
            //!(0 <= 1) && 2==3 || 1 < 3 //true
            !(!(5 <= 2) || !(5 >= 2) && (9 - 6 < 2) || (3 == 3) && !(5 <= 3) && !(2 - 1 == -1) && (3 <= 0) && !(2 > 3) || !(2 <= -5) || (true != false) && !(2 > 5) || !(3 - 4 <= 0) && !true || (2 != 5) && (10 < -1) && !false == (5 <= 7) || !true || (2 > 0) || !true && !(5 <= 8))
              //!(true || false && false || true && true && true && false && true || true || true && true || false && false || true && false && true || false || true || false && false) = true











        }
    }
}
}
