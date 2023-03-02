using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssocAggregCompDemoClasses;

namespace AssocAggregCompDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            College college = new College();
            college.Name = "NBCC Moncton";

            college.AddDepartment(1, "IT");
            college.AddDepartment(2, "Engineering");

            List<Instructor> itInstructors = new List<Instructor>();
            List<Instructor> engInstructors = new List<Instructor>();

            itInstructors.Add(new Instructor() { Name = "Andre Boudreau" });
            itInstructors.Add(new Instructor() { Name = "Chris Cusack" });
            itInstructors.Add(new Instructor() { Name = "Boonie Ryuan" });

            engInstructors.Add(new Instructor() { Name = "Richard Logan" });
            engInstructors.Add(new Instructor() { Name = "Ryan Colpist" });

            Console.WriteLine("IT Instructors");
            Console.WriteLine();
            foreach (var inst in itInstructors)
            {
                Console.WriteLine(inst.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Engineering Instructors");
            Console.WriteLine();

            foreach (var inst in engInstructors)
            {
                Console.WriteLine(inst.Name);
            }

            Console.WriteLine();
            //Console.ReadKey();

            // This is how we inserted the instructors to the departments
            college.AddInstructors(1, itInstructors);
            college.AddInstructors(2, engInstructors);

            var departments = college.GetDepartments();
            
            foreach(var dep in departments)
            {
                Console.WriteLine(dep.ToString());
            }

            Console.WriteLine("Re instantiate a new College");
            // This means that we are re instatiate a new college and since the departments exist inside the 
            // College, it will be "re set"
            college = new College();

            Console.WriteLine($"Department Count: {college.Departments.Count}");

            foreach (var dep in college.Departments)
            {
                Console.WriteLine(dep.ToString());
            }

            Console.WriteLine("The instructors still intact");

            Console.WriteLine("IT Instructors");
            Console.WriteLine();
            foreach (var inst in itInstructors)
            {
                Console.WriteLine(inst.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Engineering Instructors");
            Console.WriteLine();

            foreach (var inst in engInstructors)
            {
                Console.WriteLine(inst.Name);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
