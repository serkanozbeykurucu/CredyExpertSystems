using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CredyKnlowledgeSystems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class OneAsama
        {
            public int amacdeger1, maas1, cdurum1, evdurum, age;

            public int Amac(string amac)
            {
                /*
                    İhtiyaç Kredisi
                    Tüketici Kredisi
                    Ev Kredisi
                */
                if (amac == "İhtiyaç Kredisi") // öncelik puanı 2
                {
                    amacdeger1 = 2;
                }
                else if (amac == "Tüketici Kredisi") // öncelik puanı 3
                {
                    amacdeger1 = 3;
                }
                else if (amac == "Ev Kredisi") // öncelik puanı 5
                {
                    amacdeger1 = 5;
                }

                int sonuc = amacdeger1;
                return sonuc;
            }
            public int Maas(int maas)
            {
                if (maas == 0 && maas < 3000) // öncelik puanı 2
                {
                    maas1 = 2;
                }
                else if (maas >= 3000 && maas < 6000) // öncelik puanı 3
                {
                    maas1 = 3;
                }
                else if (maas >= 6000) // öncelik puanı 5
                {
                    maas1 = 5;
                }
                int sonuc = maas1;
                return sonuc;
            }
            public int CalismaDurumu(string cdurum)
            {
                /*
                    Evet
                    Hayır
                */
                if (cdurum == "Evet") // öncelik puanı 5
                {
                    cdurum1 = 5;
                }
                else if (cdurum == "Hayır") // öncelik puanı 2
                {
                    cdurum1 = 2;
                }
                int sonuc = cdurum1;
                return sonuc;
            }
            public int EvDurumu(string homedurum)
            {
                /*
                    Kira
                    Mülk
                    Hisseli
                */
                if (homedurum == "Kira") // öncelik puanı 2
                {
                    evdurum = 2;
                }
                else if (homedurum == "Mülk") // öncelik puanı 5
                {
                    evdurum = 5;
                }
                else if (homedurum == "Hisseli") // öncelik puanı 3
                {
                    evdurum = 3;
                }
                int sonuc = evdurum;
                return sonuc;
            }

            public int YasDurumu(int yas)
            {
                if (yas < 18)
                {
                    age = 0;
                }
                else if (yas >= 18 && yas < 30)
                {
                    age = 3;
                }
                else if (yas >= 30 && yas < 65)
                {
                    age = 5;

                }
                else if (yas > 65)
                {
                    age = 0;
                }
                int sonuc = age;
                return sonuc;
            }

            public int sonuc()
            {

                return amacdeger1 + maas1 + cdurum1 + evdurum + age;
            }
        }
        class TwoAsama
        {
            public int blacklist, birikim1, cdurum1, cydurum, dodurumu1;

            public int KaraListe(string karaliste)
            {
                /*
                    Evet 
                    Hayır
                */

                if (karaliste == "Evet") // öncelik puanı 0
                {
                    blacklist = 0;
                }
                else if (karaliste == "Hayır") // öncelik puanı 5
                {
                    blacklist = 5;
                }
                int sonuc = blacklist;
                return sonuc;
            }
            public int Birikim(string birikim)
            {
                /*
                    Evet 
                    Hayır
                */

                if (birikim == "Evet") // öncelik puanı 5
                {
                    birikim1 = 5;
                }
                else if (birikim == "Hayır") // öncelik puanı 0
                {
                    birikim1 = 0;
                }
                int sonuc = birikim1;
                return sonuc;
            }


            public int KrediDurumu(string cdurum)
            {
                /*
                    Evet
                    Hayır
                */
                if (cdurum == "Evet") // öncelik puanı 3
                {
                    cdurum1 = 3;
                }
                if (cdurum == "Hayır") // öncelik puanı 5
                {
                    cdurum1 = 5;
                }
                int sonuc = cdurum1;
                return sonuc;
            }


            public int KrediYogunlukDurumu(string kdurum)
            {
                /*
                    0
                    3
                    6
                    9
                */
                if (kdurum == "0") // öncelik puanı 5
                {
                    cydurum = 5;
                }
                if (kdurum == "3") // öncelik puanı 4
                {
                    cydurum = 4;
                }
                if (kdurum == "6") // öncelik puanı 3
                {
                    cydurum = 3;
                }
                if (kdurum == "9") // öncelik puanı 2
                {
                    cydurum = 2;
                }
                int sonuc = cydurum;
                return sonuc;
            }




            public int DuzenliOdemeDurumu(string dodurumu)
            {
                /*
                    Evet
                    Hayır
                */
                if (dodurumu == "Evet") // öncelik puanı 5
                {
                    dodurumu1 = 5;
                }
                if (dodurumu == "Hayır") // öncelik puanı 2
                {
                    dodurumu1 = 2;
                }
                int sonuc = dodurumu1;
                return sonuc;
            }

            public int sonuc()
            {

                return blacklist + birikim1 + cdurum1 + cydurum + dodurumu1;
            }
        }
        class ThreeAsama
        {
            public int bdurum, activekredidurumu, sdurumu, kefil, kredikarti;

            public int BorcDurumu(string borcdurumu)
            {
                /*
                    Evet 
                    Hayır
                */

                if (borcdurumu == "Evet") // öncelik puanı 2
                {
                    bdurum = 2;
                }
                else if (borcdurumu == "Hayır") // öncelik puanı 5
                {
                    bdurum = 5;
                }
                int sonuc = bdurum;
                return sonuc;
            }
            public int ActiveKrediDurumu(string akredumu)
            {
                /*
                    Evet 
                    Hayır
                */

                if (akredumu == "Evet") // öncelik puanı 2
                {
                    activekredidurumu = 2;
                }
                else if (akredumu == "Hayır") // öncelik puanı 5
                {
                    activekredidurumu = 5;
                }
                int sonuc = activekredidurumu;
                return sonuc;
            }


            public int SigortaDurumu(string sigortadurumu)
            {
                /*
                    Evet
                    Hayır
                */
                if (sigortadurumu == "Evet") // öncelik puanı 5
                {
                    sdurumu = 5;
                }
                if (sigortadurumu == "Hayır") // öncelik puanı 2
                {
                    sdurumu = 2;
                }
                int sonuc = sdurumu;
                return sonuc;
            }
            public int KefilDurumu(string kdurum)
            {
                /*
                    Evet
                    Hayır
                */
                if (kdurum == "Evet") // öncelik puanı 5
                {
                    kefil = 5;
                }
                if (kdurum == "Hayır") // öncelik puanı 2
                {
                    kefil = 2;
                }
                int sonuc = kefil;
                return sonuc;
            }

            public int KrediKartiDurumu(string kredikdurum)
            {
                /*
                    Evet
                    Hayır
                */
                if (kredikdurum == "Evet") // öncelik puanı 3
                {
                    kredikarti = 3;
                }
                if (kredikdurum == "Hayır") // öncelik puanı 5
                {
                    kredikarti = 5;
                }
                int sonuc = kredikarti;
                return sonuc;
            }

            public int sonuc()
            {

                return bdurum + activekredidurumu + sdurumu + kefil + kredikarti;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OneAsama oneAsama = new OneAsama();
            int amacdeger = oneAsama.Amac(cbxAmac.Text);
            int maas = oneAsama.Maas(Convert.ToInt32(tbxMaas.Text));
            int cdurum = oneAsama.CalismaDurumu(cbxCalismaDurumu.Text);
            int age = oneAsama.YasDurumu(Convert.ToInt32(tbxYas.Text));
            int evdurumu = oneAsama.EvDurumu(cbxEvDurumu.Text);
            if (oneAsama.sonuc() > 12)
            {
                //label14.Text = oneAsama.sonuc().ToString() + "  Kredi Puanı, kredi çekmeniz için uygundur.";
                tabPage2.Show();
                tabPage1.Hide();
            }
            else
            {
                tabPage4.Show(); tabPage1.Hide();
                label14.Text = "KREDİ ÇEKMEK İÇİN UYGUN DEĞİLSİNİZ " + oneAsama.sonuc().ToString();
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=BasicCreditExpertSystem;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Customers", con);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            while (sqlDataReader.Read())
            {
                Customer customer = new Customer()
                {
                    ID = Convert.ToInt32(sqlDataReader["ID"]),
                    Name = sqlDataReader["NAME_"].ToString(),
                    Surname = sqlDataReader["SURNAME_"].ToString(),
                    KREDİCEKMEAMACI = sqlDataReader["KREDİCEKMEAMACI"].ToString(),
                    MAAS = Convert.ToDouble(sqlDataReader["MAAS"]),
                    CALISMADURUMU = sqlDataReader["CALISMADURUMU"].ToString(),
                    EVDURUMU = sqlDataReader["EVDURUMU"].ToString(),
                    YASINIZ = Convert.ToInt32(sqlDataReader["YASINIZ"]),
                    KARALISTEDURUMU = sqlDataReader["KARALISTEDURUMU"].ToString(),
                    BIRIKIMINIZ = sqlDataReader["BIRIKIMINIZ"].ToString(),
                    KREDIKULLANIMI = sqlDataReader["KREDIKULLANIMI"].ToString(),
                    KREDIYOGUNLUK = Convert.ToInt32(sqlDataReader["KREDIYOGUNLUK"]),
                    DUZENLIODEME = sqlDataReader["DUZENLIODEME"].ToString(),
                    BORCDURUMU = sqlDataReader["BORCDURUMU"].ToString(),
                    ACTIVEKREDI = sqlDataReader["ACTIVEKREDI"].ToString(),
                    SIGORTADURUMU = sqlDataReader["SIGORTADURUMU"].ToString(),
                    KEFIL = sqlDataReader["KEFIL"].ToString(),
                    KREDIKARTIBILGISI = sqlDataReader["KREDIKARTIBILGISI"].ToString()

                };
                customers.Add(customer);
            }
            sqlDataReader.Close();
            con.Close();
            dgwCustomer.DataSource = customers;
            dgwCustomer.Columns[0].HeaderText = "Sıra No";
            dgwCustomer.Columns[1].HeaderText = "İsim";
            dgwCustomer.Columns[2].HeaderText = "Soyİsim";
            dgwCustomer.Columns[3].HeaderText = "Kredi Çekme Amacınız";
            dgwCustomer.Columns[4].HeaderText = "Maaşınız";
            dgwCustomer.Columns[5].HeaderText = "Çalışma Durumunuz";
            dgwCustomer.Columns[6].HeaderText = "Ev Durumunuz";
            dgwCustomer.Columns[7].HeaderText = "Yaşınız";
            dgwCustomer.Columns[8].HeaderText = "Kara Liste Durumunuz";
            dgwCustomer.Columns[9].HeaderText = "Birikim Durumunuz";
            dgwCustomer.Columns[10].HeaderText = "Kredi Kullanım Durumunuz";
            dgwCustomer.Columns[11].HeaderText = "Kredi Yoğunluk Durumunuz";
            dgwCustomer.Columns[12].HeaderText = "Düzenli Ödeme Durumunuz";
            dgwCustomer.Columns[13].HeaderText = "Borç Durumunuz";
            dgwCustomer.Columns[14].HeaderText = "Aktif Kredi Durumunuz";
            dgwCustomer.Columns[15].HeaderText = "Sigorta Durumunuz";
            dgwCustomer.Columns[16].HeaderText = "Kefil Durumunuz";
            dgwCustomer.Columns[17].HeaderText = "Kredi Kartı Kullanım Durumunuz";
            //dgwCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;




        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TwoAsama twoAsama = new TwoAsama();
            int blacklist, birikim1, cdurum1, cydurum, dodurumu1;
            blacklist = twoAsama.KaraListe(cbxKaraListe.Text);
            birikim1 = twoAsama.Birikim(cbxBirikim.Text);
            cdurum1 = twoAsama.KrediDurumu(cbxKrediDurumu.Text);
            cydurum = twoAsama.KrediYogunlukDurumu(cbxKrediYogunlukDurumu.Text);
            dodurumu1 = twoAsama.DuzenliOdemeDurumu(cbxDuzenliOdeme.Text);

            if (twoAsama.sonuc() >= 15)
            {
                //label14.Text = oneAsama.sonuc().ToString() + "  Kredi Puanı, kredi çekmeniz için uygundur.";
                tabPage3.Show();
                tabPage2.Hide();
            }
            else
            {
                tabPage4.Show(); tabPage2.Hide();
                label14.Text = "KREDİ ÇEKMEK İÇİN UYGUN DEĞİLSİNİZ";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThreeAsama threeAsama = new ThreeAsama();
            TwoAsama twoAsama = new TwoAsama();
            OneAsama oneAsama1 = new OneAsama();
            int bdurum, activekredidurumu, sdurumu, kefil, kredikarti;
            bdurum = threeAsama.BorcDurumu(cbxBorcDurumu.Text);
            activekredidurumu = threeAsama.ActiveKrediDurumu(CbxActiveKrediDurumu.Text);
            sdurumu = threeAsama.SigortaDurumu(cbxSigorta.Text);
            kefil = threeAsama.KefilDurumu(cbxKefil.Text);
            kredikarti = threeAsama.KrediKartiDurumu(cbxKrediKartı.Text);

            if (threeAsama.sonuc() > 16)
            {
                label14.Text = threeAsama.sonuc().ToString() + twoAsama.sonuc().ToString() + oneAsama1.sonuc().ToString() + "  Kredi Puanı, kredi çekmeniz için uygundur.";
                tabPage4.Show();
                tabPage3.Hide();
            }
            else
            {
                tabPage4.Show(); tabPage3.Hide();
                label14.Text = "KREDİ ÇEKMEK İÇİN UYGUN DEĞİLSİNİZ";

            }


        }

        private void dgwCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1.asama

            tbxAdi.Text = dgwCustomer.CurrentRow.Cells[1].Value.ToString();
            tbxSoyadi.Text = dgwCustomer.CurrentRow.Cells[2].Value.ToString();
            cbxAmac.Text = dgwCustomer.CurrentRow.Cells[3].Value.ToString();
            tbxMaas.Text = dgwCustomer.CurrentRow.Cells[4].Value.ToString();
            cbxCalismaDurumu.Text = dgwCustomer.CurrentRow.Cells[5].Value.ToString();
            cbxEvDurumu.Text = dgwCustomer.CurrentRow.Cells[6].Value.ToString();
            tbxYas.Text = dgwCustomer.CurrentRow.Cells[7].Value.ToString();

            //2.asama

            cbxKaraListe.Text = dgwCustomer.CurrentRow.Cells[8].Value.ToString();
            cbxBirikim.Text = dgwCustomer.CurrentRow.Cells[9].Value.ToString();
            cbxKrediDurumu.Text = dgwCustomer.CurrentRow.Cells[10].Value.ToString();
            cbxKrediYogunlukDurumu.Text = dgwCustomer.CurrentRow.Cells[11].Value.ToString();
            cbxDuzenliOdeme.Text = dgwCustomer.CurrentRow.Cells[12].Value.ToString();

            //3.asama
            cbxBorcDurumu.Text = dgwCustomer.CurrentRow.Cells[13].Value.ToString();
            CbxActiveKrediDurumu.Text = dgwCustomer.CurrentRow.Cells[14].Value.ToString();
            cbxSigorta.Text = dgwCustomer.CurrentRow.Cells[15].Value.ToString();
            cbxKefil.Text = dgwCustomer.CurrentRow.Cells[16].Value.ToString();
            cbxKrediKartı.Text = dgwCustomer.CurrentRow.Cells[17].Value.ToString();

        }
    }
}