using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using WinFormsApp2.Models;

namespace WinFormsApp2.Data
{
    public class DoctorRepository
    {
        public List<Doctor> GetAll(string searchText = "")
        {
            var doctors = new List<Doctor>();

            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                command.CommandText = "SELECT Id, FullName, Specialization, BasePrice FROM Doctors ORDER BY FullName";
            }
            else
            {
                command.CommandText = @"
                    SELECT Id, FullName, Specialization, BasePrice 
                    FROM Doctors 
                    WHERE FullName LIKE $search OR Specialization LIKE $search
                    ORDER BY FullName";
                command.Parameters.AddWithValue("$search", $"%{searchText}%");
            }

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var price = reader.GetDecimal(3);
                doctors.Add(new Doctor
                {
                    Id = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                    Specialization = reader.GetString(2),
                    BasePrice = reader.GetDecimal(3)
                });
            }
            return doctors;
        }

        public void Add(Doctor doctor)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Doctors (FullName, Specialization, BasePrice)
                VALUES ($fullName, $specialization, $price)";
            command.Parameters.AddWithValue("$fullName", doctor.FullName);
            command.Parameters.AddWithValue("$specialization", doctor.Specialization);
            command.Parameters.AddWithValue("$price", doctor.BasePrice);
            command.ExecuteNonQuery();
        }

        public void Update(Doctor doctor)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
                UPDATE Doctors 
                SET FullName = $fullName, Specialization = $specialization, BasePrice = $price
                WHERE Id = $id";
            command.Parameters.AddWithValue("$id", doctor.Id);
            command.Parameters.AddWithValue("$fullName", doctor.FullName);
            command.Parameters.AddWithValue("$specialization", doctor.Specialization);
            command.Parameters.AddWithValue("$price", doctor.BasePrice);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Doctors WHERE Id = $id";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        public Doctor? FindByUserId(int userId)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
        SELECT Id, FullName, Specialization, BasePrice, UserId 
        FROM Doctors 
        WHERE UserId = $userId";
            command.Parameters.AddWithValue("$userId", userId);

            using var reader = command.ExecuteReader();
            if (!reader.Read()) return null;

            return new Doctor
            {
                Id = reader.GetInt32(0),
                FullName = reader.GetString(1),
                Specialization = reader.GetString(2),
                BasePrice = reader.GetDecimal(3),
                UserId = reader.IsDBNull(4) ? null : reader.GetInt32(4)
            };
        }

        public Doctor GetById(int id)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT Id, FullName, Specialization, BasePrice FROM Doctors WHERE Id = $id";
            command.Parameters.AddWithValue("$id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Doctor
                {
                    Id = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                    Specialization = reader.GetString(2),
                    BasePrice = reader.GetDecimal(3)
                };
            }
            return null;
        }

        public void CreateFromUser(int userId, string fullName, string specialization, decimal basePrice)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
        INSERT INTO Doctors (FullName, Specialization, BasePrice, UserId)
        VALUES ($fullName, $specialization, $price, $userId)";
            command.Parameters.AddWithValue("$fullName", fullName);
            command.Parameters.AddWithValue("$specialization", specialization);
            command.Parameters.AddWithValue("$price", basePrice);
            command.Parameters.AddWithValue("$userId", userId);
            command.ExecuteNonQuery();
        }
    }
}