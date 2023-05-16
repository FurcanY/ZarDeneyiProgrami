namespace ZarDeneyiProgrami
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ZarAtma_pnl = new GroupBox();
            textBox1 = new TextBox();
            Basla_btn = new Button();
            label2 = new Label();
            sonuc_lstview = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            zarSonuc_pnl = new GroupBox();
            zar10bar = new ProgressBar();
            zar7bar = new ProgressBar();
            zar4bar = new ProgressBar();
            zar12bar = new ProgressBar();
            zar9bar = new ProgressBar();
            zar6bar = new ProgressBar();
            zar3bar = new ProgressBar();
            zar11bar = new ProgressBar();
            zar8bar = new ProgressBar();
            zar5bar = new ProgressBar();
            zar2bar = new ProgressBar();
            zar7_lbl = new Label();
            zar10_lbl = new Label();
            zar4_lbl = new Label();
            zar12_lbl = new Label();
            zar6_lbl = new Label();
            zar9_lbl = new Label();
            zar3_lbl = new Label();
            zar11_lbl = new Label();
            zar5_lbl = new Label();
            zar8_lbl = new Label();
            zar2_lbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ayar_btn = new Button();
            ayar_pnl = new Panel();
            hiz_txtbox = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            analiz_listview = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            ZarAtma_pnl.SuspendLayout();
            zarSonuc_pnl.SuspendLayout();
            ayar_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // ZarAtma_pnl
            // 
            ZarAtma_pnl.BackColor = Color.PaleTurquoise;
            ZarAtma_pnl.Controls.Add(textBox1);
            ZarAtma_pnl.Controls.Add(Basla_btn);
            ZarAtma_pnl.Controls.Add(label2);
            ZarAtma_pnl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ZarAtma_pnl.Location = new Point(12, 12);
            ZarAtma_pnl.Name = "ZarAtma_pnl";
            ZarAtma_pnl.Size = new Size(292, 174);
            ZarAtma_pnl.TabIndex = 0;
            ZarAtma_pnl.TabStop = false;
            ZarAtma_pnl.Text = "Zar Atma Paneli";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 29);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Basla_btn
            // 
            Basla_btn.BackColor = Color.White;
            Basla_btn.FlatStyle = FlatStyle.Flat;
            Basla_btn.Location = new Point(24, 119);
            Basla_btn.Name = "Basla_btn";
            Basla_btn.Size = new Size(238, 40);
            Basla_btn.TabIndex = 4;
            Basla_btn.Text = "Basla";
            Basla_btn.UseVisualStyleBackColor = false;
            Basla_btn.Click += Basla_btn_Click;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 30);
            label2.Name = "label2";
            label2.Size = new Size(208, 28);
            label2.TabIndex = 2;
            label2.Text = "Kac zar atilacagini giriniz:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sonuc_lstview
            // 
            sonuc_lstview.BackColor = Color.PaleTurquoise;
            sonuc_lstview.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            sonuc_lstview.FullRowSelect = true;
            sonuc_lstview.GridLines = true;
            sonuc_lstview.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            sonuc_lstview.Location = new Point(12, 226);
            sonuc_lstview.Name = "sonuc_lstview";
            sonuc_lstview.Size = new Size(292, 400);
            sonuc_lstview.TabIndex = 1;
            sonuc_lstview.UseCompatibleStateImageBehavior = false;
            sonuc_lstview.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Frekans";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "1.zar sonuc";
            columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "2.zarsonuc";
            columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "toplam";
            columnHeader4.Width = 75;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 189);
            label1.Name = "label1";
            label1.Size = new Size(292, 34);
            label1.TabIndex = 2;
            label1.Text = "Sonuclar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // zarSonuc_pnl
            // 
            zarSonuc_pnl.BackColor = Color.PaleTurquoise;
            zarSonuc_pnl.Controls.Add(zar10bar);
            zarSonuc_pnl.Controls.Add(zar7bar);
            zarSonuc_pnl.Controls.Add(zar4bar);
            zarSonuc_pnl.Controls.Add(zar12bar);
            zarSonuc_pnl.Controls.Add(zar9bar);
            zarSonuc_pnl.Controls.Add(zar6bar);
            zarSonuc_pnl.Controls.Add(zar3bar);
            zarSonuc_pnl.Controls.Add(zar11bar);
            zarSonuc_pnl.Controls.Add(zar8bar);
            zarSonuc_pnl.Controls.Add(zar5bar);
            zarSonuc_pnl.Controls.Add(zar2bar);
            zarSonuc_pnl.Controls.Add(zar7_lbl);
            zarSonuc_pnl.Controls.Add(zar10_lbl);
            zarSonuc_pnl.Controls.Add(zar4_lbl);
            zarSonuc_pnl.Controls.Add(zar12_lbl);
            zarSonuc_pnl.Controls.Add(zar6_lbl);
            zarSonuc_pnl.Controls.Add(zar9_lbl);
            zarSonuc_pnl.Controls.Add(zar3_lbl);
            zarSonuc_pnl.Controls.Add(zar11_lbl);
            zarSonuc_pnl.Controls.Add(zar5_lbl);
            zarSonuc_pnl.Controls.Add(zar8_lbl);
            zarSonuc_pnl.Controls.Add(zar2_lbl);
            zarSonuc_pnl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            zarSonuc_pnl.Location = new Point(334, 12);
            zarSonuc_pnl.Name = "zarSonuc_pnl";
            zarSonuc_pnl.Size = new Size(716, 444);
            zarSonuc_pnl.TabIndex = 3;
            zarSonuc_pnl.TabStop = false;
            zarSonuc_pnl.Text = "Toplam Sonuc";
            // 
            // zar10bar
            // 
            zar10bar.Location = new Point(447, 324);
            zar10bar.Name = "zar10bar";
            zar10bar.Size = new Size(231, 23);
            zar10bar.Step = 1;
            zar10bar.TabIndex = 6;
            // 
            // zar7bar
            // 
            zar7bar.Location = new Point(447, 210);
            zar7bar.Name = "zar7bar";
            zar7bar.Size = new Size(231, 23);
            zar7bar.Step = 1;
            zar7bar.TabIndex = 6;
            // 
            // zar4bar
            // 
            zar4bar.Location = new Point(447, 103);
            zar4bar.Name = "zar4bar";
            zar4bar.Size = new Size(231, 23);
            zar4bar.Step = 1;
            zar4bar.TabIndex = 6;
            // 
            // zar12bar
            // 
            zar12bar.Location = new Point(447, 405);
            zar12bar.Name = "zar12bar";
            zar12bar.Size = new Size(231, 23);
            zar12bar.Step = 1;
            zar12bar.TabIndex = 6;
            // 
            // zar9bar
            // 
            zar9bar.Location = new Point(447, 285);
            zar9bar.Name = "zar9bar";
            zar9bar.Size = new Size(231, 23);
            zar9bar.Step = 1;
            zar9bar.TabIndex = 6;
            // 
            // zar6bar
            // 
            zar6bar.Location = new Point(447, 172);
            zar6bar.Name = "zar6bar";
            zar6bar.Size = new Size(231, 23);
            zar6bar.Step = 1;
            zar6bar.TabIndex = 6;
            // 
            // zar3bar
            // 
            zar3bar.Location = new Point(447, 69);
            zar3bar.Name = "zar3bar";
            zar3bar.Size = new Size(231, 23);
            zar3bar.Step = 1;
            zar3bar.TabIndex = 6;
            // 
            // zar11bar
            // 
            zar11bar.Location = new Point(447, 364);
            zar11bar.Name = "zar11bar";
            zar11bar.Size = new Size(231, 23);
            zar11bar.Step = 1;
            zar11bar.TabIndex = 6;
            // 
            // zar8bar
            // 
            zar8bar.Location = new Point(447, 247);
            zar8bar.Name = "zar8bar";
            zar8bar.Size = new Size(231, 23);
            zar8bar.Step = 1;
            zar8bar.TabIndex = 6;
            // 
            // zar5bar
            // 
            zar5bar.Location = new Point(447, 138);
            zar5bar.Name = "zar5bar";
            zar5bar.Size = new Size(231, 23);
            zar5bar.Step = 1;
            zar5bar.TabIndex = 6;
            // 
            // zar2bar
            // 
            zar2bar.Location = new Point(447, 37);
            zar2bar.Name = "zar2bar";
            zar2bar.Size = new Size(231, 23);
            zar2bar.Step = 1;
            zar2bar.TabIndex = 6;
            // 
            // zar7_lbl
            // 
            zar7_lbl.AutoSize = true;
            zar7_lbl.Location = new Point(17, 210);
            zar7_lbl.Margin = new Padding(2, 0, 2, 0);
            zar7_lbl.Name = "zar7_lbl";
            zar7_lbl.Size = new Size(209, 21);
            zar7_lbl.TabIndex = 0;
            zar7_lbl.Text = "Toplam 7 Gelen Zar Sayisi:";
            // 
            // zar10_lbl
            // 
            zar10_lbl.AutoSize = true;
            zar10_lbl.Location = new Point(17, 324);
            zar10_lbl.Margin = new Padding(2, 0, 2, 0);
            zar10_lbl.Name = "zar10_lbl";
            zar10_lbl.Size = new Size(218, 21);
            zar10_lbl.TabIndex = 0;
            zar10_lbl.Text = "Toplam 10 Gelen Zar Sayisi:";
            // 
            // zar4_lbl
            // 
            zar4_lbl.AutoSize = true;
            zar4_lbl.Location = new Point(17, 103);
            zar4_lbl.Margin = new Padding(2, 0, 2, 0);
            zar4_lbl.Name = "zar4_lbl";
            zar4_lbl.Size = new Size(209, 21);
            zar4_lbl.TabIndex = 0;
            zar4_lbl.Text = "Toplam 4 Gelen Zar Sayisi:";
            // 
            // zar12_lbl
            // 
            zar12_lbl.AutoSize = true;
            zar12_lbl.Location = new Point(17, 405);
            zar12_lbl.Margin = new Padding(2, 0, 2, 0);
            zar12_lbl.Name = "zar12_lbl";
            zar12_lbl.Size = new Size(218, 21);
            zar12_lbl.TabIndex = 0;
            zar12_lbl.Text = "Toplam 12 Gelen Zar Sayisi:";
            // 
            // zar6_lbl
            // 
            zar6_lbl.AutoSize = true;
            zar6_lbl.Location = new Point(17, 172);
            zar6_lbl.Margin = new Padding(2, 0, 2, 0);
            zar6_lbl.Name = "zar6_lbl";
            zar6_lbl.Size = new Size(209, 21);
            zar6_lbl.TabIndex = 0;
            zar6_lbl.Text = "Toplam 6 Gelen Zar Sayisi:";
            // 
            // zar9_lbl
            // 
            zar9_lbl.AutoSize = true;
            zar9_lbl.Location = new Point(17, 285);
            zar9_lbl.Margin = new Padding(2, 0, 2, 0);
            zar9_lbl.Name = "zar9_lbl";
            zar9_lbl.Size = new Size(209, 21);
            zar9_lbl.TabIndex = 0;
            zar9_lbl.Text = "Toplam 9 Gelen Zar Sayisi:";
            // 
            // zar3_lbl
            // 
            zar3_lbl.AutoSize = true;
            zar3_lbl.Location = new Point(17, 69);
            zar3_lbl.Margin = new Padding(2, 0, 2, 0);
            zar3_lbl.Name = "zar3_lbl";
            zar3_lbl.Size = new Size(209, 21);
            zar3_lbl.TabIndex = 0;
            zar3_lbl.Text = "Toplam 3 Gelen Zar Sayisi:";
            // 
            // zar11_lbl
            // 
            zar11_lbl.AutoSize = true;
            zar11_lbl.Location = new Point(17, 364);
            zar11_lbl.Name = "zar11_lbl";
            zar11_lbl.Size = new Size(218, 21);
            zar11_lbl.TabIndex = 0;
            zar11_lbl.Text = "Toplam 11 Gelen Zar Sayisi:";
            // 
            // zar5_lbl
            // 
            zar5_lbl.AutoSize = true;
            zar5_lbl.Location = new Point(17, 138);
            zar5_lbl.Name = "zar5_lbl";
            zar5_lbl.Size = new Size(209, 21);
            zar5_lbl.TabIndex = 0;
            zar5_lbl.Text = "Toplam 5 Gelen Zar Sayisi:";
            // 
            // zar8_lbl
            // 
            zar8_lbl.AutoSize = true;
            zar8_lbl.Location = new Point(17, 247);
            zar8_lbl.Name = "zar8_lbl";
            zar8_lbl.Size = new Size(209, 21);
            zar8_lbl.TabIndex = 0;
            zar8_lbl.Text = "Toplam 8 Gelen Zar Sayisi:";
            // 
            // zar2_lbl
            // 
            zar2_lbl.AutoSize = true;
            zar2_lbl.Location = new Point(17, 37);
            zar2_lbl.Name = "zar2_lbl";
            zar2_lbl.Size = new Size(209, 21);
            zar2_lbl.TabIndex = 0;
            zar2_lbl.Text = "Toplam 2 Gelen Zar Sayisi:";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // ayar_btn
            // 
            ayar_btn.BackColor = Color.White;
            ayar_btn.FlatStyle = FlatStyle.Flat;
            ayar_btn.Location = new Point(938, 600);
            ayar_btn.Name = "ayar_btn";
            ayar_btn.Size = new Size(112, 26);
            ayar_btn.TabIndex = 4;
            ayar_btn.Text = "Ayarlar";
            ayar_btn.UseVisualStyleBackColor = false;
            ayar_btn.Click += ayar_btn_Click;
            ayar_btn.MouseLeave += ayar_btn_MouseLeave;
            ayar_btn.MouseHover += ayar_btn_MouseHover;
            // 
            // ayar_pnl
            // 
            ayar_pnl.BackColor = Color.Gainsboro;
            ayar_pnl.Controls.Add(hiz_txtbox);
            ayar_pnl.Controls.Add(label3);
            ayar_pnl.Controls.Add(button2);
            ayar_pnl.Controls.Add(button1);
            ayar_pnl.Location = new Point(851, 458);
            ayar_pnl.Name = "ayar_pnl";
            ayar_pnl.Size = new Size(199, 136);
            ayar_pnl.TabIndex = 5;
            ayar_pnl.Visible = false;
            // 
            // hiz_txtbox
            // 
            hiz_txtbox.Location = new Point(19, 67);
            hiz_txtbox.Name = "hiz_txtbox";
            hiz_txtbox.Size = new Size(79, 23);
            hiz_txtbox.TabIndex = 1;
            hiz_txtbox.Text = "500";
            hiz_txtbox.TextChanged += hiz_txtbox_TextChanged;
            // 
            // label3
            // 
            label3.Location = new Point(19, 9);
            label3.Name = "label3";
            label3.Size = new Size(177, 55);
            label3.TabIndex = 0;
            label3.Text = "Ne kadar Hizli sonuc gelecegini ayarlayiniz\r\n suan:";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(104, 67);
            button2.Name = "button2";
            button2.Size = new Size(77, 23);
            button2.TabIndex = 4;
            button2.Text = "Ayarla";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(19, 96);
            button1.Name = "button1";
            button1.Size = new Size(162, 26);
            button1.TabIndex = 4;
            button1.Text = "Butun Bilgileri Sifirla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // analiz_listview
            // 
            analiz_listview.BackColor = Color.PowderBlue;
            analiz_listview.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            analiz_listview.Location = new Point(334, 462);
            analiz_listview.Name = "analiz_listview";
            analiz_listview.Size = new Size(713, 132);
            analiz_listview.TabIndex = 6;
            analiz_listview.UseCompatibleStateImageBehavior = false;
            analiz_listview.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "atilan zar sayisi";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "toplam2";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "toplam3";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "toplam4";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "toplam5";
            columnHeader9.Width = 70;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "toplam6";
            columnHeader10.Width = 70;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "toplam7";
            columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "toplam8";
            columnHeader12.Width = 70;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "toplam9";
            columnHeader13.Width = 70;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "toplam10";
            columnHeader14.Width = 70;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "toplam11";
            columnHeader15.Width = 70;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "toplam12";
            columnHeader16.Width = 70;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1062, 638);
            Controls.Add(ayar_pnl);
            Controls.Add(analiz_listview);
            Controls.Add(zarSonuc_pnl);
            Controls.Add(ayar_btn);
            Controls.Add(label1);
            Controls.Add(sonuc_lstview);
            Controls.Add(ZarAtma_pnl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Zar Deneyi Programi";
            Load += Form1_Load;
            Click += Form1_Click;
            ZarAtma_pnl.ResumeLayout(false);
            ZarAtma_pnl.PerformLayout();
            zarSonuc_pnl.ResumeLayout(false);
            zarSonuc_pnl.PerformLayout();
            ayar_pnl.ResumeLayout(false);
            ayar_pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ZarAtma_pnl;
        private ListView sonuc_lstview;
        private Label label1;
        private Button Basla_btn;
        private Label label2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox zarSonuc_pnl;
        private Label zar7_lbl;
        private Label zar10_lbl;
        private Label zar4_lbl;
        private Label zar12_lbl;
        private Label zar6_lbl;
        private Label zar9_lbl;
        private Label zar3_lbl;
        private Label zar11_lbl;
        private Label zar5_lbl;
        private Label zar8_lbl;
        private Label zar2_lbl;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Button ayar_btn;
        private Panel ayar_pnl;
        private TextBox hiz_txtbox;
        private Label label3;
        private Button button1;
        private Button button2;
        private ProgressBar zar10bar;
        private ProgressBar zar7bar;
        private ProgressBar zar4bar;
        private ProgressBar zar12bar;
        private ProgressBar zar9bar;
        private ProgressBar zar6bar;
        private ProgressBar zar3bar;
        private ProgressBar zar11bar;
        private ProgressBar zar8bar;
        private ProgressBar zar5bar;
        private ProgressBar zar2bar;
        private ListView analiz_listview;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
    }
}