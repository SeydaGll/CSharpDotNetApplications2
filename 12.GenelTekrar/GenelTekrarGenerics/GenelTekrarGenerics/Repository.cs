using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrarGenerics
{
    #region 1 Resitory
    //public class Repository
    //{
    //    public void Ekle(Urun urun)
    //    {

    //    }
    //    public void Sil(Urun urun)
    //    {

    //    }
    //    public void Guncelle(Urun urun)
    //    {

    //    }
    //    public List<Urun> TumUrunler()
    //    {
    //        return new List<Urun>();
    //    }
    //    public Urun UrunGetir(int id)   // bir tane ürün getirsin
    //    {
    //        return new Urun();
    //    }
    //} 
    #endregion

    #region 2 Repository<T>
    //public class Repository<T>
    //{
    //    public void Ekle(T urun)
    //    {

    //    }
    //    public void Sil(T urun)
    //    {

    //    }
    //    public void Guncelle(T urun)
    //    {

    //    }
    //    public List<T> TumUrunler()
    //    {
    //        return new List<T>();
    //    }
    //    public T UrunGetir(int id)   // bir tane ürün getirsin
    //    {
    //        return new T();
    //    }

    //} 
    #endregion

    #region 3 Repository<T> where T : new()
    //public class Repository<T> where T : new()
    //{
    //    public void Ekle(T varlik)
    //    {

    //    }
    //    public void Sil(T varlik)
    //    {

    //    }
    //    public void Guncelle(T varlik)
    //    {

    //    }
    //    public List<T> TumVarlik()
    //    {
    //        return new List<T>();
    //    }
    //    public T VarlikGetir(int id)   // bir tane ürün getirsin
    //    {
    //        return new T();
    //    }

    //} 
    #endregion

    #region Repository<T> where T : IEntity,new()
    public class Repository<T> where T : IEntity, new() // sıralama önemli
    {
        public void Ekle(T varlik)
        {

        }
        public void Sil(T varlik)
        {

        }
        public void Guncelle(T varlik)
        {

        }
        public List<T> TumVarlik()
        {
            return new List<T>();
        }
        public T VarlikGetir(int id)   // bir tane ürün getirsin
        {
            return new T();
        }

    } 
    #endregion
}
