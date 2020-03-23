using System;
using System.Linq;
using System.Threading;

namespace Scenariul5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Inherited_hierarchy_Model())
{
                var fte = new FullTimeEmployee
                {
                    FirstName = "Jane",
                    LastName =
                "Doe",
                    Salary = 71500M
                };
                context.Employees.Add(fte);
                fte = new FullTimeEmployee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Salary = 62500M
                };
                context.Employees.Add(fte);
                var hourly = new HourlyEmployee
                {
                    FirstName = "Tom",
                    LastName =
                "Jones",
                    Wage = 8.75M
                };

                context.Employees.Add(hourly);
                context.SaveChanges();
            }
            using (var context = new Inherited_hierarchy_Model())
{
                Console.WriteLine("--- All Employees ---");
                foreach (var emp in context.Employees)
                {
                    bool fullTime = emp is HourlyEmployee ? false : true;
                    Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName,
                    fullTime ? "Full Time" : "Hourly");
                }
                Console.WriteLine("--- Full Time ---");
                foreach (var fte in context.Employees.OfType<FullTimeEmployee>())
                {
                    Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName);
                }
                Console.WriteLine("--- Hourly ---");
                foreach (var hourly in context.Employees.OfType<HourlyEmployee>())
                {
                    Console.WriteLine("{0} {1}", hourly.FirstName,
                    hourly.LastName);
                }
            }

            Thread.Sleep(3000);
        }
    }
}
