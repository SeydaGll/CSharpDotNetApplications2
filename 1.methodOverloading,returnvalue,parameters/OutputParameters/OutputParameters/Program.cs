using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tutar = 1000;
            decimal kdv;
            decimal genelToplam = FaturaHesapla(tutar,out kdv);
            Console.WriteLine($"Tutar : \t{tutar}\nKDV : \t{kdv}\nGenel Toplam : \t{genelToplam}");
            Console.ReadLine();

        }

        static decimal FaturaHesapla(decimal tutar, out decimal kdv) // metoddan geriye sadece bir değer döner
        {
            kdv = tutar * 0.18m;
            decimal kdvliTutar = kdv + tutar;
            return kdvliTutar;

            

        }
        // Tuple birden fazla değeri döndürmek için biraz hız kazandırıyor!!!
    }
}
