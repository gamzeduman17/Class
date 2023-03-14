using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi=txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if(kullaniciAdi=="admin" && sifre=="123")
            {
                anaFormcs _anaform=new anaFormcs(kullaniciAdi);
                _anaform.Show();
            

            }

            else
            {

                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI");
            }
        }
    }
}
