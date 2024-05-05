using Spotify.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify
{
    public partial class Qeydiyat : Form
    {
        public Qeydiyat()
        {
            InitializeComponent();
        }

        private void Qeydiyat_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            string nameVal=name.Text;
            string surnameVal=surname.Text;
            string genderVal = gender.Text.StartsWith("k")?"Kishi":"Qadin";
            string usernameVal = username.Text;

            string passwordVal = sqlhelper.HashPassword(password.Text);









            var result=  sqlhelper.Execute($"INSERT INTO Users VALUES(N'{nameVal}',N'{surnameVal}',N'{genderVal}','{usernameVal}','{passwordVal}')");
            if (result==0)
            {
                MessageBox.Show("Xeta bas verdi");
            }
            else
            {
                MessageBox.Show("Ugurla Qeydiyatdan kecdiniz");
            }

          
        }
    }
}
