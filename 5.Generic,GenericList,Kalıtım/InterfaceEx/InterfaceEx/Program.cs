using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx // log lama işlemi yapıyor bu uygulamamız
{
    class Program
    {
        static void Main(string[] args)
        {
            //LogToXML logger = new LogToXML();
            //logger.WriteLog("hata meydana geldi");

            var logger = LoggerFactory.CreateLogger();
            logger.WriteLog("mesaj");

            

        }
    }

    public class LogToXML:ILogger // XML le log yazsın bu
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("XML e Log Yazıldı");
        }
    }

    public class LogToIventViewer:ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("Evviewer e Log Yazıldı");
        }
    }
    public class LogToTXT : ILogger // XML le log yazsın bu
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("TXT e Log Yazıldı");
        }
    }
}
