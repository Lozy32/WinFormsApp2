using Microsoft.Data.Sqlite;
using System;
using WinFormsApp2.Models;
using WinFormsApp2.Helpers;
using WinFormsApp2.Data;


namespace WinFormsApp2.Data
{
    public class UserRepository
    {
        public User FindByLogin(string login)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
                SELECT u.Id, u.Login, u.PasswordHash, u.PasswordSalt, u.FullName, u.IsActive, 
                       u.RoleId, r.Name AS RoleName
                FROM Users u
                LEFT JOIN Roles r ON r.Id = u.RoleId
                WHERE u.Login = $login";
            command.Parameters.AddWithValue("$login", login);

            using var reader = command.ExecuteReader();
            if (!reader.Read()) return null;

            string roleName = reader.IsDBNull(7) ? "user" : reader.GetString(7);

            return new User
            {
                Id = reader.GetInt32(0),
                Login = reader.GetString(1),
                PasswordHash = reader.GetString(2),
                PasswordSalt = reader.GetString(3),
                FullName = reader.GetString(4),
                IsActive = reader.GetInt32(5) == 1,
                RoleId = reader.GetInt32(6),
                RoleName = roleName
            };
        }

        public bool LoginExists(string login) => FindByLogin(login) != null;

        public int CreateUser(string login, string password, string fullName, int roleId)
        {

            string salt = PasswordHasher.GenerateSalt();
            string hash = PasswordHasher.HashPassword(password, salt);

            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();

            command.CommandText = @"
        INSERT INTO Users (Login, PasswordHash, PasswordSalt, FullName, RoleId, IsActive, CreatedAt)
        VALUES ($login, $hash, $salt, $fullName, $roleId, 1, $createdAt);
        SELECT last_insert_rowid();";

            command.Parameters.AddWithValue("$login", login);
            command.Parameters.AddWithValue("$hash", hash);
            command.Parameters.AddWithValue("$salt", salt);
            command.Parameters.AddWithValue("$fullName", fullName);
            command.Parameters.AddWithValue("$roleId", roleId);
            command.Parameters.AddWithValue("$createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            int userId = Convert.ToInt32(command.ExecuteScalar());
            return userId;  
        }

        public void AddLoginAttempt(string login, bool success, string message)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO LoginAttempts (UserLogin, IsSuccess, Message, CreatedAt)
                VALUES ($login, $success, $message, $createdAt)";
            command.Parameters.AddWithValue("$login", login);
            command.Parameters.AddWithValue("$success", success ? 1 : 0);
            command.Parameters.AddWithValue("$message", message);
            command.Parameters.AddWithValue("$createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            command.ExecuteNonQuery();
        }
    }
}