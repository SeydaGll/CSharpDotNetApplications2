using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFApp
{
    public class Product
    {
        public int ProductId { get; set; }
        [StringLength(128)]
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }  // bunu yazmadan update edersek bire çok ilişkili yapar ama ilişki kısmında delete te no action olur yani category sildiğinde product silmez 
        //25)) ürünün category tipinden bir kategorisi vardır
        public Category Category { get; set; }  // her 
    }
}
// 20))şimdi bunu database götürüp yazdırmak istiyosam dataset tanımlayıp prop oluşşturuyoruk