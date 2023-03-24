using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASSAPAROLA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0,dogru=0,yanlis=0;
        int saniye = 60,dakika=2;
        

        private void btnCevap_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            timer1.Start();
            btnCevap.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Avrupa'da en büyük ülke";
                btnA.BackColor = Color.Yellow;
                btnKare.Text = btnA.Text;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Misket";
                btnB.BackColor = Color.Yellow;
                btnKare.Text = btnB.Text;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Ağustos böceği";
                btnC.BackColor = Color.Yellow;
                btnKare.Text = btnC.Text;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Rengi mavi,büyük su topluluğu";
                btnD.BackColor = Color.Yellow;
                btnKare.Text = btnD.Text;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Okullar da mukavva kağıt gibi şeylerke yapılan çalışmalar";
                btnE.BackColor = Color.Yellow;
                btnKare.Text = btnE.Text;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Kuzey afrikada bir ülke";
                btnF.BackColor = Color.Yellow;
                btnKare.Text = btnF.Text;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Umulmadık zamanda umulmadık biçimde olan kaza";
                btnG.BackColor = Color.Yellow;
                btnKare.Text = btnG.Text;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Düzen,entrika";
                btnH.BackColor = Color.Yellow;
                btnKare.Text = btnH.Text;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Türkiye'nin komşusu bir ülke";
                btnI.BackColor = Color.Yellow;
                btnKare.Text = btnI.Text;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Olanak";
                btnil.BackColor = Color.Yellow;
                btnKare.Text = btnil.Text;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Uzak Doğu Asyada bir ülke,Korenin komşusu";
                btnJ.BackColor = Color.Yellow;
                btnKare.Text = btnJ.Text;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Yolcu trenlerinde biletleri denetleyen ve vagon işlerine bakan görevli";
                btnK.BackColor = Color.Yellow;
                btnKare.Text = btnK.Text;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Bulgarista'nın para birimi";
                btnL.BackColor = Color.Yellow;
                btnKare.Text = btnL.Text;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Muzu çok seven bir hayvan";
                btnM.BackColor = Color.Yellow;
                btnKare.Text = btnM.Text;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Özellikle tekke müziğinde kullanılan üflemeli çalgı";
                btnN.BackColor = Color.Yellow;
                btnKare.Text = btnN.Text;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Türklerin kuraklık nedeniyle göç ettiği ana yurdu";
                btnO.BackColor = Color.Yellow;
                btnKare.Text = btnO.Text;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Başın tamamını kaplıycak şekilde takılan takma saç";
                btnP.BackColor = Color.Yellow;
                btnKare.Text = btnP.Text;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Konusu bir soruşturma,araştırma olan gazete veya dergi yazısı";
                btnR.BackColor = Color.Yellow;
                btnKare.Text = btnR.Text;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Bir metrenin yüzde biri uzunluğundaki ölçü birimi";
                btnS.BackColor = Color.Yellow;
                btnKare.Text = btnS.Text;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Öğütülmüş susamın koyu sıvı durumu";
                btnT.BackColor = Color.Yellow;
                btnKare.Text = btnT.Text;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Uzun birşeyin baş veya son noktası";
                btnU.BackColor = Color.Yellow;
                btnKare.Text = btnU.Text;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Ortalama";
                btnV.BackColor = Color.Yellow;
                btnKare.Text = btnV.Text;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Kabiliyet";
                btnY.BackColor = Color.Yellow;
                btnKare.Text = btnY.Text;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "İstiklal marşının bestecisi";
                btnZ.BackColor = Color.Yellow;
                btnKare.Text = btnZ.Text;
            }
            
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "Almanya")
                        {
                            btnA.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnA.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "Bilye")
                        {
                            btnB.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnB.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "Cırcır böceği")
                        {
                            btnC.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnC.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "Deniz")
                        {
                            btnD.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnD.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "El işi")
                        {
                            btnE.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnE.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "Fas")
                        {
                            btnF.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnF.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "Görünmez kaza")
                        {
                            btnG.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnG.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "Hile")
                        {
                            btnH.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnH.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "Irak")
                        {
                            btnI.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnI.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "İmkan")
                        {
                            btnil.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnil.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "Japonya")
                        {
                            btnJ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnJ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "Kondüktör")
                        {
                            btnK.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnK.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "Leva")
                        {
                            btnL.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnL.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Maymun")
                        {
                            btnM.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnM.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "Ney")
                        {
                            btnN.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnN.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "Orta Asya")
                        {
                            btnO.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnO.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "Peruk")
                        {
                            btnP.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnP.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "Röportaj")
                        {
                            btnR.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnR.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "Santimetre")
                        {
                            btnS.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnS.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "Tahin")
                        {
                            btnT.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnT.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "Uç")
                        {
                            btnU.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnU.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "Vasat")
                        {
                            btnV.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnV.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "Yetenek")
                        {
                            btnY.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnY.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "Zeki Üngör")
                        {
                            btnZ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnZ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlıs.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = (dakika-1).ToString();
            if(saniye == 0)
            {
                dakika--;
                lblDakika.Text = dakika.ToString();
                saniye = 60;
            }
            if (lblDakika.Text == "-1")
            {
                timer1.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
                MessageBox.Show("Süreniz Doldu!");
            }
        }
    }
}
