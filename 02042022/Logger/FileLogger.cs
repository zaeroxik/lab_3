using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Logger
{
    class FileLogger : WriteLogger
    {
        public FileLogger(string name)
        {

        }

        public override void Log(params string[] messages)
        {
            writer = Console.Out;
            writer.Write("123");
            writer.Flush();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
