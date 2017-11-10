using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrarGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Urun> repo = new Repository<Urun>();

            Repository<Personel> personel = new Repository<Personel>();

            Repository<Kategori> kategori = new Repository<Kategori>();

            repo.Ekle()
        }
    }
}
