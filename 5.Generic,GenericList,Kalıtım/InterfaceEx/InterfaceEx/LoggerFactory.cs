using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    public class LoggerFactory
    {
        public static ILogger CreateLogger()
        {
            ILogger logger = null;
            switch (ApplicationSettings.LoggerType)  //ctrl-a
            {
                case LoggerType.LogToXML:
                    logger = new LogToXML();
                    break;
                case LoggerType.LogToTXT:
                    logger = new LogToTXT();
                    break;
                case LoggerType.LogToEventViewer:
                    logger = new LogToIventViewer();
                    break;
                default:
                    break;
            }
            return logger;
        }
    }
}
