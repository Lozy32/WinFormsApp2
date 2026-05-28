using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp2.Models;
using Microsoft.Data.Sqlite;

namespace WinFormsApp2.Data
{
    public class LoginAttemptRepository
    {
        public List<LoginAttempt> GetAll()
        {
            var attempts = new List<LoginAttempt>();

            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT Id, UserLogin, IsSuccess, Message, CreatedAt FROM LoginAttempts ORDER BY CreatedAt DESC";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                attempts.Add(new LoginAttempt
                {
                    Id = reader.GetInt32(0),
                    UserLogin = reader.GetString(1),
                    IsSuccess = reader.GetInt32(2) == 1,
                    Message = reader.GetString(3),
                    CreatedAt = reader.GetString(4)
                });
            }
            return attempts;
        }

        public void ClearAll()
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM LoginAttempts";
            command.ExecuteNonQuery();
        }
    }
}