using System;
using System.Collections;
using System.Collections.Generic;

namespace Kokin.Core
{
    public abstract class AbstractLog
    {
        protected string FormatLog(IEnumerable<string> strings)
        {
            return string.Join(";\n\r", strings);
        }

        protected void WriteConsole(string s)
        {
            Console.WriteLine(s);
        }

        protected void WriteConsole(IEnumerable<string> strings)
        {
            Console.WriteLine(FormatLog(strings));
        }
    }
}