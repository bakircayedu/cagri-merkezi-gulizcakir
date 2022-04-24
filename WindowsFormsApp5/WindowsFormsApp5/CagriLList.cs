using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    //Bu bağlı liste telesekretere gelen çağrıları tutar.
    public class CagriLList
    {
        //listenin başını tutar.
        public CagriNode head { get; set; }

        //Liste üretildiğinde baş null atanır.
        public CagriLList()
        {
            head = null;
        }
        int tempSıra = 2;
        //arama yap butonuna basınca çalışacak.
        public void Ekle(string tur)
        {
            
            CagriNode cgr = new CagriNode(tur);

            //eğer liste boşsa ilk elemanı ekler.
            if(head==null)
            {
                head = cgr;
                cgr.CagriId = 1;
                cgr.musteriId = 1;
                
            }
            // listenin sonuna ekleme yapar.

            else
            {
                cgr.CagriId =2;
                cgr.musteriId =2;
                CagriNode temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                    cgr.CagriId = tempSıra+1;
                    cgr.musteriId = tempSıra+1;
                }

                temp.next = cgr;
                tempSıra = cgr.CagriId;
            }

        }

        //listeyi yazdırma fonk.
        public string ListeyiYazdır()
        {
            string liste="";
            int sıra = 1;//sıra bildirimi burada yapılabilir.

            //liste içinde sona kadar gidip değerleri atayacak.
            if (head == null)
            {
                liste = "Çağrı bulunmamaktadır.";
            }
            // listenin sonuna ekleme yapar.
            else
            {
               CagriNode temp = head;
                while (temp.next != null)
                {
                    liste += ("    " + temp.musteriId + "         " +temp.musteriTur+ "            " + sıra + "\n");
                    sıra++;
                    temp = temp.next;
                    
                }

            liste += ("    " + temp.musteriId + "         " + temp.musteriTur + "            " + sıra +"\n" +"liste bitti");

            }

            return liste;
        }


        //Linked List'ten baştan silme işlemi yapıyor.
        //Çünkü sıradan çağrılar cevaplanıyor ve sıraya göre başta olanın çağrısı ilk cevaplanır.
        public void CagriAta()
        {
           if(head==null)
            {
                //liste boş;
            }
           else
            {
                head = head.next;
            }
        }

        //Linked List'ten aradan silme işlemi yapıyor.
        //id numarasına göre listeden cagri siler.
        public string IdNoCagriAta(int id)
        {
           
           CagriNode temp = head, prev = null;
            string uyari;
            // If head node itself holds the key to be deleted
           if (temp != null && temp.musteriId == id )
            {
                head = temp.next; // Changed head
             
            }

          // ListeyiYazdır içerisinde id bulmak için gezilir.
           while (temp != null && temp.musteriId != id)
            {
                prev = temp;
                temp = temp.next;
            }

            // Aranan id listede yoksa uyarı verir
            
            if (temp == null)
            {
                return uyari = "Bu sıra numarasında çağrı yok.";
            }
                // Unlink the node from linked list
            prev.next = temp.next;
            return uyari = "Girdiğiniz id numaralı çağrı başarı biçimde atandı.";

        }

        }
    }

