using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResearchRecordingSystem
{
    public class Borrow
    {
        [ForeignKey("ResearchBook")]
        public int BorrowerId { get; internal set; }
        public string BFullaName { get; set; }
        public string BContactNumber { get; set; }
        public DateTime BookBorrowedDate { get; set; }
        public DateTime BookReturnedDate { get; set; }

        public virtual ResearchBook ResearchBook { get; set; }
    }
}