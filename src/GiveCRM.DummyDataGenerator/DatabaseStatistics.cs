namespace GiveCRM.DummyDataGenerator
{
    internal class DatabaseStatistics
    {
        private readonly int numberOfMembers;
        private readonly int numberOfCampaigns;
        private readonly int numberOfSearchFilters;
        private readonly int numberOfDonations;

        public int NumberOfMembers { get { return numberOfMembers; } }
        public int NumberOfCampaigns { get { return numberOfCampaigns; } }
        public int NumberOfSearchFilters { get { return numberOfSearchFilters; } }
        public int NumberOfDonations { get { return numberOfDonations; } }

        public DatabaseStatistics(int numberOfMembers, int numberOfCampaigns, int numberOfSearchFilters, int numberOfDonations)
        {
            this.numberOfMembers = numberOfMembers;
            this.numberOfCampaigns = numberOfCampaigns;
            this.numberOfSearchFilters = numberOfSearchFilters;
            this.numberOfDonations = numberOfDonations;
        }
    }
}
