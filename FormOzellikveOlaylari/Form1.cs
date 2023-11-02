using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOzellikveOlaylari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            button2.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            textBox1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));



            // this : Bu formu ifade eder. Form ile ilgili işlemler yapabilmek için formun 
            // Name i yerine this kullanacağız.

            // Ekranda mesaj kutusu göster.
            MessageBox.Show("Formun arka plan rengi değişti");
            // Burada Show un içine çift tırnak içerisinde yazılan herşey ekranda aynen gösterilir.
            // btnRenginiAyarla. dedikten sonra açılan penceredeki sarı simgeli olanlar özellik, 
           // şimşek simgeli olanlar olay, mor simgeli olanlar da metot olarak adlandırılırlar.        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Load olayında değişti";
            MessageBox.Show("Programa Hoşgeldiniz");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Güle güle, Araya çıkabilirsiniz.\n Ders Bitmiştir.");
            // Bu olay, form kapatılmaya çalışıldığında, form kapanmadan hemen önce çalışır. ondan 
            //sonra form kapanır.
        }
    }
}
