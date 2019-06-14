using System.Collections.Generic;

namespace ResearchRecordingSystemInCollegeOfScience
{
    public class Course
    {
        public int CourseId { get; internal set; }
        public string CourseName { get; set; }
        public bool IsActive { get; set; }


        public virtual ICollection<Classifacation> Classifacations { get; set; }

        //public int? ThesisTitleId { get; set; }
        //public virtual ResearchBook ResearchBook { get; set; }
        //public ICollection<ResearchBook> ResearchBooks { get; set; }
    }
}