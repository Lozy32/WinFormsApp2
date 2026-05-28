using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string Specialization { get; set; } = "";
        public decimal BasePrice { get; set; }
        public int? UserId { get; set; }
    }
}