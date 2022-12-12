namespace HiPlatformApp
{
    public class House
    {
        public Street? Street { get; set; }
        public int Number { get; set; }
        public int TotalVoters { get; set; }
    }

    public class Street
    {
        public string? CEP { get; set; }
        public string? Name { get; set; }
    }

    public class StreetData
    {
        public Street? Street { get; set; }
        public int Voters { get; set; }
    }
}