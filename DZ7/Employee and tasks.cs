using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    internal class Employee_and_tasks
    {
        public string Name { get; set; }
        public List<Employee_and_tasks> Subordinates { get; } = new List<Employee_and_tasks>();
        public bool CanReceiveTasks { get; set; }
        public List<string> Tasks { get; } = new List<string>();

        public Employee_and_tasks(string name)
        {
            Name = name;
            CanReceiveTasks = false;
        }

        public void AssignTask(string task, Employee_and_tasks employee)
        {
            if (CanAssignTaskTo(employee))
            {
                employee.Tasks.Add(task);
                Console.WriteLine($"{Name} может отправить задание '{task}' данному сотруднику: {employee.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} не может отправить задание {employee.Name}");
            }
        }

        public bool CanAssignTaskTo(Employee_and_tasks employee)
        {
            if (Subordinates.Contains(employee) || this == employee)
                return true;

            foreach (var subordinate in Subordinates)
            {
                if (subordinate.CanAssignTaskTo(employee))
                    return true;
            }

            return false;
        }
    }
}
