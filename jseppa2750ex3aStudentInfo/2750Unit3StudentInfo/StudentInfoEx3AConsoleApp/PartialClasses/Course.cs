using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Course
    {
        public Course(int id, String courseNum, String courseTitle, short credits, Department department)
        {
            this.Sections = new HashSet<Section>();
            this.Id = id;
            this.CourseNum = courseNum;
            this.CourseTitle = courseTitle;
            this.Credits = credits;
            this.Department = department;
            department.Courses.Add(this);
        }

        public Section FindSection(int id)
        {
            // based on sectionId
            Section foundSection = null;
            foreach (Section c in this.Sections)
            {
                if (c.Id == id)
                {
                    foundSection = c;
                    break;
                }
            }
            return foundSection;
        }
    }
}
