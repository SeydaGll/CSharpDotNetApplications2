using Coder.Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder.DataAccess.Abstract
{
    public interface ICategoryDAL : IEntityRepository<Category>
    {
        /*neden bunu yazdık ? base sınıfı yeterli değil mi? ..ben yarın bir categorinin üst kategorisini getirebilen bir sınıf yazabilirim. bir kategorinin altındaki ürünleri
         bana gönderen bir metod yazabilirim,bunun gibi operasyonlarımıda gelip burada özelleştiricem.. çünkü eğer gidip bu tür operasyonu base in içinde yaparsam ben bir product ıda 
         açtığımda product la hiç alakası olmayan dummy(aptal) metodlar olucak.. kategorinin üst kategorini getir gibi şeyler Product için anlamsız.. herşeyi olması gerektiği
         yere koymak adına özelleştiriyoruz..*/

    }
}
