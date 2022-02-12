using System;

namespace EmployeePayRollService_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Welcome TO Employee PayRoll Services Using ADO.NET----------");
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.GetDataFromSql();

        }
    }
}
