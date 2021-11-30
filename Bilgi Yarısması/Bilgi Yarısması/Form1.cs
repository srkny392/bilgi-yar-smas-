using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarısması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label4.Text = btnD.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label4.Text = btnB.Text;
            if (label2.Text==label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label4.Text = btnC.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label4.Text = btnA.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonraki.Enabled = false;

            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label2.Text = "1923";

            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangi il ege bölgemizde bulunmaz?";
                btnA.Text = "İzmir";
                btnB.Text = "Ankara";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label2.Text = "Ankara";
            }
            if (soruno==3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                btnA.Text = "Sait Faik Abasıyanık";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Attila İlhan";
                btnD.Text = "Reşat Nuri Gültekin";
                label2.Text= "Sait Faik Abasıyanık";


            }


        }
    }
}

