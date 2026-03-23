using AuditLogger.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogger.Core.Interfaces
{
    public interface ILogStore
    {
        void Save(LogEntry entry);
        List<LogEntry> GetAll();
    }
}
