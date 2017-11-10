using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFApp 
{  // 4))
    public class Category // 5)) şimdi bunu götürüp veri tabanında bir oluşturtalım.Context in içerisine bunu bir şekilde bildirmeliyim
    {
        public int CategoryId { get; set; } //15)) Category tablosunda CategoryName in nvarchar(max) olarak geldiğini gördük . bunu değiştirebilirz. BU ŞEKİLDE
        [StringLength(50)]      // sonra package e gidip  Add-Migration UpdateCategoryName.değişiyo. yeni migration oluşturuyor. up ve down da kolonlar alter yapılıyo.sql de görmek için
        [Required]                       // pachage manage console a Update-Database yaz.. 
        public string CategoryName { get; set; }

        //22)
        public virtual ICollection<Product> Products { get; set; }  // burada demek istediğimiz. her categornin altında product isminde bir koleksiyon vardır
          //23) şimdi database tarafında ne olduğuna bakmak içinç Add-Migration addProduct dedik. ve Update-Databese dedik
    }
}
//16)) migration klasörü şişermi ? şişsin çok önemli değil.. son halini aldıktan şöyle yapabilirsiniz..POCO class larınız en son haline gledikten sonra migration klasörünü silin,
//database ide silin.. tekrar migration ı oluşturup database i bir kere daha create ederseniz sadece configuration.cs ve bir tane migraton ı olan bir migration klasörüne sahip olursunuz
//şişip şişmemesi çok önemli değil.