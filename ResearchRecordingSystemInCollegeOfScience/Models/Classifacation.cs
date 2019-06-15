using System.Collections.Generic;

namespace ResearchRecordingSystemInCollegeOfScience
{
    public class Classifacation
    {
        public int ClassificationId { get; internal set; }
        public string ClassificationName { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

       
    }
}
