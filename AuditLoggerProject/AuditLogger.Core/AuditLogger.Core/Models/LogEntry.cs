using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogger.Core.Models
{
    public class LogEntry
    {
        public string UserId { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
        public string Details { get; set; }

        public LogEntry() { }
        public LogEntry(string n_UserId, string n_Action , string n_Details = null)
        {
           
            this.UserId = n_UserId;
            this.Action = n_Action;
            this.Timestamp = DateTime.Now;
            this.Details = n_Details;
        }

        //
        //UserId
        //
        public string getUserId()
        {
            return this.UserId;
        }
        public void setUserId(string s_UserId)
        {
            this.UserId = s_UserId;
        }
        //
        //Action
        //
        public string getAction()
        {
            return this.Action;
        }
        public void setAction(string s_Action)
        {
            this.Action = s_Action;
        }
        //
        //Timestamp
        //
        public DateTime getTimestamp()
        {
            return this.Timestamp;
        }
        public void setTimestamp(DateTime s_Timestamp)
        {
            this.Timestamp = s_Timestamp;
        }
        //
        //Details
        //
        public string getDetails()
        {
            return this.Details;
        }
        public void setDetails(string s_Details)
        {
            this.Details = s_Details;
        }


    }
}
