using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashUygulama
{
    public partial class Form1 : Form
    {
        HashMap hashTable = new HashMap();
        HashMapChain hashTableChain = new HashMapChain();
        Personel[] p = new Personel[5];
        public Form1()
        {
            
            InitializeComponent();
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new Personel();
            }
            p[0].adayAd = "Ali";
            p[0].adayMail = "ali@hotmail.com";
            p[1].adayAd = "Veli";
            p[1].adayMail = "veli@hotmail.com";
            p[2].adayAd = "Ayse";
            p[2].adayMail = "ayse@hotmail.com";
            p[3].adayAd = "Aslı";
            p[3].adayMail = "asli@hotmail.com";
            p[4].adayAd = "Hasan";
            p[4].adayMail = "hasan@hotmail.com";
            for (int i = 0; i < p.Length; i++)
            {
                p[i].adayNo = i * 5;
                hashTable.AddPersonel(p[i].adayNo, p[i]);
              
            }
            for (int i = 0; i < p.Length; i++)
            {
                
                hashTableChain.AddPersonel(p[i].adayNo, p[i]);

            }
        }
        
        private void btnLinear_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            txtMail.Text = String.Empty;
            if (hashTable.GetPersonel(Convert.ToInt32(txtSearch.Text))==null)
            {
                MessageBox.Show("Kayit bulunamadi");
            }
            else
            {
                txtName.Text = hashTable.GetPersonel(Convert.ToInt32(txtSearch.Text)).adayAd.ToString();
                txtMail.Text = hashTable.GetPersonel(Convert.ToInt32(txtSearch.Text)).adayMail.ToString();
            }
            

        }


        private void btnChaning_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            txtMail.Text = String.Empty;
            if (hashTableChain.GetPersonel(Convert.ToInt32(txtSearch.Text)) == null)
            {
                MessageBox.Show("Kayit bulunamadi");
            }
            else
            {
                txtName.Text = hashTableChain.GetPersonel(Convert.ToInt32(txtSearch.Text)).adayAd.ToString();
                txtMail.Text = hashTableChain.GetPersonel(Convert.ToInt32(txtSearch.Text)).adayMail.ToString();
            }
        }

        
    }
}
