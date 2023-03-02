using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssocAggregCompDemoClasses
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Instructor> Instructors { get; set; }

        public Department() { }
        
        /// <summary>
        /// Write the department details
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Department: {this.Name}\n");
            sb.Append("................\n");

            //Foreach loop for the instructors in the department
            if(this.Instructors != null)
            {
                foreach(Instructor ins in this.Instructors)
                {
                    sb.Append($"\t{ins.Name}\n");
                }
            }

            sb.Append("................\n");

            return sb.ToString();
        }
    }
}
