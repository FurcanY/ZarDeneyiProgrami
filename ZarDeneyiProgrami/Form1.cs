using System.Diagnostics;

namespace ZarDeneyiProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int atilacakzarsayisi = 0;
        int atilanzarsayisi = 0;
        int zar1 = 0, zar2 = 0;
        int zartoplam = 0;
        int[] toplamzarsonuc = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


        bool ayarPanelAcikMi = false;

        void ZarAt()
        {
            Random rnd = new Random();
            zar1 = rnd.Next(1, 7);
            zar2 = rnd.Next(1, 7);
        }
        private void Basla_btn_Click(object sender, EventArgs e)
        {

            atilacakzarsayisi = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            timer1.Enabled = true;
            ayar_btn.Enabled = false;
            Basla_btn.Enabled = false;
            ayarPanelAcikMi = false;
            ayar_pnl.Visible = false;
            BarAyarla();
        }
        void BarAyarla()
        {
            zar2bar.Maximum = atilacakzarsayisi / 2;
            zar3bar.Maximum = atilacakzarsayisi / 2;
            zar4bar.Maximum = atilacakzarsayisi / 2;
            zar5bar.Maximum = atilacakzarsayisi / 2;
            zar6bar.Maximum = atilacakzarsayisi / 2;
            zar7bar.Maximum = atilacakzarsayisi / 2;
            zar8bar.Maximum = atilacakzarsayisi / 2;
            zar9bar.Maximum = atilacakzarsayisi / 2;
            zar10bar.Maximum = atilacakzarsayisi / 2;
            zar11bar.Maximum = atilacakzarsayisi / 2;
            zar12bar.Maximum = atilacakzarsayisi / 2;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            atilanzarsayisi++;
            ZarAt();
            zartoplam = zar1 + zar2;
            toplamzarsonuc[zartoplam]++;
            string[] sonuclar = { atilanzarsayisi.ToString(), zar1.ToString(), zar2.ToString(), zartoplam.ToString() };
            ListViewItem Mylist = new ListViewItem(sonuclar);
            sonuc_lstview.Items.Add(Mylist);
            ToplamSonucPanel(zartoplam);
            if (atilanzarsayisi == atilacakzarsayisi)
            {

                timer1.Enabled = false;
                ayar_btn.Enabled = true;
                button1.Enabled = true;
                string[] ensonsonuc = {atilanzarsayisi.ToString(),
                ((float)toplamzarsonuc[2] / atilacakzarsayisi * 100).ToString(),
                ((float)toplamzarsonuc[3] / atilacakzarsayisi * 100).ToString(),
                ((float)toplamzarsonuc[4] / atilacakzarsayisi * 100).ToString()
                , ((float) toplamzarsonuc[5] / atilacakzarsayisi * 100).ToString()
                , ((float) toplamzarsonuc[6] / atilacakzarsayisi * 100).ToString()
                , ((float) toplamzarsonuc[7] / atilacakzarsayisi * 100).ToString()
                , ((float) toplamzarsonuc[8] / atilacakzarsayisi * 100).ToString()
                , ((float) toplamzarsonuc[9] / atilacakzarsayisi * 100).ToString()
                , ((float) toplamzarsonuc[10] / atilacakzarsayisi * 100).ToString()
                ,((float)toplamzarsonuc[11] / atilacakzarsayisi * 100).ToString()
                ,((float)toplamzarsonuc[12] / atilacakzarsayisi * 100).ToString()
                };
                ListViewItem sonuc = new ListViewItem(ensonsonuc);
                analiz_listview.Items.Add(sonuc);
            }

        }
        void ToplamSonucPanel(int zartoplam)
        {
            switch (zartoplam)
            {
                case 2:
                    zar2_lbl.Text = "Toplam 2 Gelen Zar Sayisi: " + toplamzarsonuc[zartoplam].ToString() + "  % " + ((float)toplamzarsonuc[zartoplam] / atilacakzarsayisi * 100).ToString();
                    zar2bar.Value = toplamzarsonuc[zartoplam];
                    break;

                case 3:
                    zar3_lbl.Text = "Toplam 3 Gelen Zar Sayisi: " + toplamzarsonuc[zartoplam].ToString() + "  % " + ((float)toplamzarsonuc[zartoplam] / atilacakzarsayisi * 100).ToString();
                    zar3bar.Value = toplamzarsonuc[zartoplam];
                    break;

                case 4:
                    zar4_lbl.Text = "Toplam 4 Gelen Zar Sayisi: " + toplamzarsonuc[zartoplam].ToString() + "  % " + ((float)toplamzarsonuc[zartoplam] / atilacakzarsayisi * 100).ToString();
                    zar4bar.Value = toplamzarsonuc[zartoplam];
                    break;

                case 5:
                    zar5_lbl.Text = "Toplam 5 Gelen Zar Sayisi: " + toplamzarsonuc[zartoplam].ToString() + "  % " + ((float)toplamzarsonuc[zartoplam] / atilacakzarsayisi * 100).ToString();
                    zar5bar.Value = toplamzarsonuc[zartoplam];
                    break;

                case 6:
                    zar6_lbl.Text = "Toplam 6 Gelen Zar Sayisi: " + toplamzarsonuc[zartoplam].ToString() + "  % " + ((float)toplamzarsonuc[zartoplam] / atilacakzarsayisi * 100).ToString();
                    zar6bar.Value = toplamzarsonuc[zartoplam];
                    break;

                case 7:
                    zar7_lbl.Text = "Toplam 7 Gelen Zar Sayisi: " + toplamzarsonuc[zartoplam].ToString() + "  % " + ((float)toplamzarsonuc[zartoplam] / atilacakzarsayisi * 100).ToString();
                    zar7bar.Value = toplamzarsonuc[zartoplam];
                    break;

                case 8:
                    zar8_lbl.Text = "Toplam 8 Gelen Zar Sayisi: " + toplamzarsonuc[zartoplam].ToString() + "  % " + ((float)toplamzarsonuc[zartoplam] / atilacakzarsayisi * 100).ToString();
                    zar8bar.Value = toplamzarsonuc[zartoplam];
                    break;

                case 9:
                    zar9_lbl.Text = "Toplam 9 Gelen Zar Sayisi: " + toplamzarsonuc[zartoplam].ToString() + "  % " + ((float)toplamzarsonuc[zartoplam] / atilacakzarsayisi * 100).ToString();
                    zar9bar.Value = toplamzarsonuc[zartoplam];
                    break;

                case 10:
                    zar10_lbl.Text = "Toplam 10 Gelen Zar Sayisi: " + toplamzarsonuc[zartoplam].ToString() + "  % " + ((float)toplamzarsonuc[zartoplam] / atilacakzarsayisi * 100).ToString();
                    zar10bar.Value = toplamzarsonuc[zartoplam];
                    break;

                case 11:
                    zar11_lbl.Text = "Toplam 11 Gelen Zar Sayisi: " + toplamzarsonuc[zartoplam].ToString() + "  % " + ((float)toplamzarsonuc[zartoplam] / atilacakzarsayisi * 100).ToString();
                    zar11bar.Value = toplamzarsonuc[zartoplam];
                    break;

                case 12:
                    zar12_lbl.Text = "Toplam 12 Gelen Zar Sayisi: " + toplamzarsonuc[zartoplam].ToString() + "  % " + ((float)toplamzarsonuc[zartoplam] / atilacakzarsayisi * 100).ToString();
                    zar12bar.Value = toplamzarsonuc[zartoplam];
                    break;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //atilacakzarsayisi = Convert.ToInt32(textBox1.Text);
        }

        private void ayar_btn_Click(object sender, EventArgs e)
        {
            if (ayarPanelAcikMi)
            {
                ayarPanelAcikMi = false;
                ayar_pnl.Visible = false;
            }
            else if (ayarPanelAcikMi == false)
            {
                ayarPanelAcikMi = true;
                ayar_pnl.Visible = true;
            }
        }

        private void ayar_btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void ayar_btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void hiz_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            atilanzarsayisi = 0;
            sonuc_lstview.Items.Clear();
            textBox1.Clear();
            zar12_lbl.Text = "Toplam 12 Gelen Zar Sayisi: ";
            zar11_lbl.Text = "Toplam 11 Gelen Zar Sayisi: ";
            zar10_lbl.Text = "Toplam 10 Gelen Zar Sayisi: ";
            zar9_lbl.Text = "Toplam 9 Gelen Zar Sayisi: ";
            zar8_lbl.Text = "Toplam 8 Gelen Zar Sayisi: ";
            zar7_lbl.Text = "Toplam 7 Gelen Zar Sayisi: ";
            zar6_lbl.Text = "Toplam 6 Gelen Zar Sayisi: ";
            zar5_lbl.Text = "Toplam 5 Gelen Zar Sayisi: ";
            zar4_lbl.Text = "Toplam 4 Gelen Zar Sayisi: ";
            zar3_lbl.Text = "Toplam 3 Gelen Zar Sayisi: ";
            zar2_lbl.Text = "Toplam 2 Gelen Zar Sayisi: ";
            zar2bar.Value = 0;
            zar3bar.Value = 0;
            zar4bar.Value = 0;
            zar5bar.Value = 0;
            zar6bar.Value = 0;
            zar7bar.Value = 0;
            zar8bar.Value = 0;
            zar9bar.Value = 0;
            zar10bar.Value = 0;
            zar11bar.Value = 0;
            zar12bar.Value = 0;

            Basla_btn.Enabled = true;
            for (int i = 0; i < 13; i++)
            {
                toplamzarsonuc[i] = 0;
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(hiz_txtbox.Text);
            label3.Text = "Ne kadar Hizli sonuc gelecegini ayarlayiniz\r\n suan:" + timer1.Interval.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Ne kadar Hizli sonuc gelecegini ayarlayiniz\r\n suan:" + timer1.Interval.ToString();
        }

        
    }
}