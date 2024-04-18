using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagementApplication.Project
{
    public class Project
    {
        public string Name { get; set; }
        public List<Task> TaskList { get; set; }
        public int Time { get; set; }

        public Project(string name, int time)
        {
            Name = name;
            Time = time;
            TaskList = new List<Task>();
        }

        public void AddTask(Task task)
        {
            TaskList.Add(task);
        }

        public void RemoveTask(Task task)
        {
            TaskList.Remove(task);
        }
    }

}

