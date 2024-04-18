using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagementApplication.TaskService
{
    internal class Task
    {
        public String Title { get; set; }

        public String Description { get; set; }

        public Task(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
