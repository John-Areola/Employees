using Bank.Models;


namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EmployeesContext())
            {
                var Emp = new employee() { firstName = "Bill" };
                ctx.Employees.Add(employee);
                ctx.SaveChanges();
            }
        }
    }
}