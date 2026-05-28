using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp2.Data;
using WinFormsApp2.Helpers;

namespace WinFormsApp2
{
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            using var connection = new SqliteConnection("Data Source=clinic.db");
            connection.Open();

            
            Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Roles (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL UNIQUE
                )");
            Execute(connection, "INSERT OR IGNORE INTO Roles (Id, Name) VALUES (1, 'admin')");
            Execute(connection, "INSERT OR IGNORE INTO Roles (Id, Name) VALUES (2, 'operator')");
            Execute(connection, "INSERT OR IGNORE INTO Roles (Id, Name) VALUES (3, 'user')");

            
            Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Login TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    PasswordSalt TEXT NOT NULL,
                    FullName TEXT NOT NULL,
                    RoleId INTEGER NOT NULL,
                    IsActive INTEGER NOT NULL DEFAULT 1,
                    CreatedAt TEXT NOT NULL
                )");

           
            Execute(connection, @"
                CREATE TABLE IF NOT EXISTS LoginAttempts (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserLogin TEXT NOT NULL,
                    IsSuccess INTEGER NOT NULL,
                    Message TEXT NOT NULL,
                    CreatedAt TEXT NOT NULL
                )");

            Execute(connection, @"
                CREATE TABLE IF NOT EXISTS ActionLogs (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    UserLogin TEXT NOT NULL,
                    ActionType TEXT NOT NULL,
                    EntityName TEXT NOT NULL,
                    Details TEXT NOT NULL,
                    CreatedAt TEXT NOT NULL
                )");


            Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Doctors (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL,
                    Specialization TEXT NOT NULL,
                    BasePrice REAL NOT NULL,
                    UserId INTEGER
                )");

            
            Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Patients (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL,
                    BirthDate TEXT,
                    Phone TEXT
                )");

            
            Execute(connection, @"
                CREATE TABLE IF NOT EXISTS Appointments (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    PatientId INTEGER NOT NULL,
                    DoctorId INTEGER NOT NULL,
                    AppointmentDate TEXT NOT NULL,
                    VisitType TEXT NOT NULL,
                    FinalPrice REAL NOT NULL
                )");

            
            string salt = PasswordHasher.GenerateSalt();
            string hash = PasswordHasher.HashPassword("admin123", salt);
            Execute(connection, $@"
                INSERT OR IGNORE INTO Users (Id, Login, PasswordHash, PasswordSalt, FullName, RoleId, IsActive, CreatedAt)
                VALUES (1, 'admin', '{hash}', '{salt}', 'Главный администратор', 1, 1, datetime('now'))");
        }

        private static void Execute(SqliteConnection connection, string sql)
        {
            using var command = connection.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }
    }
}