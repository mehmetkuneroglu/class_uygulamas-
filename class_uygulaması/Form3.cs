using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_uygulaması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tedarikci tedarikci = new Tedarikci();
            tedarikci.ad = textBox1.Text;
            tedarikci.soyad = textBox2.Text;
            tedarikci.tel = textBox4.Text;
            tedarikci.il = textBox6.Text;
            tedarikci.ilçe = textBox7.Text;
            tedarikci.adres = textBox8.Text;
            tedarikci.borc = Convert.ToInt32(textBox3.Text);
            tedarikci.ticariUnvan = textBox5.Text;
            tedarikci.website = textBox11.Text;
            tedarikci.vd = textBox9.Text;
            tedarikci.vno = textBox10.Text;

            string[] dizi = {tedarikci.ticariUnvan, tedarikci.ad, tedarikci.soyad, tedarikci.tel,tedarikci.website, tedarikci.il,
                tedarikci.ilçe, tedarikci.adres,tedarikci.vd,tedarikci.vno, tedarikci.borc.ToString() };

            ListViewItem lst = new ListViewItem(dizi);
            listView1.Items.Add(lst);
        }
    }
}
