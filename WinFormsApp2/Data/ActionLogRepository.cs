using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using WinFormsApp2.Models;

namespace WinFormsApp2.Data
{
    public class ActionLogRepository
    {
        private readonly int? _currentUserId;
        private readonly string _currentUserLogin;

        public ActionLogRepository(int? currentUserId = null, string currentUserLogin = null)
        {
            _currentUserId = currentUserId;
            _currentUserLogin = currentUserLogin;
        }

        public void Add(string actionType, string entityName, string details)
        {
            if (_currentUserId == null) return;

            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO ActionLogs (UserId, UserLogin, ActionType, EntityName, Details, CreatedAt)
                VALUES ($userId, $userLogin, $actionType, $entityName, $details, $createdAt)";
            command.Parameters.AddWithValue("$userId", _currentUserId.Value);
            command.Parameters.AddWithValue("$userLogin", _currentUserLogin);
            command.Parameters.AddWithValue("$actionType", actionType);
            command.Parameters.AddWithValue("$entityName", entityName);
            command.Parameters.AddWithValue("$details", details);
            command.Parameters.AddWithValue("$createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            command.ExecuteNonQuery();
        }

        public List<ActionLog> GetAll()
        {
            var logs = new List<ActionLog>();
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT Id, UserId, UserLogin, ActionType, EntityName, Details, CreatedAt FROM ActionLogs ORDER BY CreatedAt DESC";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                logs.Add(new ActionLog
                {
                    Id = reader.GetInt32(0),
                    UserId = reader.GetInt32(1),
                    UserLogin = reader.GetString(2),
                    ActionType = reader.GetString(3),
                    EntityName = reader.GetString(4),
                    Details = reader.GetString(5),
                    CreatedAt = reader.GetString(6)
                });
            }
            return logs;
        }
    }
}