using Microsoft.Win32;
using Spotify.Helpers;
using System.Data.SqlClient;

namespace Spotify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = sqlhelper.ExecuteQuery($"SELECT*FROM Users WHERE Username='{Username.Text}'and Password='{Password.Text}' ");
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Xosh Gelmisiz.");

            }
            else
            {
                MessageBox.Show("Isdifadeci tapilmadi!");
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Qeydiyat qeydiyat = new Qeydiyat();
            this.Hide();
            qeydiyat.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
