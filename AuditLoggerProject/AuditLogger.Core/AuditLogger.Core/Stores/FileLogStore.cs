using AuditLogger.Core.Interfaces;
using AuditLogger.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AuditLogger.Core.Stores
{
    public class FileLogStore : ILogStore
    {
        private readonly string _path;

        public FileLogStore(string path)
        {
            _path = path;
        }
        public void Save(LogEntry entry)
        {
            try
            {
                //var json = 0;//Зафигарить генерацию json

                var json_02 = JsonSerializer.Serialize(entry);
                File.AppendAllText(_path, json_02 + Environment.NewLine);
            }
            catch
            {
                Console.WriteLine($"[FALLBACK] {entry.getUserId()} , {entry.getAction()}");
            }
        }
        public List<LogEntry> GetAll()
        {
            var list = new List<LogEntry>();

            if (!File.Exists(_path))
            {
                return list;
            }

            var lines = File.ReadAllLines(_path);

            foreach (var line in lines)
            {
                try
                {
                    var log = JsonSerializer.Deserialize<LogEntry>(line); //Зафигарить Расшифровку json
                    list.Add(log);
                }
                catch
                {

                }
            }
            return list;

        }
    }
}
