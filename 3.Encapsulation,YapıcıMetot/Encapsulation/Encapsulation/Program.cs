using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation   // kapsülleme(çok önemli konu.object oriented 3 temel prensibinden biri)
{
    class Program
    {
        static void Main(string[] args)
        {

            Kisi k = new Kisi();
            //k.tc = "12345678908"; // YAZABİLİUORUM
            //string degisken = k.GET_TC();  //OKUYABİLİYORUM
            //k.SET_TC("1356787889");
            
            
        }
    }
    public class Kisi
    {
        
        //#region encapsulation 1
        //private string tc;

        //public string GET_TC()
        //{

        //    return tc;
        //}   // yazamıyorum,okuyabiliyorum

        //public void SET_TC(string tcno)
        //{
        //    if (tcno.Length == 11)
        //    {
        //        tc = tcno;
        //    }

        //    tc = tcno;
        //}   // yazabiliyorum,okuyamıyorum 
        //#endregion

        #region PROPERTY .net 2.0
        private string tc;

        public string TCNO   //PROPERTY bu içeriinde get ve set adında aksesör barındırır
        {
            get { return tc; }  //sınıfın içindeki tc yi dönderir
            set
            {
                if (value.Length == 11)
                    tc = value;
            }  // sınıfın içindeki tc ye dışarda gelen value nın atAMAsını yapar.
        }
        #endregion

        // property lerin .net 3.5 ile gelen yeni bir kullanımı var.c# 6.0 öncesi veriyon kullanıyosanız get yada set in başına private
        #region .net 3.5 sonrasında encapsulation
        public string Ad { get; set; } = "32839238"; // property e değer atayabilme ve aksesör edilebilme 
        #endregion  // Ad ismini tasıyan bir tane property in var


    }
}
/* Kapsülleme: classlar oluşturuyoruz.varlıklarımızı tanımlıyoruz.kimi zaman  bir iş katmanı için oluşturduğumuz hesaplamalar vs yada bir 
bir data bağlantsıı işlevselliklerini yerine grtiren bir sınıf olabilir, kimi zamanda gerçek dünyadaki nesneleri programa tanıtılması amacıyl yazdığımız
kişi,derslik,araba gibi.. ama muhakkak ki bunların hepsinin içerisinde verilerimizi tutmak üzere değişkenler yani fieldler oluşturuyoz*/

    // IIL İNTERMEDİATE LAUNGUAGE