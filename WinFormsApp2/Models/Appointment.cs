using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = "";
        public int DoctorId { get; set; }
        public string DoctorName { get; set; } = "";
        public string AppointmentDate { get; set; } = "";
        public string VisitType { get; set; } = "";  
        public decimal FinalPrice { get; set; }
    }
}
