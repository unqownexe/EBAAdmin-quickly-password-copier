using System;
using System.Windows.Forms;
namespace ETPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            Clipboard.SetText("H3gY!*pA79fK5%1");
            //MessageBox.Show("Şifre başarıyla panoya kopyalandı.", "EBAAdmin");
            this.Hide();
            Application.Exit();
        }
    }
}
