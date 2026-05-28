using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string BirthDate { get; set; } = "";
        public string Phone { get; set; } = "";
    }
}
