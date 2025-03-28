using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, Dogru = 0, Yanlis = 0;

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "SONRAKİ";
            soruno ++;
            this.Text = soruno.ToString();
           

            if ( soruno == 1 )
            {
                richTextBox1.Text = "Avrupa'da en büyük ülke"; //Almanya
                button1.BackColor = Color.Yellow;
                button25.Enabled = false;
            }
            if ( soruno == 2 )
            {
                richTextBox1.Text = "Sınıfta bir eşya, her ülkede var, Amerikanın rengi kırmızı, beyaz ve  mavi"; //Bayrak
                button2.BackColor = Color.Yellow;
            }
            if ( soruno == 3 )
            {
                richTextBox1.Text = "Haftasonunda bir gün"; //Cumartesi
                button3 .BackColor = Color.Yellow;
            }
            if ( soruno == 4 )
            {
                richTextBox1.Text = "Rengi mavi, büyük su topluluğu";  //Deniz
                button4.BackColor = Color.Yellow;
            }
            if ( soruno == 5 )
            {
                richTextBox1.Text = "Bir sıfat, yeni değil yeninin zıttı"; //Eski
                button5.BackColor = Color.Yellow;
            }
            if ( soruno == 6 )
            {
                richTextBox1.Text = "Kuzey Afrika'da bir ülke";//fas
                button6 .BackColor = Color.Yellow;
            }
            if ( soruno == 7 )
            {
                richTextBox1.Text = "Çocuk değil, yaşlı değil, çocukla yaşlının ortası"; //Genç 
                button7.BackColor = Color.Yellow;
            }
            if ( soruno == 8 )
            {
                richTextBox1.Text = "Doktora giden insanlar"; //Hasta
                button8.BackColor =  Color.Yellow;
            }
            if ( soruno == 9 )
            {
                richTextBox1.Text = "Türkiyenin komşusu bir ülke"; //Irak
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Süte veren, eti yenilen bir çiftlik hayvanı"; //İnek
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Uzak doğu Asyada bir ülke, Korenin komşusu"; //Japonya
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "İnsanların kitap alıp kitap okuduğu yer"; //Kütüphane
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Sarı renkli, ekşi bir meyve"; //Limon
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Muzu çok seven hayvan"; //Maymun
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "En çok kullanılan soru kelimesi"; //Ne
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Öğrenciler ve öğretmenlerin haftda beş gün gittiği yer"; //Okul
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "İnsanların genelde sevdiği, kahverengi bir sebze. Kızartması yapılır"; //Patates
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "İnsana benzer ama makine"; //Robot
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Haftanın bir günü"; //Salı
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Yumurta yapan, eti güzel olan bir hayvan"; //Tavuk
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Hatırlamamak"; //Unutmak
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Türkiye'de kedisi çok meşhur bir il"; //Van
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Bir mevsim, hava genellikle çok sıcaktır"; //Yaz
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Siyah beyaz bir hayvan"; //Zebra
                button24.BackColor = Color.Yellow;
                button26.Visible = true;
                button25.Enabled = true;





            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "Almanya")
                        {
                            button1.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "Bayrak")
                        {
                             button2.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "Cumartesi")
                        {
                            button3.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                   case 4:
                        if (textBox1.Text == "Deniz")
                        {
                            button4.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                  case 5: 
                        if (textBox1.Text == "Eski")
                        {
                            button5.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                  case 6:
                        if (textBox1.Text == "Fas")
                        {
                            button6.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;
                    
                  case 7:
                        if (textBox1.Text == "Genç")
                        {
                            button7.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;
                  case 8:
                        if (textBox1.Text == "Hasta")
                        {
                            button8.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 9: 
                        if (textBox1.Text == "Irak")
                        {
                            button9.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 10:
                        if (textBox1.Text == "İnek")
                        {
                            button10.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 11:
                        if (textBox1.Text == "Japonya")
                        {
                            button11.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }  
                        else
                        {
                            button11.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 12:
                        if (textBox1.Text == "Kütüphane")
                        {
                            button12.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 13: 
                        if (textBox1.Text == "Limon")
                        {
                            button13.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 14:
                        if (textBox1.Text == "Maymun")
                        {
                            button14.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 15:
                        if (textBox1.Text == "Ne")
                        {
                            button15.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 16:
                        if (textBox1.Text == "Okul")
                        {
                            button16.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 17:
                        if (textBox1.Text == "Patates")
                        {
                            button17.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 18:
                        if (textBox1.Text == "Robot")
                        {
                            button18.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 19:
                        if (textBox1.Text == "Salı")
                        {
                            button19.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 20:
                        if (textBox1.Text == "Tavuk")
                        {
                            button20.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 21:
                        if (textBox1.Text == "Unutmak")
                        {
                            button21.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 22:
                        if (textBox1.Text == "Van")
                        {
                            button23.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 23:
                        if (textBox1.Text == "Yaz")
                        {
                            button24.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;

                    case 24:
                        if (textBox1.Text == "Zebra")
                        {
                            button25.BackColor = Color.Green;
                            Dogru++;
                            label3.Text = Dogru.ToString();
                        }
                        else
                        {
                            button25.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        break;
                }
            }
        }



        private void button26_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0")
            {
                MessageBox.Show("24 Sorudan 0 tanesinin bildiniz Durum = Başarısız", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "1" )
            {
                MessageBox.Show("24 Sorudan 1 tanesinin bildiniz Durum = Başarısız", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "2" )
            {
                MessageBox.Show("24 Sorudan 2 tanesinin bildiniz Durum = Başarısız", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "3")
            {
                MessageBox.Show("24 Sorudan 3 tanesinin bildiniz Durum = Başarısız", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "4")
            {
                MessageBox.Show("24 Sorudan 4 tanesinin bildiniz Durum = Başarısız", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "5")
            {
                MessageBox.Show("24 Sorudan 5 tanesinin bildiniz Durum = Başarısız", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "6")
            {
                MessageBox.Show("24 Sorudan 6 tanesinin bildiniz Durum = Zayıf", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "7")
            {
                MessageBox.Show("24 Sorudan 7 tanesinin bildiniz Durum = Zayıf", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "8")
            {
                MessageBox.Show("24 Sorudan 8 tanesinin bildiniz Durum = Zayıf", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "9")
            {
                MessageBox.Show("24 Sorudan 9 tanesinin bildiniz Durum = Zayıf", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "10")
            {
                MessageBox.Show("24 Sorudan 10 tanesinin bildiniz Durum = Zayıf", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "11")
            {
                MessageBox.Show("24 Sorudan 11 tanesinin bildiniz Durum = Geliştirilebilir", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "12")
            {
                MessageBox.Show("24 Sorudan 12 tanesinin bildiniz Durum = Geliştirilebilir", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "13")
            {
                MessageBox.Show("24 Sorudan 13 tanesinin bildiniz Durum = Geliştirilebilir", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "14")
            {
                MessageBox.Show("24 Sorudan 14 tanesinin bildiniz Durum = Kabul edilebilir", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "16")
            {
                MessageBox.Show("24 Sorudan 16 tanesinin bildiniz Durum = Kabul edilebilir", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "17")
            {
                MessageBox.Show("24 Sorudan 17 tanesinin bildiniz Durum = Kabul edilebilir", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "18")
            {
                MessageBox.Show("24 Sorudan 18 tanesinin bildiniz Durum = İyi", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "19")
            {
                MessageBox.Show("24 Sorudan 1 tanesinin bildiniz Durum = İyi", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "20")
            {
                MessageBox.Show("24 Sorudan 20 tanesinin bildiniz Durum = Başarılı", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "21")
            {
                MessageBox.Show("24 Sorudan 21 tanesinin bildiniz Durum = Başarılı", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "22")
            {
                MessageBox.Show("24 Sorudan 22 tanesinin bildiniz Durum = Mükemmel", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "23")
            {
                MessageBox.Show("24 Sorudan 23 tanesinin bildiniz Durum = Mükemmel", "Bilgi", MessageBoxButtons.OK);
            }
            if (label3.Text == "24")
            {
                MessageBox.Show("24 Sorudan 24 tanesinin bildiniz Durum = Mükemmel", "Olağanüstü", MessageBoxButtons.OK);
            }
        }
    }
}
