using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracTakip
{
    public class Arac  //yapılması gereken işlem arabanın hızı değiştiği zaman yapılacak. çünkü benim olayım arabamın hızının değişmesiyle alakalı. onun için bunların set bloklarını birazcık değiştiricez
    {
        private string plaka;
        private int hiz;

        public string Plaka
        {
            get { return plaka; }
            set { plaka = value; }
        }

        

        public int Hiz
        {
            get { return hiz; }
            set {

                //if (HizDegisti != null)
                //{

                //}
                HizDegisti?.Invoke(this, new AracEventArgs(Plaka,value)); // neden null kontrolü yaptık? çünkü ben bir event i tetiklicem ve eventin tipi bir temsilci. eğer bu temsilcinin temsil edeceği hiçbirşey yoksa temsilcim null dur ve ben null olan bir şeyi tetikleyemem .. bundan dolayı.
                
                hiz = value;


            }
        }

        public event AracEventHandler HizDegisti;


    }
}
