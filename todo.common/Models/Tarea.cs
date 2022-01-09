using System;

namespace todo.common.Models
{
    public class Tarea
    {
        public DateTime CreatedTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }
    }
}
