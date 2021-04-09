using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indirim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadedi,indirim;
            double fiyat;
           
            fiyat = Convert.ToInt32(txtfiyat.Text);
            kitapadedi = Convert.ToInt32(txtkitap.Text);
            
            if (kitapadedi <=20)
            {
                indirim = Convert.ToInt32(fiyat*0.4);
                fiyat = (kitapadedi * fiyat) - (fiyat * 0.8);
                lbltoplam.Text = fiyat.ToString();
                lbltutar.Text = indirim.ToString();

            }

            else if (kitapadedi>20 && kitapadedi<=40)
            {
                indirim = Convert.ToInt32(fiyat * 0.6);
                fiyat = (kitapadedi * fiyat) - (fiyat * 0.6);
                lbltoplam.Text = fiyat.ToString();
                lbltutar.Text = indirim.ToString();
            }


        }
    }
}
