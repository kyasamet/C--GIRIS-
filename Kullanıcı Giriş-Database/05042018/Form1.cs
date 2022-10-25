using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace _05042018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection isim=new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=11a.accdb");
            OleDbCommand isim_1;
            OleDbDataReader isim_2;

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void bul_Click(object sender, EventArgs e)
            {
                isim.Open();
                isim_1 = new OleDbCommand("SELECT Okulno, Ad,Soyad, Sınıfı, Alanı FROM 11AV where Okulno= "+okulno.Text,isim);
                isim_2 = isim_1.ExecuteReader();
                if (isim_2.Read())
                {
                    okulno.Text = isim_2[0].ToString();
                    adsoyad.Text = isim_2[1] + " " + isim_2[2].ToString();
                    sinif.Text = isim_2[3].ToString();
                    alan.Text = isim_2[4].ToString();
                }
                isim.Close();

            }

            private void guncel_Click(object sender, EventArgs e)
            {
                isim.Open();
                isim_1=new OleDbCommand("Update 11AV Set Ad=" + adsoyad.Text + " Where Okulno=" + okulno.Text,isim);
                isim_1.Connection = isim;
                isim_1.ExecuteNonQuery();
                isim.Close();
            }

           

            
        
    }
}
