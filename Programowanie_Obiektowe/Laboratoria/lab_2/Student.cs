using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Student : Person, IEquatable<Student>
    {
        protected string group;
        protected List<Task> tasks;

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;
            this.tasks = new List<Task>();
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
        }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            tasks.Add(new Task(taskName, taskStatus));
        }

        public void RemoveTask(int index)
        {
            tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            tasks[index].Status = taskStatus;
        }

        public string RenderTasks(string prefix = "\t")
        {
            string s = "";
            int i = 1;
            foreach (Task t in tasks)
            {
                s += $"{prefix}{i}. {t}\n ";
                i++;
            }
            return s;
        }

        public override string ToString()
        {
            string s = $"Student: {name} ({age} y.o.)\nGroup: {group}\nTasks:\n";
            s += RenderTasks();
            s += "\n";
            return s;
        }

        public bool Equals(Student other)
        {
            if (this.name == other.name && this.age == other.age)
                return true;
            else return false;
        }

        private bool SequenceEqual<T>(List<T> a, List<T> b)
        {
            if (a == null && b == null)
                return false;
            return a.SequenceEqual(b);
        }
    }
}