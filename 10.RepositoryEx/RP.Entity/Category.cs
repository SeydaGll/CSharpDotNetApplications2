using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        [StringLength(32)]
        [Required]
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }  //bir kategorinin altındaki ürünleri listelemek için kullanabileceğim ICollection arayüzünden product isimli bir tane prop yazdık
                                                                    //lazy loading çalışması içinde virtual dedik!!
    }
}
