using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
       
        MusteriTemsilcisi mtemsilci1 = new MusteriTemsilcisi();
        MusteriTemsilcisi mtemsilci2 = new MusteriTemsilcisi();
        MusteriTemsilcisi mtemsilci3 = new MusteriTemsilcisi();
        MusteriTemsilcisi mtemsilci4 = new MusteriTemsilcisi();


        CagriLList cliste = new CagriLList();

        CvpCagriLList T1AtananListe = new CvpCagriLList();
        CvpCagriLList T2AtananListe = new CvpCagriLList();
        CvpCagriLList T3AtananListe = new CvpCagriLList();
        CvpCagriLList T4AtananListe = new CvpCagriLList();

        InsertionSort InsertionSort = new InsertionSort();
        string cevaplananCagriId = "";






        public Form1()
        {
            InitializeComponent();

           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CagriMerkezi cagriMerkezi = new CagriMerkezi(mtemsilci1, mtemsilci2, mtemsilci3, mtemsilci4, "İzbü Çağrı Merkezi");



            grpBoxT1.Visible = false;
            grpBoxT2.Visible = false;
            grpBoxT3.Visible = false;
            grpBoxT4.Visible = false;

            //Hazır birkaç arama oluşturulur.(örnek verilerin eklenmesi.)
            cliste.Ekle("bireysel");
            cliste.Ekle("bireysel");
            cliste.Ekle("bireysel");
            cliste.Ekle("Ticari");

            mtemsilci1.tur = "Bireysel";
            mtemsilci1.durum = "Müsait";
            lbldurum1.Text = mtemsilci1.durum;

            mtemsilci2.tur = "Bireysel";
            mtemsilci2.durum = "Müsait";
            lbldurum2.Text = mtemsilci2.durum;

            mtemsilci3.tur = "Ticari";
            mtemsilci3.durum = "Müsait";
            lbldurum3.Text = mtemsilci3.durum;

            mtemsilci4.tur = "Ticari";
            mtemsilci4.durum = "Müsait";
            lbldurum4.Text = mtemsilci4.durum;

            timer1.Start();
            timer1.Interval = 100000;

            lblCagriSıra.Visible = false;
            MessageBox.Show("Lütfen form açıldığında tam ekrana geçiniz.");


        }

        string secim;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            secim = "1";

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            secim = "2";

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            secim = "3";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            secim = "4";

        }

        private void btn1Bitir_Click(object sender, EventArgs e)
        {
            lbldurum1.Text = "Müsait";
            checkBox1.Checked = false;


            lblBitis1.Text = DateTime.Now.ToLongTimeString();
            cevaplananCagriId = txtMusteriId1.Text;

            //1.Müşteri temsilcisine ait liste oluşturulur.
            T1AtananListe.GorusmeBilgisiGiris(lblTid1.Text, txtMusteriId1.Text, lblBaslangic1.Text, lblBitis1.Text, txtNotlar1.Text, cevaplananCagriId);
            grpBoxT1.Visible = false;


        }

        private void btn2Biter_Click(object sender, EventArgs e)
        {
            lbldurum2.Text = "Müsait";
            checkBox4.Checked = false;


            lblBitis2.Text = DateTime.Now.ToLongTimeString();
            cevaplananCagriId = txtMusteriId2.Text;

            //2.Müşteri temsilcisine ait liste oluşturulur.
            T2AtananListe.GorusmeBilgisiGiris(lblMTid2.Text, txtMusteriId2.Text, lblBaslangic2.Text, lblBitis2.Text, txtNotlar2.Text, cevaplananCagriId);
            grpBoxT2.Visible = false;

        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            string tur = cmbTur.Text;
            cliste.Ekle(tur);
            cmbTur.Text = "";

        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            //Girdi alanlarını temizler.
            txtNotlar1.Text = "";
            txtMusteriId1.Text = "";
            lblBitis1.Text = "";
            //Girdi alanlarını temizler.
            txtNotlar2.Text = "";
            txtMusteriId2.Text = "";
            lblBitis2.Text = "";
            //Girdi alanlarını temizler.
            txtNotlar3.Text = "";
            txtMusteriId3.Text = "";
            lblBitis3.Text = "";
            //Girdi alanlarını temizler.
            txtNotlar4.Text = "";
            txtMusteriId4.Text = "";
            lblBitis4.Text = "";

            if (cliste.head == null)
            {
                MessageBox.Show("Listede bekleyen çağrı yok");
            }
            else
            {
                cliste.CagriAta();
                label10.Visible = false;
                if (secim == "1")
                {

                    lbldurum1.Text = "Meşgul";
                    grpBoxT1.Visible = true;
                    lblBaslangic1.Text = DateTime.Now.ToLongTimeString();

                }
                if (secim == "2")
                {
                    lbldurum2.Text = "Meşgul";
                    grpBoxT2.Visible = true;
                    lblBaslangic2.Text = DateTime.Now.ToLongTimeString();
                }
                if (secim == "3")
                {
                    lbldurum3.Text = "Meşgul";
                    grpBoxT3.Visible = true;
                    lblBaslangic3.Text = DateTime.Now.ToLongTimeString();

                }
                if (secim == "4")
                {
                    lbldurum4.Text = "Meşgul";
                    grpBoxT4.Visible = true;
                    lblBaslangic4.Text = DateTime.Now.ToLongTimeString();
                }

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }
        
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            
            label10.Text="Çağrı id "+"Müşteri Türü "+"Çağrı Sırası "+"\n"+
                          cliste.ListeyiYazdır();
          label10.Visible = true;
            
        }

  

        private void btn3Bitir_Click(object sender, EventArgs e)
        {
            lbldurum3.Text = "Müsait";
            checkBox3.Checked = false;

            lblBitis3.Text = DateTime.Now.ToLongTimeString();
            cevaplananCagriId = txtMusteriId3.Text;

            //3.Müşteri temsilcisine ait liste oluşturulur.
            T3AtananListe.GorusmeBilgisiGiris(lblMT3.Text, txtMusteriId3.Text, lblBaslangic3.Text, lblBitis3.Text, txtNotlar3.Text,cevaplananCagriId);
            grpBoxT3.Visible = false;

           
        }

        private void btn4Bitir_Click(object sender, EventArgs e)
        {
            lbldurum4.Text = "Müsait";
            checkBox2.Checked = false;

            lblBitis4.Text = DateTime.Now.ToLongTimeString();
            cevaplananCagriId = txtMusteriId4.Text;

            //4.Müşteri temsilcisine ait liste oluşturulur.
            T4AtananListe.GorusmeBilgisiGiris(lblMT4.Text, txtMusteriId4.Text, lblBaslangic4.Text, lblBitis4.Text, txtNotlar4.Text,cevaplananCagriId);
            grpBoxT4.Visible = false;

            
        }
       
        //id numarasına göre çağrı atama işlemi.
        private void btnAradanAta_Click(object sender, EventArgs e)
        {
            //Girdi alanlarını temizler.
            txtNotlar1.Text = "";
            txtMusteriId1.Text = "";
            lblBitis1.Text = "";
            //Girdi alanlarını temizler.
            txtNotlar2.Text = "";
            txtMusteriId2.Text = "";
            lblBitis2.Text = "";
            //Girdi alanlarını temizler.
            txtNotlar3.Text = "";
            txtMusteriId3.Text = "";
            lblBitis3.Text = "";
            //Girdi alanlarını temizler.
            txtNotlar4.Text = "";
            txtMusteriId4.Text = "";
            lblBitis4.Text = "";

            
            string a = cliste.IdNoCagriAta(Convert.ToInt32(tXtIdNo.Text));
          
            MessageBox.Show(a);
          
            label10.Visible = false;
            tXtIdNo.Text = "";

            if (secim == "1")
            {
                if (a== "Girdiğiniz id numaralı çağrı başarı biçimde atandı.")
                {
                    lbldurum1.Text = "Meşgul";
                    grpBoxT1.Visible = true;
                    lblBaslangic1.Text = DateTime.Now.ToLongTimeString();
                }
                 checkBox1.Checked = false;   
            }
            if (secim == "2")
            {
                
               
                if (a== "Girdiğiniz id numaralı çağrı başarı biçimde atandı.")
                {
                    lbldurum2.Text = "Meşgul";
                    grpBoxT2.Visible = true;
                    lblBaslangic2.Text = DateTime.Now.ToLongTimeString();
                }
                else checkBox4.Checked = false;
    
            }
            if (secim == "3")
            {
               
                if (a== "Girdiğiniz id numaralı çağrı başarı biçimde atandı.")
                {
                    lbldurum3.Text = "Meşgul";
                    grpBoxT3.Visible = true;
                    lblBaslangic3.Text = DateTime.Now.ToLongTimeString();
                }
              
                else checkBox3.Checked = false;

            }
            if (secim == "4")
            {
              
                
                if (a== "Girdiğiniz id numaralı çağrı başarı biçimde atandı.")
                {
                    lbldurum4.Text = "Meşgul";
                    grpBoxT4.Visible = true;
                    lblBaslangic4.Text = DateTime.Now.ToLongTimeString();
                }
                
               else checkBox2.Checked = false;

            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

        }
        
        public NotlardaArama kelimeBulma { get; set; } = new NotlardaArama();
        string yanıt;
        private void btnKelimeAra_Click(object sender, EventArgs e)
        {
          
           //müşteritemsilcilerine ait listeler kelimeyi bulmak için aranan kelimeyle birlikte fonksiyona gönderilirler.
           yanıt  = kelimeBulma.ArananKelimeyiBul(T1AtananListe,txtBoxKelime.Text);
           yanıt += kelimeBulma.ArananKelimeyiBul(T2AtananListe, txtBoxKelime.Text);
           yanıt += kelimeBulma.ArananKelimeyiBul(T3AtananListe, txtBoxKelime.Text);
           yanıt += kelimeBulma.ArananKelimeyiBul(T4AtananListe, txtBoxKelime.Text);

            MessageBox.Show(yanıt);
            txtBoxKelime.Text = "";
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCagriSıra.Visible = true;
            lblCagriSıra.Text = label10.Text;
            timer2.Start();
            timer2.Interval = 10000;
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblCagriSıra.Visible = false;
            timer1.Start();
        }


        private void btnRapor1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            T1AtananListe.GorusmeSayisi= T1AtananListe.getCount(T1AtananListe);
            T1AtananListe.temsilciId = "(1)-Bireysel   ";

            T2AtananListe.GorusmeSayisi= T2AtananListe.getCount(T2AtananListe);
            T2AtananListe.temsilciId = "(2)-Bireysel   ";

            T3AtananListe.GorusmeSayisi=T3AtananListe.getCount(T3AtananListe);
            T3AtananListe.temsilciId = "(3)-Ticari      ";

            T4AtananListe.GorusmeSayisi = T4AtananListe.getCount(T4AtananListe);
            T4AtananListe.temsilciId = "(4)-Ticari      ";


            //btnRapor1 butonuna tıklandıktan sonra LinkedList'teki düğümler diziye aktarılır(Üzerinde sıralama algoritması kullanılacak).          

            CvpCagriLList[] cvp = { T1AtananListe, T2AtananListe, T3AtananListe, T4AtananListe };

            //Oluşturduğumuz InsertionSort sınıfındaki sort() metodu çağrılır. Dizi içine aktarılır.
            //Günlük bazda yapılan görüşme sayısına göre müşteri temsilcilerinin sıralanması sağlanır(SIRALAMA ALGORİTMASI KULLANILIR).

            InsertionSort.Sort(cvp);
        
            //Sıralanmış listeyi listbox'a yazdırmak için kullanılacak fonksiyon.

             string printt(CvpCagriLList[] arr)
            {
                string b1 = "En az görüşme yapan müşteri temsilcisinden";
                string b2 = "En çok görüşme yapan müşteri temsilcisine doğru";
                string b3 = "sıralama yapılmıştır.";

                string b4 = "\n";

                listBox1.Items.Add(b1);
                listBox1.Items.Add(b2);
                listBox1.Items.Add(b3);
                listBox1.Items.Add(b4);


                string a = "";
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                {
                    a = "Görüşen Temsilci id: " + arr[i].temsilciId + "Görüşme Sayısı: " + arr[i].GorusmeSayisi + " \n";
                    listBox1.Items.Add(a);
                }
                return "";
            }

            //Tanımladığımız fonksiyonu sıralanmış biçimde list box'a yazdırmak için çağırıyoruz.
              printt(InsertionSort.Sort(cvp));

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //ListBox'a yapılan çağrılar üzerindeki işlemleri gösterecek.


            string t = " Müşteri id" + " Cevaplayan Müşteri Temsilcisi  " + "başlama Zamanı  " + " Bitiş zamanı  " + " NOTU";
            string b = "\n";

            listBox1.Items.Add(t);
            listBox1.Items.Add(b);

            //Çağrılardan oluşturulan bağlı listeyi istenen tool gösterir.
            string ListeYazdır(CvpCagriLList list)
            {
                string liste = " ";
                int sıra = 1;//sıra bildirimi .

                //liste içinde sona kadar gidip değerleri atayacak.
                if (list.head == null)
                {
                    liste = "Çağrı bulunmamaktadır.";
                    
                }
                // listenin sonuna ekleme yapar.
                else
                {
                   
                    AtananCagriNode temp = list.head;
                    while (temp.next != null)
                    {
                        liste = (temp.CevaplananCagriid + "       " + temp.cevaplayanMTemsilcisi + "           " + temp.baslamaZamani + "       " + temp.bitisZamani + "      " + temp.notlar +"\n");
                        sıra++;
                        temp = temp.next;
                        listBox1.Items.Add(liste);

                    }


                    liste = (temp.CevaplananCagriid + "       " + temp.cevaplayanMTemsilcisi + "           " + temp.baslamaZamani + "       " + temp.bitisZamani + "      " + temp.notlar + "\n");



                    listBox1.Items.Add(liste);


                }
                return liste;
            }

           
            ListeYazdır(T1AtananListe);
            ListeYazdır(T2AtananListe);
            ListeYazdır(T3AtananListe);
            ListeYazdır(T4AtananListe);

        }

       
    }
}

