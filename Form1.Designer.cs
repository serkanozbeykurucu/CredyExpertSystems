namespace CredyKnlowledgeSystems
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbxEvDurumu = new System.Windows.Forms.ComboBox();
            this.cbxCalismaDurumu = new System.Windows.Forms.ComboBox();
            this.cbxAmac = new System.Windows.Forms.ComboBox();
            this.btn_OneAsamaSubmit = new System.Windows.Forms.Button();
            this.tbxYas = new System.Windows.Forms.TextBox();
            this.tbxMaas = new System.Windows.Forms.TextBox();
            this.tbxSoyadi = new System.Windows.Forms.TextBox();
            this.tbxAdi = new System.Windows.Forms.TextBox();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblEvDurumu = new System.Windows.Forms.Label();
            this.lblCalismaDurumu = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblCreditAmac = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxKrediYogunlukDurumu = new System.Windows.Forms.ComboBox();
            this.cbxBirikim = new System.Windows.Forms.ComboBox();
            this.cbxKaraListe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDuzenliOdeme = new System.Windows.Forms.ComboBox();
            this.cbxKrediDurumu = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbxKefil = new System.Windows.Forms.ComboBox();
            this.CbxActiveKrediDurumu = new System.Windows.Forms.ComboBox();
            this.cbxBorcDurumu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxKrediKartı = new System.Windows.Forms.ComboBox();
            this.cbxSigorta = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1335, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgwCustomer);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1327, 635);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Customers";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Location = new System.Drawing.Point(12, 18);
            this.dgwCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.Size = new System.Drawing.Size(1315, 611);
            this.dgwCustomer.TabIndex = 0;
            this.dgwCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomer_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Wheat;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lblBaslik);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1327, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1.Aşama";
            // 
            // cbxEvDurumu
            // 
            this.cbxEvDurumu.BackColor = System.Drawing.Color.Wheat;
            this.cbxEvDurumu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEvDurumu.FormattingEnabled = true;
            this.cbxEvDurumu.Items.AddRange(new object[] {
            "Kira",
            "Mülk",
            "Hisseli"});
            this.cbxEvDurumu.Location = new System.Drawing.Point(316, 307);
            this.cbxEvDurumu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxEvDurumu.Name = "cbxEvDurumu";
            this.cbxEvDurumu.Size = new System.Drawing.Size(270, 30);
            this.cbxEvDurumu.TabIndex = 18;
            // 
            // cbxCalismaDurumu
            // 
            this.cbxCalismaDurumu.BackColor = System.Drawing.Color.Wheat;
            this.cbxCalismaDurumu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCalismaDurumu.FormattingEnabled = true;
            this.cbxCalismaDurumu.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbxCalismaDurumu.Location = new System.Drawing.Point(316, 259);
            this.cbxCalismaDurumu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCalismaDurumu.Name = "cbxCalismaDurumu";
            this.cbxCalismaDurumu.Size = new System.Drawing.Size(270, 30);
            this.cbxCalismaDurumu.TabIndex = 17;
            // 
            // cbxAmac
            // 
            this.cbxAmac.BackColor = System.Drawing.Color.Wheat;
            this.cbxAmac.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAmac.FormattingEnabled = true;
            this.cbxAmac.Items.AddRange(new object[] {
            "İhtiyaç Kredisi",
            "Tüketici Kredisi",
            "Ev Kredisi"});
            this.cbxAmac.Location = new System.Drawing.Point(316, 168);
            this.cbxAmac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxAmac.Name = "cbxAmac";
            this.cbxAmac.Size = new System.Drawing.Size(270, 30);
            this.cbxAmac.TabIndex = 16;
            // 
            // btn_OneAsamaSubmit
            // 
            this.btn_OneAsamaSubmit.BackColor = System.Drawing.Color.Wheat;
            this.btn_OneAsamaSubmit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OneAsamaSubmit.Location = new System.Drawing.Point(118, 418);
            this.btn_OneAsamaSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OneAsamaSubmit.Name = "btn_OneAsamaSubmit";
            this.btn_OneAsamaSubmit.Size = new System.Drawing.Size(302, 72);
            this.btn_OneAsamaSubmit.TabIndex = 15;
            this.btn_OneAsamaSubmit.Text = "Submit";
            this.btn_OneAsamaSubmit.UseVisualStyleBackColor = false;
            this.btn_OneAsamaSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxYas
            // 
            this.tbxYas.BackColor = System.Drawing.Color.Wheat;
            this.tbxYas.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxYas.Location = new System.Drawing.Point(316, 354);
            this.tbxYas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxYas.Name = "tbxYas";
            this.tbxYas.Size = new System.Drawing.Size(270, 30);
            this.tbxYas.TabIndex = 14;
            // 
            // tbxMaas
            // 
            this.tbxMaas.BackColor = System.Drawing.Color.Wheat;
            this.tbxMaas.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaas.Location = new System.Drawing.Point(316, 215);
            this.tbxMaas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMaas.Name = "tbxMaas";
            this.tbxMaas.Size = new System.Drawing.Size(270, 30);
            this.tbxMaas.TabIndex = 11;
            // 
            // tbxSoyadi
            // 
            this.tbxSoyadi.BackColor = System.Drawing.Color.Wheat;
            this.tbxSoyadi.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoyadi.Location = new System.Drawing.Point(316, 118);
            this.tbxSoyadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSoyadi.Name = "tbxSoyadi";
            this.tbxSoyadi.Size = new System.Drawing.Size(270, 30);
            this.tbxSoyadi.TabIndex = 9;
            // 
            // tbxAdi
            // 
            this.tbxAdi.BackColor = System.Drawing.Color.Wheat;
            this.tbxAdi.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAdi.Location = new System.Drawing.Point(316, 67);
            this.tbxAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxAdi.Name = "tbxAdi";
            this.tbxAdi.Size = new System.Drawing.Size(270, 30);
            this.tbxAdi.TabIndex = 8;
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYas.Location = new System.Drawing.Point(26, 352);
            this.lblYas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(68, 22);
            this.lblYas.TabIndex = 7;
            this.lblYas.Text = "Yasiniz";
            // 
            // lblEvDurumu
            // 
            this.lblEvDurumu.AutoSize = true;
            this.lblEvDurumu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvDurumu.Location = new System.Drawing.Point(26, 305);
            this.lblEvDurumu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvDurumu.Name = "lblEvDurumu";
            this.lblEvDurumu.Size = new System.Drawing.Size(99, 22);
            this.lblEvDurumu.TabIndex = 6;
            this.lblEvDurumu.Text = "Ev Durumu";
            // 
            // lblCalismaDurumu
            // 
            this.lblCalismaDurumu.AutoSize = true;
            this.lblCalismaDurumu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalismaDurumu.Location = new System.Drawing.Point(26, 262);
            this.lblCalismaDurumu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalismaDurumu.Name = "lblCalismaDurumu";
            this.lblCalismaDurumu.Size = new System.Drawing.Size(142, 22);
            this.lblCalismaDurumu.TabIndex = 5;
            this.lblCalismaDurumu.Text = "Calisma Durumu";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaas.Location = new System.Drawing.Point(26, 213);
            this.lblMaas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(53, 22);
            this.lblMaas.TabIndex = 4;
            this.lblMaas.Text = "Maaş";
            // 
            // lblCreditAmac
            // 
            this.lblCreditAmac.AutoSize = true;
            this.lblCreditAmac.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditAmac.Location = new System.Drawing.Point(26, 167);
            this.lblCreditAmac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditAmac.Name = "lblCreditAmac";
            this.lblCreditAmac.Size = new System.Drawing.Size(250, 22);
            this.lblCreditAmac.TabIndex = 3;
            this.lblCreditAmac.Text = "Kredi çekme Amacınız Nedir?";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(26, 117);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(99, 22);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "SoyAdınız:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(26, 66);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Adınız:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(507, 34);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(376, 62);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "CREDIT EXPERT SYSTEMS \r\n1.Aşama";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Wheat;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1327, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2.Aşama";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cbxKrediYogunlukDurumu
            // 
            this.cbxKrediYogunlukDurumu.BackColor = System.Drawing.Color.Wheat;
            this.cbxKrediYogunlukDurumu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKrediYogunlukDurumu.FormattingEnabled = true;
            this.cbxKrediYogunlukDurumu.Items.AddRange(new object[] {
            "0",
            "3",
            "6",
            "9"});
            this.cbxKrediYogunlukDurumu.Location = new System.Drawing.Point(334, 251);
            this.cbxKrediYogunlukDurumu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxKrediYogunlukDurumu.Name = "cbxKrediYogunlukDurumu";
            this.cbxKrediYogunlukDurumu.Size = new System.Drawing.Size(270, 30);
            this.cbxKrediYogunlukDurumu.TabIndex = 37;
            // 
            // cbxBirikim
            // 
            this.cbxBirikim.BackColor = System.Drawing.Color.Wheat;
            this.cbxBirikim.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBirikim.FormattingEnabled = true;
            this.cbxBirikim.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbxBirikim.Location = new System.Drawing.Point(334, 151);
            this.cbxBirikim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxBirikim.Name = "cbxBirikim";
            this.cbxBirikim.Size = new System.Drawing.Size(270, 30);
            this.cbxBirikim.TabIndex = 36;
            // 
            // cbxKaraListe
            // 
            this.cbxKaraListe.BackColor = System.Drawing.Color.Wheat;
            this.cbxKaraListe.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKaraListe.FormattingEnabled = true;
            this.cbxKaraListe.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbxKaraListe.Location = new System.Drawing.Point(334, 102);
            this.cbxKaraListe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxKaraListe.Name = "cbxKaraListe";
            this.cbxKaraListe.Size = new System.Drawing.Size(270, 30);
            this.cbxKaraListe.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(507, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 62);
            this.label8.TabIndex = 34;
            this.label8.Text = "CREDIT EXPERT SYSTEMS \r\n2.Aşama";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxDuzenliOdeme
            // 
            this.cbxDuzenliOdeme.BackColor = System.Drawing.Color.Wheat;
            this.cbxDuzenliOdeme.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDuzenliOdeme.FormattingEnabled = true;
            this.cbxDuzenliOdeme.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbxDuzenliOdeme.Location = new System.Drawing.Point(334, 295);
            this.cbxDuzenliOdeme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDuzenliOdeme.Name = "cbxDuzenliOdeme";
            this.cbxDuzenliOdeme.Size = new System.Drawing.Size(270, 30);
            this.cbxDuzenliOdeme.TabIndex = 32;
            // 
            // cbxKrediDurumu
            // 
            this.cbxKrediDurumu.BackColor = System.Drawing.Color.Wheat;
            this.cbxKrediDurumu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKrediDurumu.FormattingEnabled = true;
            this.cbxKrediDurumu.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbxKrediDurumu.Location = new System.Drawing.Point(334, 205);
            this.cbxKrediDurumu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxKrediDurumu.Name = "cbxKrediDurumu";
            this.cbxKrediDurumu.Size = new System.Drawing.Size(270, 30);
            this.cbxKrediDurumu.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Wheat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(164, 371);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 72);
            this.button2.TabIndex = 30;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Düzenli Ödene Durumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kredi Kullanım Yoğunlunuz?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hiç Kredi Kullandınız mı?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Birikiminiz Var mı?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kara Listeye Girdiniz mi?";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Wheat;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1327, 635);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3.Aşama";
            // 
            // cbxKefil
            // 
            this.cbxKefil.BackColor = System.Drawing.Color.Wheat;
            this.cbxKefil.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKefil.FormattingEnabled = true;
            this.cbxKefil.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbxKefil.Location = new System.Drawing.Point(334, 262);
            this.cbxKefil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxKefil.Name = "cbxKefil";
            this.cbxKefil.Size = new System.Drawing.Size(270, 30);
            this.cbxKefil.TabIndex = 49;
            // 
            // CbxActiveKrediDurumu
            // 
            this.CbxActiveKrediDurumu.BackColor = System.Drawing.Color.Wheat;
            this.CbxActiveKrediDurumu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxActiveKrediDurumu.FormattingEnabled = true;
            this.CbxActiveKrediDurumu.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.CbxActiveKrediDurumu.Location = new System.Drawing.Point(334, 161);
            this.CbxActiveKrediDurumu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxActiveKrediDurumu.Name = "CbxActiveKrediDurumu";
            this.CbxActiveKrediDurumu.Size = new System.Drawing.Size(270, 30);
            this.CbxActiveKrediDurumu.TabIndex = 48;
            // 
            // cbxBorcDurumu
            // 
            this.cbxBorcDurumu.BackColor = System.Drawing.Color.Wheat;
            this.cbxBorcDurumu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBorcDurumu.FormattingEnabled = true;
            this.cbxBorcDurumu.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbxBorcDurumu.Location = new System.Drawing.Point(334, 110);
            this.cbxBorcDurumu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxBorcDurumu.Name = "cbxBorcDurumu";
            this.cbxBorcDurumu.Size = new System.Drawing.Size(270, 30);
            this.cbxBorcDurumu.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 62);
            this.label1.TabIndex = 46;
            this.label1.Text = "CREDIT EXPERT SYSTEMS \r\n3.Aşama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxKrediKartı
            // 
            this.cbxKrediKartı.BackColor = System.Drawing.Color.Wheat;
            this.cbxKrediKartı.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKrediKartı.FormattingEnabled = true;
            this.cbxKrediKartı.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbxKrediKartı.Location = new System.Drawing.Point(334, 305);
            this.cbxKrediKartı.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxKrediKartı.Name = "cbxKrediKartı";
            this.cbxKrediKartı.Size = new System.Drawing.Size(270, 30);
            this.cbxKrediKartı.TabIndex = 45;
            // 
            // cbxSigorta
            // 
            this.cbxSigorta.BackColor = System.Drawing.Color.Wheat;
            this.cbxSigorta.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSigorta.FormattingEnabled = true;
            this.cbxSigorta.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbxSigorta.Location = new System.Drawing.Point(334, 215);
            this.cbxSigorta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSigorta.Name = "cbxSigorta";
            this.cbxSigorta.Size = new System.Drawing.Size(270, 30);
            this.cbxSigorta.TabIndex = 44;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Wheat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(165, 392);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(302, 72);
            this.button3.TabIndex = 43;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Kredi kartınız var mı?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 260);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "Kefiliniz var mı?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 213);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 22);
            this.label10.TabIndex = 40;
            this.label10.Text = "Sigortanız Var mı?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 22);
            this.label11.TabIndex = 39;
            this.label11.Text = "Aktif Kredi Durumu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 110);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 22);
            this.label12.TabIndex = 38;
            this.label12.Text = "Borç Durumu";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Wheat;
            this.tabPage4.CausesValidation = false;
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1327, 635);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sonuç";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(180, 153);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 21);
            this.label14.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(64, 153);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Soınuc: ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(380, 50);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(345, 31);
            this.label15.TabIndex = 2;
            this.label15.Text = "CREDIT EXPERT SYSTEMS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.cbxEvDurumu);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Controls.Add(this.cbxCalismaDurumu);
            this.panel1.Controls.Add(this.lblCreditAmac);
            this.panel1.Controls.Add(this.cbxAmac);
            this.panel1.Controls.Add(this.lblMaas);
            this.panel1.Controls.Add(this.btn_OneAsamaSubmit);
            this.panel1.Controls.Add(this.lblCalismaDurumu);
            this.panel1.Controls.Add(this.tbxYas);
            this.panel1.Controls.Add(this.lblEvDurumu);
            this.panel1.Controls.Add(this.tbxMaas);
            this.panel1.Controls.Add(this.lblYas);
            this.panel1.Controls.Add(this.tbxSoyadi);
            this.panel1.Controls.Add(this.tbxAdi);
            this.panel1.Location = new System.Drawing.Point(358, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 505);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbxKrediYogunlukDurumu);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbxBirikim);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbxKaraListe);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbxDuzenliOdeme);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cbxKrediDurumu);
            this.panel2.Location = new System.Drawing.Point(358, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 489);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cbxKefil);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.CbxActiveKrediDurumu);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cbxBorcDurumu);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbxKrediKartı);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.cbxSigorta);
            this.panel3.Location = new System.Drawing.Point(358, 117);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 515);
            this.panel3.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(294, 123);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(606, 469);
            this.panel4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 674);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREDIT EXPERT SYSTEMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbxAmac;
        private System.Windows.Forms.Button btn_OneAsamaSubmit;
        private System.Windows.Forms.TextBox tbxYas;
        private System.Windows.Forms.TextBox tbxMaas;
        private System.Windows.Forms.TextBox tbxSoyadi;
        private System.Windows.Forms.TextBox tbxAdi;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblEvDurumu;
        private System.Windows.Forms.Label lblCalismaDurumu;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblCreditAmac;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbxEvDurumu;
        private System.Windows.Forms.ComboBox cbxCalismaDurumu;
        private System.Windows.Forms.ComboBox cbxDuzenliOdeme;
        private System.Windows.Forms.ComboBox cbxKrediDurumu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxKrediYogunlukDurumu;
        private System.Windows.Forms.ComboBox cbxBirikim;
        private System.Windows.Forms.ComboBox cbxKaraListe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cbxKefil;
        private System.Windows.Forms.ComboBox CbxActiveKrediDurumu;
        private System.Windows.Forms.ComboBox cbxBorcDurumu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxKrediKartı;
        private System.Windows.Forms.ComboBox cbxSigorta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgwCustomer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

