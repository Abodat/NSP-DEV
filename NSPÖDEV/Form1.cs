using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖĞRENCİ ADI............:Batuhan Öksüz    
** ÖĞRENCİ NUMARASI.......:b191200003   
****************************************************************************/

namespace NSPÖDEV
{
    public partial class Form1 : Form
    {
        double fiyat0=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int a1 = listView1.SelectedItems[0].Index;
            int a2 = listView2.SelectedItems[0].Index;

            double b1, b2, s;
            String c1, c2;

            Secilen.Items.Add(listView1.SelectedItems[0].Text);

            Secilen.Items.Add(listView2.SelectedItems[0].Text);

            c1 = listView1.Items[a1].SubItems[1].Text;

            c2 = listView2.Items[a2].SubItems[1].Text;

            b1 = Convert.ToDouble(c1);

            b2 = Convert.ToDouble(c2);

            s = b1 + b2 + fiyat0;
            fiyat1.Text = s.ToString();

            fiyat0 = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Secilen.Items.Clear();
            fiyat1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            
            f2.ShowDialog();
            this.Close();


        }
    }
}
