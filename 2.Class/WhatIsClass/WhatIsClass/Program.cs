using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// class bir tiptir. 
/* 1.gerçek hayattaki nesneleri tanıtmak
 2. birtkım işlevsellikleri yerine getirmek üzere yazdığımız metodlarımızı ve diğer gerekliliklerimizi gruplandırmak yani sınıflandırmak 
 için kullanıyoruz.
 3..net ın içerisinde bana hazır olarak sunulmayan bir şey yapıcam.<öğrenci,hasta,araba tanıtmak istiyorum. bunların hepisinin davranışları 
 ve özellikleri vardır.randuvalma iptali gelip gelmeme davranışları vardır. özelliği vardır. ben bir sınıf tanımlayarak yazılımıma
 o insanı tanıtıyorum ve o insanını davranışllarınıda o sınıf üzerinde modelleyebiliyorum. davranışları metdolar ile özelliklerinide
 property ile geliştirebiliyorum.

    strinG[] Arr = new string[5]
    Arr.Lenght  lenght özelliktir..
 
     Math sınıfına baktığınızda matematk işlemlerinn olduğu tüm olaylar için .net in math sınıfını kullanırım
     File sınıfını kullanarak ( windows taki bir txt dosyasını okumak istiyorum) tüm dosyalama işlemleri yaparım
     veri tabanı bağlantısıyla ilgili yazacağım bütün metodları oluşturduğum sınıfın içerisine yazabilirim .derli toplu proje olur ve 
     hata olursa bakıcağım yer bellidlir..*/
namespace WhatIsClass  
{
    /*public: her yerden erişilebilir. whatisclass projesi içerisinden public yaptığım bşr sınıfa komple erişimim var
     * solutonda başka exembly aşka proje varsa ordanda erişilebilir.
     * private: sadece sınıf üyerine uygulanır.. class lar private olmaz.sadece içerisinde old sınıftan erişilebilir.
     * internal : içerisinde olunan assemlyden erişilebilir. class lara uygulanırç sadece whatısclass projesinden erişilsin
     * başka projeden erişilmesin istiyosan internal diyosun class ın başına.
     * protected : kalıtım ile ilgli bir durum .yalnızca kalıtım yapan sınıflardan erişilebilir. 
     * sınıfın üyelerine(sınıfın altındaki metod,event,değişkenler) herhangi bir erişim belirleyici yoksa bu private tır. Varsayılan olarak 
     sınıflar internal dır.*/
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();  // bir kişi için bütün bilgileri p1 taşıyor. p1 in içerisindeki herşeyi taşıyabilecek bir alan açılır
            p1.name = "Ahmet";
            p1.surname = "Bircan";
            p1.tcno = "1234567898";
            p1.age = 35;

            Person p2 = new Person();
            p2.name = "Özlem";
            p2.surname = "Kalender";
            p2.tcno = "12345698";
            p2.age = 29;
            
            


            //ShowPerson(p1);
            //ShowPerson(p2);

            //Person.ShowPersonStatic(p1);
            //Person.ShowPersonStatic(p2);

            p1.ShowPersonNonStatic();
            p2.ShowPersonNonStatic();

            

        }

        
        
        
       
    }

    public class Person   // class referans bir tiptir.
    {
        public string name;
        public string surname;
        public byte age;
        public string tcno;

        public static void ShowPersonStatic(Person person)  /* 2 tane string değişken göndermek yerine bir kişiye ait bütün verileri sadece tek bir 
            tane parametre göndererek taşımış oldum*/ // bütün person lar için ortak çalışıcaksa static olabilir
        {
            Console.WriteLine(person.name + person.surname);
        }

        public void ShowPersonNonStatic() // her person için ayrı ayrı çalışıcaksa static dememem lazım.
        {                                           // static almadığı için içerisine parametre almak zorunda değil.
            Console.WriteLine(name + surname);
        }
    }
}

