using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    public class ApplicationSettings
    {
        public static LoggerType LoggerType { get; set; } = LoggerType.LogToEventViewer;
        

        
    }

    public enum LoggerType
    {
        LogToXML,
        LogToTXT,
        LogToEventViewer

    }
}
