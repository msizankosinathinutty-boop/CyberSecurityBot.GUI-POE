using MySql.Data.MySqlClient;
using CybersecurityAwarenessBot.Models;
using CybersecurityAwarenessBot.Data;

namespace CybersecurityAwarenessBot.Data
{
    public class TaskRepository

    {
        //ADD: Save a new task to MySQL.
        public int AddTask(CyberTask task)
        {
            string sql = @"INSERT INTO cyber_tasks  
                 (title, description, reminder_date, is_completed)
                 VALUES (@title, @description, @reminder, @completed);";

            using (MySqlConnection connection =
                new MySqlConnection(DatabaseConfig.ConnectionString))
            using (MySqlCommand command =
                new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@title", task.Title);
                command.Parameters.AddWithValue("@description", task.Description);

                command.Parameters.AddWithValue(
                    "@reminer",
                    task.ReminderDate.HasValue
                    ? (object)task.ReminderDate.Value
                    : DBNull.Value);

                command.Parameters.AddWithValue("@completed", task.IsCompleted);

                connection.Open();
                command.ExecuteNonQuery();

                return Convert.ToInt32(command.LastInsertedId);
            }
        }

        //READ: Retrieve all tasks from MySQL.
        public List<CyberTask> GetAllTasks()
        {
            List<CyberTask> tasks = new List<CyberTask>();

            string sql = @"Select task_id, title, description,
                reminder_date, is_complete 
                FROM cyber_tasks 
                ORDER BY is_completed, task_id DESC;";

            using (MySqlConnection connection =
                new MySqlConnection(DatabaseConfig.ConnectionString))
            using (MySqlCommand command =
                new MySqlCommand(sql, connection))
            {
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CyberTask task = new CyberTask
                        {
                            TaskId = Convert.ToInt32(reader["task_id"]),
                            Title = Convert.ToString(reader["title"]) ?? "",
                            Description = Convert.ToString(reader["description"]) ?? "",

                            ReminderDate = reader["reminder_date"] == DBNull.Value
                            ? null
                            : Convert.ToDateTime(reader["reminder_date"]),

                            IsCompleted = Convert.ToBoolean(reader["is_completed"])
                        };

                        tasks.Add(task);

                    }
                }
            }

            return tasks;

        }

        //UPDATE: Mark a task as completed.
        public void MarkTaskCompleted(int taskId)
        {
            string sql = @"UPADTE cyber_tasks
                SET is_completed = TRUE 
                WHERE tsak_id =@id;";

            using (MySqlConnection connection = 
                new MySqlConnection(DatabaseConfig.ConnectionString))
            using (MySqlCommand command = 
                new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", taskId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //UPDATE: Change a task's reminder.
        public void UppadteReminder(int taskId, DateTime reminderDate)
        {
            string sql = @"UPADTE cyber_tasks
                SET reminder_date = @reminder
                WHERE task_id = @id;";

            using (MySqlConnection connection = 
                new MySqlConnection(DatabaseConfig.ConnectionString))
                using (MySqlCommand command = 
                new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@reminder", reminderDate);
                command.Parameters.AddWithValue("@id", taskId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //DELETE: Remove a task from MySQL.
        public void DeleteTask(int taskId)
        {
            string sql = @"DELETE FROM cyber_tasks 
                WHERE task_id = @id;";

            using (MySqlConnection connection =
                new MySqlConnection(DatabaseConfig.ConnectionString))
            using (MySqlCommand command =
                new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", taskId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private readonly string connectionString =
            DatabaseConfig.ConnectionString;
    }
}