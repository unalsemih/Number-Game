using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int uzunluk = 0, hakSayisi = 0,basamakSayisi=0;

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.numberOfDigits = (int)numOfDigits.Value;
            form2.remaining = (int)numOfRights.Value;
            form2.unrepeated = checkBox1.Checked;
            this.Hide();
            form2.Show();
            
        }

       

  
    }
}
