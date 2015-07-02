using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace ProjectTrackingServices.Models
{
    public class EmployeesRepository
    {
        private static readonly ProjectTrackingDBEntities Db= new ProjectTrackingDBEntities();

        //public static IList<Employee> GetAllEmployees()
        //{
        //    return Db.Employees.ToList();
        //}

        public static List<Employee> GetAllEmployees()
        {
            var query = from employee in Db.Employees
                        select employee;
            return query.ToList();
        }

        public static Employee GetEmployee(int id)
        {
            return Db.Employees.SingleOrDefault(x => x.EmployeeID == id);
        }

        public IList<Employee> SearchEmployeesByName(string serchedName)
        {
            return Db.Employees.Where(x => x.EmployeeName.Contains(serchedName)).ToList();
        }

        public static IList<Employee> InsertEmployee(Employee e)
        {
            Db.Employees.Add(e);
            Db.SaveChanges();
            return GetAllEmployees();
        }

        public static IList<Employee> UpdateEmployee(Employee e)
        {
            var employee = Db.Employees.SingleOrDefault(x => x.EmployeeID==e.EmployeeID);
            if (employee != null)
            {
                employee.EmployeeID = e.EmployeeID;
                employee.EMailID = e.EMailID;
                employee.Designation = e.Designation;
                employee.ContactNo = e.ContactNo;
                employee.SkillSets = e.SkillSets;
                employee.ManagerID = e.ManagerID;
                employee.ProjectTasks = e.ProjectTasks;
            }

            Db.SaveChanges();
            return GetAllEmployees();
         }

        public static IList<Employee> DeleteEmployee(int id)
        {
            var emp = Db.Employees.Find(id);
            Db.Employees.Remove(emp);
            Db.SaveChanges();
            return GetAllEmployees();

        }
    }
}