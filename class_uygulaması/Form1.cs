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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pr = new Personel();
            pr.ad = textBox1.Text;
            pr.soyad = textBox2.Text;
            pr.tc = textBox3.Text;
            pr.tel = textBox4.Text;

            pr.email =textBox5.Text;
            pr.il = textBox6.Text;
            pr.ilçe = textBox7.Text;
            pr.adres =textBox8.Text;
            pr.dogumTarihi = dateTimePicker1.Value;
            pr.iseBaslamaTarihi = dateTimePicker2.Value;
            pr.maas = 25000;

            string[] dizi = {pr.ad,pr.soyad,pr.tc,pr.tel,pr.email,pr.il,pr.ilçe,pr.adres,pr.dogumTarihi.ToString(),pr.iseBaslamaTarihi.ToString() };
            ListViewItem lst = new ListViewItem(dizi);
            listView1.Items.Add(lst);
            


        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void müşteriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void tedarikçiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
