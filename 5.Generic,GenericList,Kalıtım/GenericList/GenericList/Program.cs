using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList  // arrlist gibi 
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> gList = new GenericList<string>(); // genericList imi türettim . string ile çalıan genericList
            gList.Add("Ahmet");
            GenericList<int> iList = new GenericList<int>();
            iList.Add(5);
            Console.ReadLine();

            List<string> sstrList = new List<string>();  // aRRAY LİSTİN GENERİC HALİ
            sstrList.Add()


        }
    }

    public class GenericList<T>
    {
        T[] _dizi;

        public GenericList()
        {
            _dizi = new T[4];
        }

        public void Add(T nesne)
        {
            for (int i = 0; i < _dizi.Length; i++)
            {
                if (_dizi[i] == null)  // eleman eklenmemeiş olan dizinin ilk indeksini bulmuş olucam
                {
                    _dizi[i] = nesne;
                    break;
                }

            }
        }
    }
}
