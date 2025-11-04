// File: Data/DbInitializer.cs
using AppraisalAppV1.Data;
using AppraisalAppV1.Models;

namespace AppraisalAppV1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppraisalContext context)
        {
            // Look for any employees.
            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
                new Employee{AppraiseeNumber="00012345", Name="John Smith", Department="Engineering", Designation="Software Engineer", RequestDate=DateTime.Now.ToShortDateString(), PeriodCoveredFrom="1/1/2024"},
                new Employee{AppraiseeNumber="00054321", Name="Jane Doe", Department="Human Resources", Designation="HR Manager", RequestDate=DateTime.Now.ToShortDateString(), PeriodCoveredFrom="1/1/2024"},
                new Employee{AppraiseeNumber="00098765", Name="Bob Johnson", Department="Marketing", Designation="Marketing Specialist", RequestDate=DateTime.Now.ToShortDateString(), PeriodCoveredFrom="1/1/2024"},
            };

            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();
        }
    }
}