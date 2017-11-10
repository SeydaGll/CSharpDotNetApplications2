using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdr.DataLayer
{
    public class HerhangiBirSınıf
    {
        protected string adSoyad;

        //public HerhangiBirSınıf()
        //{
        //    Connector c = new Connector();
            
        //}
    }

    class Test:HerhangiBirSınıf
    {
        public Test()
        {
            
            
        }
    }
}
/*insan sınıfından türeyen personel sınıfının kullanılabilmesi için bir tane metod yada bir tane property yazmak istiyorum.
   bunu protected yapıyorum. protected yapınca  sınıfın dışından gözükmüy ama kalıtım yapan sınıflardan gözüküyor.. protected olan nesne
   sadece kalıtımı yapan sınıftan erilebiliyor, baska sınıflrdan erişilmiyor.*/
