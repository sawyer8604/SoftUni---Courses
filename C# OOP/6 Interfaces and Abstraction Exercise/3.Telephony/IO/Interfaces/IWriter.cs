using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Telephony.IO.Interfaces
{
    public interface IWriter
    {
        public void Write(string text);

        public void WriteLn(string text);
    }
}
