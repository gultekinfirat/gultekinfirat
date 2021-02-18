using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor= Bir klass yenilendiğinde(New) çalışan bloğa denir.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;// Yenilenme(New) esnasında referans kodunun değişmemesi adona oluşturulan bir geçici diziyi ifade eder.Bu sayede eleman kaybı önlenmiş olur.
            items = new T[items.Length+1];// legnth eleman sayısını ifade eder. ve yanda yazılan kod sayesinde eleman sayısı bir arttırıldı.(Dinamik olarak)
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

           }

            items[items.Length - 1] = item;

        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] items
        {
            get { return items; }  
        }


    }
}
