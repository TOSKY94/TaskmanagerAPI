using System;
namespace Taskmanager.Models
{
    public class Todo
    {
        public int id { get; set; }
        public string name { get; set; } = String.Empty;
        public string description { get; set; } = String.Empty;
        public string status { get; set; } = String.Empty;
        public DateTime createDate { get; set; }
        public DateTime dueDate { get; set; }

    }
}

