using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyBL.Controller
{
    public class EmployeeController : BaseController
    {
        public EmployeeController() { }

        public void HireEmp(Employee employee, List<Skill> skills, Vacansy vacansy)
        {
            manager.HireEmp(employee, skills, vacansy);
        }

        public List<Employee> UpdateEmp()
        {
            return db.Employees.ToList();
        }

        public void Fire(Employee employee)
        {
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        public void GetSkills()
        {






            //List<Skill> ski = new List<Skill>();

            //Employee emp = new Employee();
            //emp.Id = 21;



            //List<string> names = new List<string>();

            //ski.AddRange(db.Skills())


            //ski.AddRange(db.Skills);
            //emp.AddRange(db.Employees);

            //names.Add()

        }
    }
}
