using System.Collections.Generic;

namespace ResearchRecordingSystem
{
    public class ResearchBook
    {
        public int ThesisTitleId { get; set; }
        public string Title { get; set; }
        public string PublishedYear { get; set; }
        public string Remarks { get; set; }
        public string CourseNameRb { get; set; }
        public string NumberOfCopies { get; set; }

        public virtual Borrow Borrower { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        //public ICollection<Course> Course { get; set; }
    }
}