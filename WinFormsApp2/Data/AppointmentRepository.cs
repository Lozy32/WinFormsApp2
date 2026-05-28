using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp2.Models;

namespace WinFormsApp2.Data
{
    public class AppointmentRepository
    {
        public List<Appointment> GetAll(int? doctorId = null)
        {
            var appointments = new List<Appointment>();

            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();

            string sql = @"
                SELECT a.Id, a.PatientId, p.FullName as PatientName, 
                       a.DoctorId, d.FullName as DoctorName, 
                       a.AppointmentDate, a.VisitType, a.FinalPrice
                FROM Appointments a
                JOIN Patients p ON p.Id = a.PatientId
                JOIN Doctors d ON d.Id = a.DoctorId";

            if (doctorId.HasValue)
                sql += " WHERE a.DoctorId = $doctorId";

            sql += " ORDER BY a.AppointmentDate";

            command.CommandText = sql;
            if (doctorId.HasValue)
                command.Parameters.AddWithValue("$doctorId", doctorId.Value);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                appointments.Add(new Appointment
                {
                    Id = reader.GetInt32(0),
                    PatientId = reader.GetInt32(1),
                    PatientName = reader.GetString(2),
                    DoctorId = reader.GetInt32(3),
                    DoctorName = reader.GetString(4),
                    AppointmentDate = reader.GetString(5),
                    VisitType = reader.GetString(6),
                    FinalPrice = reader.GetDecimal(7)
                });
            }
            return appointments;
        }

        public void Add(Appointment appointment)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Appointments (PatientId, DoctorId, AppointmentDate, VisitType, FinalPrice)
                VALUES ($patientId, $doctorId, $date, $visitType, $price)";
            command.Parameters.AddWithValue("$patientId", appointment.PatientId);
            command.Parameters.AddWithValue("$doctorId", appointment.DoctorId);
            command.Parameters.AddWithValue("$date", appointment.AppointmentDate);
            command.Parameters.AddWithValue("$visitType", appointment.VisitType);
            command.Parameters.AddWithValue("$price", appointment.FinalPrice);
            command.ExecuteNonQuery();
        }

        public void Update(Appointment appointment)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
                UPDATE Appointments 
                SET PatientId = $patientId, DoctorId = $doctorId, 
                    AppointmentDate = $date, VisitType = $visitType, FinalPrice = $price
                WHERE Id = $id";
            command.Parameters.AddWithValue("$id", appointment.Id);
            command.Parameters.AddWithValue("$patientId", appointment.PatientId);
            command.Parameters.AddWithValue("$doctorId", appointment.DoctorId);
            command.Parameters.AddWithValue("$date", appointment.AppointmentDate);
            command.Parameters.AddWithValue("$visitType", appointment.VisitType);
            command.Parameters.AddWithValue("$price", appointment.FinalPrice);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Appointments WHERE Id = $id";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }
    }
}