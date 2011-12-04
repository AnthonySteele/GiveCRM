namespace GiveCRM.DummyDataGenerator.Data
{
    public class StreetPrefixItem
    {
        public string Prefix { get; private set; }
        public int Frequency { get; private set; }

        public StreetPrefixItem(string prefix, int frequency)
        {
            this.Prefix = prefix;
            this.Frequency = frequency;
        }

        public override string ToString()
        {
            return Prefix;
        }
    }
}
