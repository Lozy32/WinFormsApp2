using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2.Models
{
    public class ActionLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserLogin { get; set; } = "";
        public string ActionType { get; set; } = "";  
        public string EntityName { get; set; } = "";  
        public string Details { get; set; } = "";
        public string CreatedAt { get; set; } = "";
    }
}