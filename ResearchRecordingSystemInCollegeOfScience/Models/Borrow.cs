using System;

namespace ResearchRecordingSystemInCollegeOfScience
{
    public class Borrow
    {

        public int BorrowerId { get; internal set; }
        public string BFullName { get; set; }
        public string BContactNumber { get; set; }
        public DateTime? BookBorrowedDate { get; set; }
        public DateTime? DateWillRetrun { get; set; }
        public int NoOfBookBorrowed { get; set; }

        public int? ThesisTitleId { get; set; }
        public virtual ResearchBook ResearchBook { get; set; }
    }
}