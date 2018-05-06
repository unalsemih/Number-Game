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
    public partial class Form2 : Form
    {
        public Form2()  
        {
            InitializeComponent();
        }
        public int remaining;
        public int numberOfDigits;
        
        public Boolean unrepeated;
        int number = 0;
        int[] digits = new int[5];//Sayıların basamaklarının atanacağı dizi.Kontrolde Kullanılacak
        
        void hazirlik()
        {//sayılar basamaklarına ayrılıyor ve basamak sayısına göre textBoxlar aktif hale geliyor.
            for (int k = 1; k <= numberOfDigits; k++)
            {
                TextBox txtBox = (TextBox)this.Controls["textBox" + k];
                Label lbl = (Label)this.Controls["label" + k];
                txtBox.Enabled = true;
                lbl.Enabled = true;
                digits[k - 1] = (number.ToString())[k - 1] - '0';
            }
        }
        int tekrarKontrol()//Sayının tekrarlı olup olmadığı kontrol ediliyor.
        {
            Random rnd = new Random();
            int status = 1;
            for (int i = 0; i < numberOfDigits; i++)
            {
                for (int j = 0; j < numberOfDigits; j++)
                {
                    if ((i != j) && number.ToString()[i] - '0' == number.ToString()[j] - '0')
                    {
                        status = 0;
                        break;
                    }
                }
            }
            return status;
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            
            String alt = "1", ust = "9";
            lblKalanHak.Text = remaining.ToString();
          
            for(int i=1; i< numberOfDigits; i++)
            {

                alt += "0";
                ust += "9";
            }
            Random rnd = new Random();
            number = rnd.Next(int.Parse(alt), int.Parse(ust));

            while (unrepeated == true && tekrarKontrol()==0)
            {
                number = rnd.Next(int.Parse(alt), int.Parse(ust));//sayı tekrarlı olduğu müddetçe tekrar sayı üretiliyor.
                
            }

             hazirlik();//textBox ları aktif hale getirme vs.

           // MessageBox.Show("Uretilen Sayi : "+sayi);//Aranan Sayı Burada. 
            timer1.Enabled = true;
        }
        String girilensayi()
        {
            
            int j = 0;
            String input="";
            for (int i = numberOfDigits; i > 0; i--)
            {


                Label lbl = (Label)this.Controls["label"+i];
                TextBox txt = (TextBox)this.Controls["textBox" + i];
                lbl.BackColor = Color.FromArgb(255, 255, 192);//label lar orjinal rengini alır.
                input += txt.Text; //girilen sayinin basamakları birleştiriliyor.
                if (digits[j].ToString() == txt.Text)
                    lbl.BackColor = Color.Blue;//Doğru yerde olan sayıların label ı
                else
                {
                    for (int z =0; z< numberOfDigits; z++)
                    {
                        if(txt.Text == digits[z].ToString())
                        {
                            lbl.BackColor=Color.Red;//Sayının içinde bulunup yanlış yerde bulunanlar
                            break;
                        }
                    }
                }
                j++;
            }
            return input;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            //Kontrol butonu Click**
            if (1 == boslukKontrol())
            {

                lblKalanHak.Text = (--remaining).ToString();//1 hakkı gitti;

                String girilen = girilensayi();
                int girilenSayi;
                girilenSayi = int.Parse(girilen);
                if (girilenSayi == number)
                {
                    timer1.Enabled = false;
                    lblStatus.Text = "Tebrikler Kazandınız!";
                    btnKontrol.Enabled = false;
                    DialogResult cevap=MessageBox.Show("Tebrikler Bildiniz!\nTekrar Oynamak İster misiniz?","Kazandınız", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    cevapla(cevap);
                }
                else if (remaining == 0)
                {
                    timer1.Enabled = false;
                    lblStatus.Text = "Hakkınız Bitti\n Sayınız : "+ number;
                    DialogResult cevap = MessageBox.Show("\tARANAN SAYI : "+ number + "\nTekrar Denemek İster misiniz ? ", "Hakkınız Bitti", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    btnKontrol.Enabled = false;

                    cevapla(cevap);

                }
                else
                    lblSure.Text = "10".ToString();



          }
            else
                MessageBox.Show("Lütfen Bütün Basamakları Doldurunuz");

        }
        int boslukKontrol()//Boş olan textBox ları kontrol eder.Boşluk varsa 0 döndürür, yoksa 1 döndürür.
        {
            int durum = 1;
            for(int i=1; i<= numberOfDigits; i++)
            {
                TextBox txt = (TextBox)this.Controls["textBox" + i];
                if (txt.Text == "")
                    durum = 0;
            }
            return durum;
        }
        private void txt_CharControl(object sender, KeyPressEventArgs e)//Girilecek karakter kontrolü
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) ||(int)e.KeyChar==8)//ASCII Tablosu girilen karakterin rakam olduğunu kontrol ettim
                e.Handled = false; // Girilen karakter rakamsa yazdıracaktır.
            else
                e.Handled = true;
        }
        void cevapla(DialogResult answer)
        {
            if(answer==DialogResult.Yes)
            {
                button1.PerformClick();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSure.Text = (int.Parse(lblSure.Text) - 1).ToString();
            if (lblSure.Text == "0" && remaining == 1)
            {
                remaining--;
                lblKalanHak.Text = remaining.ToString();
                timer1.Enabled = false;
                btnKontrol.Enabled = false;
                lblStatus.Text = "Süreniz Bitti\nSayınız : "+ number;
                DialogResult cevap = MessageBox.Show("\tARANAN SAYI : " + number + "\nTekrar Denemek İstermisiniz ? ", "Süreniz Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                cevapla(cevap);

            }
            if (lblSure.Text == "0" && remaining > 1)
            {
                lblSure.Text = "10";
                remaining--;
                lblKalanHak.Text = remaining.ToString();
            }
         
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
