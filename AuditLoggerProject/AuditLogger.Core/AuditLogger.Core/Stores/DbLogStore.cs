using AuditLogger.Core.Interfaces;
using AuditLogger.Core.Models;
using Npgsql;

namespace AuditLogger.Core.Stores
{
    public class DbLogStore : ILogStore
    {
        private readonly string _connectionString;

        public DbLogStore()
        {
            _connectionString = "Host = 46.191.235.28; Port = 5432; Username = postgres; Password = Asdf = 1234Asdf = 1234; Database = pm_01";
        }

        public void Save(LogEntry entry)
        {
            try
            {
                using var conn = new NpgsqlConnection(_connectionString);
                conn.Open();

                var cmd = new NpgsqlCommand(
                    "CALL insert_log(@user_id, @action, @time, @details)",
                    conn);

                cmd.Parameters.AddWithValue("user_id", entry.UserId);
                cmd.Parameters.AddWithValue("action", entry.Action);
                cmd.Parameters.AddWithValue("time", entry.Timestamp);
                cmd.Parameters.AddWithValue("details", (object?)entry.Details ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DB ERROR] {ex.Message}");
            }
        }

        public List<LogEntry> GetAll()
        {
            var list = new List<LogEntry>();

            try
            {
                using var conn = new NpgsqlConnection(_connectionString);
                conn.Open();

                var cmd = new NpgsqlCommand("SELECT * FROM getuserlogs();", conn);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new LogEntry
                    {
                        UserId = reader["user_id"].ToString(),
                        Action = reader["action"].ToString(),
                        Timestamp = (DateTime)reader["timestamp"],
                        Details = reader["details"]?.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DB ERROR] {ex.Message}");
            }

            return list;
        }
    }
}