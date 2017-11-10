using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKIApp2.Entity;

namespace VKIApp2.BusinessLogic

{
    public class Hesaplamalar
    { 
        public static void VKIHesapla(Hasta hasta)    // vkı hesaplaması için hastanın boyu kilosunu bilmeli. o zaman içeriye bir hasta çipinden nesne almalı
        {
            hasta.VKIDeger = hasta.weight / (hasta.height * hasta.height);
            if (hasta.VKIDeger<16)
            {
                hasta.VKISonuc = "İleri Düzeyde Zayıf";
            }
            else if (hasta.VKIDeger>=16 && hasta.VKIDeger<=16.99)
            {
                hasta.VKISonuc = "Orta Düzeyde Zayıf";
            }
            else if (hasta.VKIDeger >= 17 && hasta.VKIDeger <= 18.49)
            {
                hasta.VKISonuc = "Hafif Düzeyde Zayıf";
            }
            else if (hasta.VKIDeger >= 18.50 && hasta.VKIDeger <= 24.99)
            {
                hasta.VKISonuc = "Normal Kilolu";
            }
            else if (hasta.VKIDeger >= 25 && hasta.VKIDeger <= 29.99)
            {
                hasta.VKISonuc = "Hafif Şişman";
            }
            else if (hasta.VKIDeger >= 30 && hasta.VKIDeger <= 34.99)
            {
                hasta.VKISonuc = "1.Derece OBEZ";
            }
            else if (hasta.VKIDeger >= 35 && hasta.VKIDeger <= 39.99)
            {
                hasta.VKISonuc = "2.Derece OBEZ";
            }
            else if (hasta.VKIDeger >= 40)
            {
                hasta.VKISonuc = "3.Derece OBEZ";
            }
            else
            {
                hasta.VKISonuc = "Hatalı Sonuç";
            }

        }
    }
}
