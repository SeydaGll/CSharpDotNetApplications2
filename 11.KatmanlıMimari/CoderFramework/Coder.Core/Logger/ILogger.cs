using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder.Core.Logger
{
    public interface ILogger
    {
        void WriteLog(string message);
    }
}
