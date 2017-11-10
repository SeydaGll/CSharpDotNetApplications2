using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.name = "Özge";
            p1.surname = "Akın";
            p1.TCNO = "98765432145";
            p1.age = 35;

            Person p2 = new Person();
            p2.name = "Selim";
            p2.surname = "Solmaz";
            p2.TCNO = "12345678908";
            p2.age = 29;

            //ShowPerson(p1);   // p1 in tipi Person
            //ShowPerson(p2);   //p2 nin tipi Person

            Person.ShowPersonStatic(p1);
            Person.ShowPersonStatic(p2);

            p1.ShowPersonNonStatic();
            p2.ShowPersonNonStatic();

        }
    }
     internal class Person   //artık benim Person isminde bir varlığım var.bilgisayara person isminde bir varlık old tanımladım
        {
        public string name;  // bu global bir değişken .çünkü class ın altında 
        public string surname;
        public byte age;
        public string TCNO;  // 4 DEĞİŞKEN VAR VE BİR KİŞİ HAKKINDA BELLLİ BİLGİLERİ ALABİLİCEM

        public static void ShowPersonStatic(Person person)  // int te bir tip, Person da bir tip.
        {
            Console.WriteLine(person.name + " " + person.surname);
        }

        public  void ShowPersonNonStatic()  // int te bir tip, Person da bir tip.
        {
            Console.WriteLine(name + " " +surname);
        }
    }
}
// CLASS nasıl kullanılır.class referans bir tiptir.sizin kendi yazdığınız referans bir tipi kullanmak istiyosan ondan bir örnek oluşturulur
// varsayılan olarak class üyeleri private tır.private sadece iyelere uygulanır.ulaşamazsın. varsayılan olarak class lar internal.