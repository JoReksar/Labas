using System.Collections.Generic;
using Kokin.Core;

namespace Kokin.Nikita
{
    public class NikitaLog : AbstractLog, ILogInterface
    {
        private static NikitaLog _instance;
        public static NikitaLog I => _instance ??= new NikitaLog();
        private NikitaLog()
        {

        }

        private readonly List<string> _logs = new();
        
        public ILogInterface Log(string str)
        {
            _logs.Add(str);
            return this;
        }
        
        public ILogInterface Write()
        {
            WriteConsole(_logs);
            return this;
        }
    }
}