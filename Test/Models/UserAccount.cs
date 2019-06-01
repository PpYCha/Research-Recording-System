namespace ResearchRecordingSystem
{
    public class UserAccount
    {
        public int UserId { get; internal set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string UserRole { get; set; }
        public bool IsActive { get; set; }

    }
}