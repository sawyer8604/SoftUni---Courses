using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.IO.Interfeces
{
    public interface IWriter
    {
        public void Write(string text);

        public void WriteLine(string text);
    }
}
