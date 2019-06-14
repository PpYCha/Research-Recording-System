using System.Data.Entity;

namespace ResearchRecordingSystemInCollegeOfScience
{
    internal class RRSDbInitializer : CreateDatabaseIfNotExists<RRSContext>
    {
    }
}