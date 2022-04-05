using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models
{
    class Employee
    {
        private int _id;
        public int Id { get; }
        public string  Name { get; set; }
        public double Salary { get; set; }
        public Employee(string name)
        {
            _id++;
            Id = _id;
            Name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nSalary: {Salary}");
        }

    }
}
