using AuditLogger.Core.Interfaces;
using AuditLogger.Core.Models;
using Npgsql;

namespace AuditLogger.Core.Stores
{
    public class DbLogStore : ILogStore
    {
        private readonly string _connectionString;

        public DbLogStore(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Save(LogEntry entry)
        {
            try
            {
                using var conn = new NpgsqlConnection(_connectionString);
                conn.Open();

                var cmd = new NpgsqlCommand(
                    "INSERT INTO logs(user_id, action, timestamp, details) VALUES (@u, @a, @t, @d)",
                    conn);

                cmd.Parameters.AddWithValue("u", entry.UserId);
                cmd.Parameters.AddWithValue("a", entry.Action);
                cmd.Parameters.AddWithValue("t", entry.Timestamp);
                cmd.Parameters.AddWithValue("d", (object?)entry.Details ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // fallback (по заданию)
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

                var cmd = new NpgsqlCommand("SELECT user_id, action, timestamp, details FROM logs", conn);

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