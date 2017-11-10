using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKIApp
{
    class Program
    {
        static void Main(string[] args)


       {
            VkıHesapla();

            YenıIslemSorusu();
            Console.ReadLine();

            
            

        }
        private static void VkıHesapla()
        {
            Console.WriteLine("Kaç kişinin VKI si hesaplanacaktır ?");
            int number = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[number];
            string[] surname = new string[number];
            string[] tcno = new string[number];
            float[] height = new float[number];
            int[] weight = new int[number];
            float[] sonuc = new float[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine((i + 1) + ".Hastanın Adını Giriniz : ");
                name[i] = Console.ReadLine();
                Console.WriteLine((i + 1) + ".Hastanın Soyadını Giriniz : ");
                surname[i] = Console.ReadLine();
                Console.WriteLine((i + 1) + ".Hastanın tcno sunu Giriniz : ");
                tcno[i] = Console.ReadLine();
                Console.WriteLine((i + 1) + ".Hastanın boyunu Giriniz(m) : ");
                height[i] = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine((i + 1) + ".Hastanın kilosunu Giriniz : ");
                weight[i] = Convert.ToInt32(Console.ReadLine());

                sonuc[i] = (weight[i] / (height[i] * height[i]));
            }
            Console.Clear();
            for (int i = 0; i < number; i++)
            {
                if (sonuc[i] < 16)
                {
                    Console.WriteLine(name[i] + " " + surname[i] + " hastasının boyu " + height[i] + " kilosu " + weight[i] +
                        " VKI Değeri " + sonuc[i]);
                    //Console.WriteLine($"{name[i]} {surname[i]} hastasının boyu {height[i]} kilosu {weight[i]} VKI Değeri {sonuc[i]}");
                    Console.WriteLine("Sonuc: İleri Düzeyde Zayıf");

                }
                else if (sonuc[i] >= 16 && sonuc[i] <= 16.99)
                {
                    Console.WriteLine(name[i] + " " + surname[i] + " hastasının boyu " + height[i] + " kilosu " + weight[i] +
                        " VKI Değeri " + sonuc[i]);
                    Console.WriteLine("Sonuc: Orta Düzeyde Zayıf");
                }
                else if (sonuc[i] >= 17 && sonuc[i] <= 18.49)
                {
                    Console.WriteLine(name[i] + " " + surname[i] + " hastasının boyu " + height[i] + " kilosu " + weight[i] +
                        " VKI Değeri " + sonuc[i]);
                    Console.WriteLine("Sonuc: Hafif Düzeyde Zayıf");
                }
                else if (sonuc[i] >= 18.50 && sonuc[i] <= 24.9)
                {
                    //Console.WriteLine(name[i] + " " + surname[i] + " hastasının boyu " + height[i] + " kilosu " + weight[i] +
                    // " VKI Değeri " + sonuc[i]);
                    Console.WriteLine($"{name[i]} {surname[i]} hastasının boyu {height[i]} kilosu {weight[i]} VKI Değeri {sonuc[i]}");
                    Console.WriteLine("Sonuc: Normal Kilolu");
                }
                else if (sonuc[i] >= 25 && sonuc[i] <= 29.99)
                {
                    Console.WriteLine(name[i] + " " + surname[i] + " hastasının boyu " + height[i] + " kilosu " + weight[i] +
                        " VKI Değeri " + sonuc[i]);
                    Console.WriteLine("Sonuc: Hafif Şişman/ Fazla Kilolu");
                }
                else if (sonuc[i] >= 30 && sonuc[i] <= 34.99)
                {
                    Console.WriteLine(name[i] + " " + surname[i] + " hastasının boyu " + height[i] + " kilosu " + weight[i] +
                        " VKI Değeri " + sonuc[i]);
                    Console.WriteLine("Sonuc:1.Derecede Obez");
                }
                else if (sonuc[i] >= 35 && sonuc[i] <= 39.99)
                {
                    Console.WriteLine(name[i] + " " + surname[i] + " hastasının boyu " + height[i] + " kilosu " + weight[i] +
                        " VKI Değeri " + sonuc[i]);
                    Console.WriteLine("Sonuc: 2.Derecede Obez");
                }
                else if (sonuc[i] >= 40)
                {
                    Console.WriteLine(name[i] + " " + surname[i] + " hastasının boyu " + height[i] + " kilosu " + weight[i] +
                        " VKI Değeri " + sonuc[i]);
                    Console.WriteLine("Sonuc: 3.Derecede Obez / Morbid Obez");
                }

            }
        }
        private static void YenıIslemSorusu()
        {
            Console.WriteLine("Yeni hastalar için hesaplama istiyor musunuz(E/H)?");
            string response = Console.ReadLine();
            response = response.ToLower();
            if (response == "e")
            {
                Console.Clear();
                VkıHesapla();

            }
            else if (response == "h")
            {
                Console.Clear();
                Console.WriteLine("bye bye");
            }
        }

    }
    
}
