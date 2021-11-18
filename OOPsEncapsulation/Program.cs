using System;

namespace OOPsEncapsulation
{
   
    class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
    class Details
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = "10";
            employee.Name = "Roopa";
            employee.City = "Kalaburagi";

            Console.WriteLine("Employee Id: " + employee.Id);
            Console.WriteLine("Employee Name: " + employee.Name);
            Console.WriteLine("Employee City: " + employee.City);
        }
    }
}
