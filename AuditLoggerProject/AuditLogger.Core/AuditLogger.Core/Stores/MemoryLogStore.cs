using AuditLogger.Core.Interfaces;
using AuditLogger.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogger.Core.Stores
{
    public class MemoryLogStore : ILogStore
    {
        private List<LogEntry> _logs = new List<LogEntry>();

        public void Save(LogEntry entry)
        {
            _logs.Add(entry);
        }
        public List<LogEntry> GetAll()
        {
            return _logs;
        }
    }
}
