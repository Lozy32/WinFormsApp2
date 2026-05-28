using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string PasswordSalt { get; set; } = "";
        public string FullName { get; set; } = "";
        public bool IsActive { get; set; }
        public string RoleName { get; set; } = "";
        public int RoleId { get; set; }
    }
}