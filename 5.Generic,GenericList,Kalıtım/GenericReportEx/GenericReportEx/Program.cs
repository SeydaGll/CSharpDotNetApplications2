// pdf raporu oluşturup ekranda gösteren bir uygulama yazıyoruz. raporun adını konsol ekranına yazdırıcaz
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericReportEx  // Rapor uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfReport pdfReport = new PdfReport() { Title="PDF Rapor"}; // title atamak için yaptık
            ReportManager<PdfReport>.ShowReport(pdfReport);
            
            
        }
    }

    public class ReportManager<T> where T:ReportBase  // raporların işlenmesi ve gösterilmesi ile ilgili class
    {
        public static void ShowReport(T report) // t REPORTBASE 
        {
            Console.WriteLine(report.Title);
        }
        
        public static void CreateReport()
        {

        }

        public static void SaveReport()
        {

        }

    }

    public abstract class ReportBase
    {
        public string Title { get; set; }
    } /* bütün raporlarda ortak olmasını istediğim özellikler varsan bunu kalıtım yapayım
    bütün sınıflarımın hepsi bir rapor olmak istioysa reportBase den kalıtım yapmak zorundadır dedik.abstract: Reportbase sınıfından 
    bir örnek üretemicekler ama miraz alabilecekler... */

    public class PdfReport:ReportBase
    {

    }

    public class ExcelReport:ReportBase
    {

    }

    public class WordReport:ReportBase
    {

    }
}
/*tüm uygulama boyunca bir tane metod metodu kullanılsın ve her defasında o metod kullanılsın istiyosun. ben sürekli
 yeni bir örnek oluşturmak zorunda kalmayayım. o zaman metod başına static yazıyorum ve örnek oluşturmadan ona ulaşabileyim.
 
     bir sınıfın üyelerine de ulaşmak istersem o sınıftan bir örnek oluşturmam gerekiyor!!!*/