using System.Collections.Generic;

namespace ResearchRecordingSystemInCollegeOfScience
{
    public class ResearchBook
    {
        public int ThesisTitleId { get; set; }
        public string Title { get; set; }
        public string PublishedYear { get; set; }
        public string Remarks { get; set; }
        public string CourseNameRb { get; set; }
        public int NumberOfCopies { get; set; }
        public string AbstractEcopy { get; set; }
        public string ApprovalSheetEcopy { get; set; }
        public string Cataloging { get; set; }
        public string Classification { get; set; }



        public virtual ICollection<Borrow> Borrower { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        //public ICollection<Course> Course { get; set; }
    }
}