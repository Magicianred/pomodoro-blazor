using System;

namespace PomodoroBlazor.Domain
{
    public class PomodoroTask
    {
        public string Description { get; set; }
        public DateTime StartTime {get; set;}
        public bool Completed {get; set;}
    
    }
}