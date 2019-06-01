using System.Data.Entity;

namespace ResearchRecordingSystem
{
    internal class RRSDbInitializer : CreateDatabaseIfNotExists<RRSContext>
    {
    }
}