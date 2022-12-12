namespace HiPlatformApp
{
    public class HouseService
    {
        public static List<Street> OrderStreetsByVoters(List<House> houses)
        {
            Dictionary<string, StreetData> map = new Dictionary<string, StreetData>();

            foreach (House house in houses)
            {
                if (house.Street?.CEP != null)
                {
                    if (map.ContainsKey(house.Street.CEP))
                    {
                        map[house.Street.CEP].Voters += house.TotalVoters;
                    }
                    else
                    {
                        map[house.Street.CEP] = new StreetData()
                        {
                            Street = house.Street,
                            Voters = house.TotalVoters
                        };
                    }
                }
            }

            var sortedItems = from streetData in map
                         orderby
                         streetData.Value.Voters ascending
                         select streetData.Value.Street;

            return sortedItems.ToList();
        }
    }
}