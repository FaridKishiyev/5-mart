using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models
{
    class Department
    {
        private int _id;
        public int Id { get; }
        public string Name { get; set; }
        List<Employee> employee;

        public Department(string name)
        {
            _id++;
            Id = _id;
            Name = name;
            employee = new List<Employee>();
        }

        public void AddEmployee(Employee employe)
        {
            employee.Add(employe);
        }

        public Employee this[int i]
        {
            get { return employee[i];}
            set { employee[i] = value;} 
        }

    }
}
