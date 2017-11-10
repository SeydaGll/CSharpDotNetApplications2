using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Entity
{
    public class Product
    {
        public int ProductId { get; set; }  //productId diyerek entityframework bunun PrimaryKey olduğunu biliyor
        [StringLength(128)]
        [Required]
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } //product ımın hangi kategoride olduğunu ben daha pratik şekilde yönlendireyim diye category için bir navigation prop yazdım!!
    }
}
