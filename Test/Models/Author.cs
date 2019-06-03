namespace ResearchRecordingSystem
{
    public class Author
    {

        public int AuthorId { get; internal set; }
        public string AuthorName { get; set; }
        //public string AuthorLName { get; set; }
        //public string AuthorMName { get; set; }
        public string Gender { get; set; }
        public string AuthorContactNumber { get; set; }

        public int? ThesisTitleId { get; set; }
        public virtual ResearchBook ResearchBook { get; set; }

        //public ICollection<ResearchBook> ResearchBooks { get; set; }
    }
}