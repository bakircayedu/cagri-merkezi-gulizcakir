using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class NotlardaArama
    {
        //Doğrusal arama algoritması kullanılmıştır.
        //Tüm node'lar tek tek dolaşılır.Bulunan bilgiler toplanır.
        //kontrol değeri bulunup bulunamaması durumunu kontrol eder.
        public string ArananKelimeyiBul( CvpCagriLList cvpCagriLList,string kelime)
        {
            AtananCagriNode node = cvpCagriLList.head;
            bool kontrol;
            string yanıt = "";
            while (node !=null)
            {

             kontrol=node.notlar.Contains(kelime);

                if (kontrol==true)
                {
                    yanıt+= "Aradığınız sözcük bulundu!" + "\n" +
                            "Müşteri temsilcisi:" + node.cevaplayanMTemsilcisi+ "\n" +
                            "Müşteri Tc:" +node.CevaplananCagriid+ "\n" +
                            "Notu:" + node.notlar + "\n";                
                }
                
                
              
                    node = node.next;
             
            }

            return yanıt;
           
        }




    }
}
