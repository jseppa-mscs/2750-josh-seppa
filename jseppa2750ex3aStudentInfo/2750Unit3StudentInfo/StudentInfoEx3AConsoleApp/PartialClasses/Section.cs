using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Section
    {
        public Section(int id, int capacity, Course course, Term term, Assignment assignment, Enrollment enrollment)
        {
            this.Enrollments = new HashSet<Enrollment>();
            this.Assignments = new HashSet<Assignment>();
            this.Id = id;
            this.Capacity = capacity;
            this.Course = course;
            this.Term = term;
            this.Assignments = Assignments;
            this.Enrollments = Enrollments;
            course.Sections.Add(this);
        }
        public Section(int id, int capacity, Course course, Term term)
        {
            this.Id = id;
            this.Capacity = capacity;
            this.Course = course;
            this.Term = term;
            course.Sections.Add(this);
        }
    }
}
