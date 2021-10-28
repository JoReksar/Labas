using System;
using System.Collections.Generic;
using System.IO;
using Lab.Core;

namespace Kokin.Nikita
{
    public class Nikita : LogAbstract, LogInterface
    {
        private static readonly string PathToLogAppdata;
        private static readonly string Version;
        static Nikita()
        {
            PathToLogAppdata = Environment.ExpandEnvironmentVariables("%appdata%/log");
            Directory.CreateDirectory(PathToLogAppdata);
            Version = File.ReadAllText("../../../version");
        }
        
        private static Nikita _instance;
        public static Nikita I => _instance ??= new Nikita();
        private Nikita()
        {

        }

        private readonly List<string> _logs = new();
        
        public LogInterface Log(string str)
        {
            _logs.Add(str);
            return this;
        }
        
        public LogInterface Write()
        {
            WriteConsole(_logs.ToArray());
            var dateTime = DateTime.Now;
            var date = dateTime.ToShortDateString();
            var time = dateTime.ToShortTimeString().Replace(':', '.');
            var pathToFile = $"{PathToLogAppdata}/{date}_{time}.{dateTime.Millisecond}.log";
            var logs = string.Join(";\n\r", _logs);
            File.WriteAllText(pathToFile, $"ВЕРСИЯ ПРОГРАММЫ: {Version}\n\r{logs}");
            return this;
        }
    }
}