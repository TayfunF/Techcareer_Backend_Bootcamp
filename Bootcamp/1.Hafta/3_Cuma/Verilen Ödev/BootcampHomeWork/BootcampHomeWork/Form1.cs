using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootcampHomeWork
{
    public partial class Form1 : Form
    {
        // Global Ids Dizi Tanimi
        List<int> NumbersArrays = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        // ekle butonu
        private void Add_Click(object sender, EventArgs e)
        {
            //string olarak aldigim ifadeyi int 'e Cevirme
            int NumberAdd = Convert.ToInt32(TxtNumbers.Text);

            // sayiyi listeye ekle
            NumbersArrays.Add(NumberAdd);

            // ekledikten sonra txtbox 'i temizle
            TxtNumbers.Clear();

            // ekran da ekledigim sayilari goreyim diye liste
            listBox1.Items.Add(NumberAdd);
        }

        // sil butonu
        private void RemoveAt_Click(object sender, EventArgs e)
        {
            // string olarak aldigim ifadeyi int 'e Cevirme
            int Find = Convert.ToInt32(TxtNumbers.Text);

            // index 'e karsilik gelen degeri bul
            int NumberRemove = NumbersArrays.FindIndex(Index => Index == Find);

            // bulunan bu degeri listeden sil
            NumbersArrays.RemoveAt(NumberRemove);

            // textboxt 'i temizle
            TxtNumbers.Clear();

            // ekranda da sil
            listBox1.Items.RemoveAt(NumberRemove);
        }
    }
}
