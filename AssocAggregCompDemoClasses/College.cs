using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssocAggregCompDemoClasses
{
    public class College
    {
        public College() 
        {
            Departments = new List<Department>();
        }

        public string Name { get; set; }

        public List<Department> Departments { get; private set; } 

        /// <summary>
        /// Add a department
        /// </summary>
        /// <param name="departmentId"></param>
        /// <param name="departmentName"></param>
        public void AddDepartment(int departmentId, string departmentName)
        {
            Department dep = new Department();
            dep.Id = departmentId;
            dep.Name = departmentName;
            Departments.Add(dep);
        }

        /// <summary>
        /// Get the departments of a College
        /// </summary>
        /// <returns></returns>
        public List<Department> GetDepartments()
        {
            return Departments;
        }

        /// <summary>
        /// Add instructors into a college department. The instructors does not compose a department. The department has instructors
        /// Instructors are independant of departments
        /// </summary>
        /// <param name="departmentId"></param>
        /// <param name="instructors"></param>
        public void AddInstructors(int departmentId, List<Instructor> instructors)
        {
            Department myDepartment = null;

            foreach (Department dep in Departments)
            {
                if(dep.Id == departmentId)
                {
                    myDepartment = dep;
                }
            }

            if(myDepartment != null)
            {
                myDepartment.Instructors = instructors;
            }
        }

        /// <summary>
        /// College details to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"College: { this.Name }\n");
            sb.Append("................\n");

            //Foreach loop for the departments in the College
            foreach(Department d in this.Departments)
            {
                sb.Append(d.ToString());
            }

            sb.Append("................\n");

            return sb.ToString();
        }
    }
}
