using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_OOP_28._5
{
    internal class Task
    {
        public string? Title { get; set; }
        public string? Status { get; set; }
        public DateTime Time { get; set; }
        public string? Priority { get; set; }

        public Task(string? title, DateTime time, string? priority)
        {
            Title = title;            
            Time = time;
            Priority = priority;
            Status = "Не выполнено";
        }
    }
}
