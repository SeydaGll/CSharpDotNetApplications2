using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracTakip
{
    public delegate void AracEventHandler(object sender, AracEventArgs e);

    public class AracEventArgs:EventArgs // bu class butonun tıklandığı zamanki eventargs yada bir textbox a tıklandığı zamanki mouseeventarg sınıfının kendisi.araç event argümanlar sınıfı. tabi bunun argüman özelliğini taşıyabilmesi için sistemdeki eventargs sınıfından kalıtım yapıyor olması lazım!!!önemli
    {
        public AracEventArgs(string _plaka,int _hiz)
        {
            Plaka = _plaka;
            Hiz = _hiz;
        }
        public string Plaka { get; private set; } //eventargüman oluşturulurken kesinlikle bunlara değer atansın ve sonrasında bunları kimse değiştiremesin istiyorum
        public int Hiz { get; private set; }

    }
}
