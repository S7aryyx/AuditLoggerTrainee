using AuditLogger.Core.Interfaces;
using AuditLogger.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogger.Core.Service
{
    public class AuditService
    {
        private readonly ILogStore _logStore;

        public AuditService(ILogStore logStore)
        {
            _logStore = logStore;
        }
        
        public void LogAction(string n_UserId , string n_action, string n_details = null)
        {
            var entry = new LogEntry(n_UserId, n_action, n_details);

            try
            {
                _logStore.Save(entry);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка Логирования: " + e.ToString());
            }
        }

        public List<LogEntry> GetLogs()
        {
            return _logStore.GetAll();
        }
    }
}
