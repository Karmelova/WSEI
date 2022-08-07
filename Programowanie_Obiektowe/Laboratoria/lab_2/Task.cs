using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Task : IEquatable<Task>
    {
        private string name;
        private TaskStatus status;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public TaskStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public override string ToString()
        {
            return $"{name} [{status}]";
        }

        public bool Equals(Task other)
        {
            throw new NotImplementedException();
        }
    }
}