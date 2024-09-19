using employee_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;

namespace employee_data_json_format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee designation:");
            string designation = Console.ReadLine();

            Console.WriteLine("Enter employee salary:");
             int salary = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee
            {
                Id = id,
                Name = name,
                Designation = designation,
                Salary = salary
            };
           
            string path = @"D:\EQ SOFT\C#\employeedata.json";
            string jsonString = JsonSerializer.Serialize(employee);
            File.WriteAllText(path, jsonString);
            Console.WriteLine("\nEmployee details have been successfully saved to " + path);
            string readJson = File.ReadAllText(path);
            Employee readEmployee = JsonSerializer.Deserialize<Employee>(readJson);

            Console.WriteLine("\nContent read from file:");
            Console.WriteLine($"Employee ID: {readEmployee.Id}");
            Console.WriteLine($"Employee Name: {readEmployee.Name}");
            Console.WriteLine($"Employee Designation: {readEmployee.Designation}");
            Console.WriteLine($"Employee Salary: {readEmployee.Salary}");
            Console.ReadLine();
        }
    }
}
