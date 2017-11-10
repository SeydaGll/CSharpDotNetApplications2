using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*global değişken ? heryerden erişerek onun değerini 1 artırabileceğimiz bir değişken oluşturabilir miyiz yada bunu nerde tanımlamamız gerekir.. bu tür değişkenler için uygulama içerisinde
belli ayarlar vardır bunun gibi durumlarda kullandığımız yapılardır*/
namespace GenelTekrar
{
    class ApplicationSettings
    {
        /*global bir değişken olucak ve bu değişken içerisindeki değeri ben bütün heryerden değiştirebilicem.. diyelim bunun değeri 5 sınıfın birisi bunu 6 yaptıysa bir sonra kullanan
        sınıf artırdığı zaman 7 olması lazım*/
        public static int seriNo = 0; // static ki hafızada bir kere üretilsin
    }
}
