using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp2.Models;
using Microsoft.Data.Sqlite;

namespace WinFormsApp2.Data
{
    public class PatientRepository
    {
        public List<Patient> GetAll(string searchText = "")
        {
            var patients = new List<Patient>();

            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                command.CommandText = "SELECT Id, FullName, BirthDate, Phone FROM Patients ORDER BY FullName";
            }
            else
            {
                command.CommandText = @"
                    SELECT Id, FullName, BirthDate, Phone 
                    FROM Patients 
                    WHERE FullName LIKE $search 
                    ORDER BY FullName";
                command.Parameters.AddWithValue("$search", $"%{searchText}%");
            }

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                patients.Add(new Patient
                {
                    Id = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                    BirthDate = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    Phone = reader.IsDBNull(3) ? "" : reader.GetString(3)
                });
            }
            return patients;
        }

        public void Add(Patient patient)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
        INSERT INTO Patients (FullName, BirthDate, Phone)
        VALUES ($fullName, $birthDate, $phone)";
            command.Parameters.AddWithValue("$fullName", patient.FullName);
            command.Parameters.AddWithValue("$birthDate", patient.BirthDate);
            command.Parameters.AddWithValue("$phone", patient.Phone);
            command.ExecuteNonQuery();
        }

        public void Update(Patient patient)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
                UPDATE Patients 
                SET FullName = $fullName, BirthDate = $birthDate, Phone = $phone
                WHERE Id = $id";
            command.Parameters.AddWithValue("$id", patient.Id);
            command.Parameters.AddWithValue("$fullName", patient.FullName);
            command.Parameters.AddWithValue("$birthDate", patient.BirthDate);
            command.Parameters.AddWithValue("$phone", patient.Phone);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Patients WHERE Id = $id";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }
    }
}