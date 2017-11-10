using System; // .net framework te aynı şekilde inşa edilmiş. bütün herşeyşn temelinde system namespace i var.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  // farklı farklı namespace ler altında olan bir hiyerarşik yapı

namespace Cdr.DataLayer // iki tane namespace var, demekkki kodlarımız  daha düzgün bir hiyerarşi altında bulunsun diye namespace kullanıyoruz
{                       // başka hiçbir amacı yok!!.
    internal class Connector
    {
        
    }
}
/*.UYGULAMALARIMIZI GELİŞTİRİRKEN GENELLİKLE BİR ROOT NAMESPACE ALTINDA DALLANDIRARAk namespacelerimizi hazırlayıp ilgili kodlarımızıda
 * namespacelerimizin altında barındırıyoruz. mesela DataLayer dedik, data ile ilgili olan bütün verilerimizin classlarımızın yada nesnelerimizin
 * tamamı bu katmanın altında olucak. bunu biliyorum

 