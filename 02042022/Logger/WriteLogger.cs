using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_3.Logger
{
    public abstract class WriteLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {

        }

        public abstract void Dispose();
    }
}
