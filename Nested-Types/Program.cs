using System;


namespace Nested_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine(e1.Employeeinsurance.CompanyName);
          
            Console.ReadKey();
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Insurance Employeeinsurance { get; set; }

        public Employee() => Employeeinsurance = new Insurance { PloicyId = -1, CompanyName = "N/A" };


        public class Insurance
        {
            public int PloicyId { get; set; }
            public string CompanyName { get; set; }
        }
    }

    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }



}
