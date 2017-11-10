using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ogrencı
    {
        // GET okumak SET Yazmak içndir
        
            
            #region temp
        //private string tcno;
        //public void Set_TCNO(string _tcno)
        //{
        //    if (_tcno.Length==11 && !_tcno.StartsWith("0"))

        //        tcno=_tcno ;

        //}
        //public string Get_TCNO()
        //{
        //    return tcno;
        //} 
        #endregion

        // .NET 2.0(propfull tab a bas). diğer versiyonlarda koşul koyamıyosun. koşul koymak istiyosan bununla yazıcaksın!!!.net20 versiyonuyla

        private string _tcno;

        public string TCNO  // PROPERTY NİN tanımlandığı kısım
        {
            get { return _tcno; }  // get_TCNO() kısmı
            set                     // set_TCNO() kısmı
            {
                if (value.Length == 11 && !value.StartsWith("0"))
                    _tcno = value;
                _tcno = value;  // bize arka tarafta gizliden geçen parametredir.
            }  
        }

        //.NET 3.5 BUNDA koşul koyamıyoorsun

        public string adSoyad { get; set; }  // c//c#  5.0 ve öncesi versiyonlarda okunmaması yada yazılmaması için private diyebilyosın önüne

                                            //c#  6.0 ile silebiliyosun get yada seti durumuna göre 
                                            // c# 7.0 ile de değer yazabiliyosunuz yanına = diyip...
    }
}
