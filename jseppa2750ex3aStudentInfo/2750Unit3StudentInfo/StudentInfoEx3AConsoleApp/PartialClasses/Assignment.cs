using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Assignment
    {
        public Assignment(int id, string assign, string description, short maxPoints, DateTime dueDate, AssignmentTypesEnum type, Section section)
        {
            this.AssignmentGrades = new HashSet<AssignmentGrade>();
            this.Id = id;
            this.Assign = assign;
            this.Description = description;
            this.MaxPoints = maxPoints;
            this.DueDate = dueDate;
            this.Type = type;
            this.Section = section;
            section.Assignments.Add(this);

        }

        public AssignmentGrade FindAssignmentGrade(int Id)
        {
            //return this.Courses.Find(g.Enrollment.Id == enrollmentId);
            AssignmentGrade foundAssignmentGrade = null;

            foreach (AssignmentGrade g in this.AssignmentGrades)
            {
                if (g.Id == Id)
                {
                    foundAssignmentGrade = g;
                    break;
                }
            }
            return foundAssignmentGrade;
        }
    }
}