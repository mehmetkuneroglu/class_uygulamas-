using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace class_uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.ad = textBox1.Text;
            musteri.soyad = textBox2.Text;          
            musteri.tel = textBox4.Text;                 
            musteri.il = textBox6.Text;
            musteri.ilçe = textBox7.Text;
            musteri.adres = textBox8.Text;
            musteri.alacak =Convert.ToInt32(textBox3.Text);

            string[] dizi = { musteri.ad, musteri.soyad, musteri.tel, musteri.il, musteri.ilçe, musteri.adres, musteri.alacak.ToString() };
            ListViewItem lst = new ListViewItem(dizi);
            listView1.Items.Add(lst);
        }
    }
}
