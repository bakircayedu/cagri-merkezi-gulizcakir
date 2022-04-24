using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    //linked list'teki node'lardaki datalar kullanılarak diziye aktarılır.
    //oluşturulan dizi üzerinde bu fonksiyonla sıralama yapılır.
    // Insertion Sort-> düzensiz dizi elemanlarını tek tek ele alarak her birini dizinin sıralanmış kısmındaki uygun yerine yerleştirme esasına dayanır.
    //(yer değiştirerek.)
    public class InsertionSort
    {
        public CvpCagriLList[] Sort(CvpCagriLList [] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1].GorusmeSayisi > inputArray[j].GorusmeSayisi)
                    {
                        int temp = inputArray[j - 1].GorusmeSayisi;
                        string temp2= inputArray[j - 1].temsilciId;
                        inputArray[j - 1].GorusmeSayisi = inputArray[j].GorusmeSayisi;
                        inputArray[j - 1].temsilciId = inputArray[j].temsilciId;
                        inputArray[j].GorusmeSayisi = temp;
                        inputArray[j].temsilciId = temp2;

                    }
                    else
                        break;
                }
            }
            return inputArray;
            


        }
        


    }
}
