using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    //Bu bağlı liste telesekretere gelmiş ve bir müşteri temsilcisi tarafından cevaplanmış çağrıları tutar.
    public class CvpCagriLList
    {
        public int GorusmeSayisi { get; set; } = 0;
        public string temsilciId { get; set; }

        //listenin başını tutar.
        public AtananCagriNode head { get; set; }

        //Liste üretildiğinde baş null atanır.
        public CvpCagriLList()
        {
            head = null;

        }


        //Listeye sondan ekleme yapar.
        //sıra mantığından dolayı sondan ekleme tercih edilmiştir.
        public AtananCagriNode GorusmeBilgisiGiris(string mT,string musteriTC, string basZmn, string bitZmn, string nt,string cevaplananCagriId)
        {
           
            AtananCagriNode gorusme = new AtananCagriNode(mT,musteriTC, basZmn, bitZmn, nt);
            
            //eğer liste boşsa ilk elemanı ekler.
            if (head == null)
            {
                head = gorusme;
                gorusme.CevaplananCagriid = cevaplananCagriId;
            }
            // listenin sonuna ekleme yapar.
            else
            {
               
                AtananCagriNode temp = head;
                while (temp.next != null)
                {
                    gorusme.CevaplananCagriid =cevaplananCagriId;
                    temp = temp.next;
                }
                gorusme.CevaplananCagriid = cevaplananCagriId;
                temp.next = gorusme;
            }

            return head;

        }

        //listeyi yazdırma fonk.
        public string ListeYazdır()
        {
            string liste = " ";
          
            //liste içinde sona kadar gidip değerleri atayacak.
            if (head == null)
            {
                liste = "Çağrı bulunmamaktadır.";
            }
           // listenin sonuna ekleme yapar.
            else
            {

                AtananCagriNode temp = head;
                while (temp.next != null)
                {
                   

                    liste += (temp.CevaplananCagriid + "        " + temp.cevaplayanMTemsilcisi + "          " + temp.baslamaZamani + "          " + temp.bitisZamani + "         " + temp.notlar + "\n");
                    temp = temp.next;

                }

                liste += (temp.CevaplananCagriid + "        " + temp.cevaplayanMTemsilcisi + "          " + temp.baslamaZamani + "          " + temp.bitisZamani + "         " + temp.notlar + "\n");
            }
            return liste;
        }

        //listenin uzunluğunu verir.
        public int getCount( CvpCagriLList list)
        {
            AtananCagriNode temp = list.head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }


    

   

}
