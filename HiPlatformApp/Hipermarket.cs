namespace HiPlatformApp
{
    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double PurchaseCost { get; set; }
        public double VolumeInCentimeter { get; set; }
        public bool Refrigerated { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public int ValiditInDays { get; set; }

        private readonly double ProfitPercentage = 70.5;
        private readonly double RefrigerationTax = 1.25;
        private readonly double CostPerCubicCentimeter = 0.02;

        public double MagicFomula()
        {
            var expirationDate = ManufacturingDate.AddDays(ValiditInDays);
            var daysToExpiration = (expirationDate.Subtract(DateTime.Now)).Days;

            double profit = PurchaseCost * ProfitPercentage;
            double refrigerationTax = daysToExpiration * RefrigerationTax;
            double volumeCost = VolumeInCentimeter * CostPerCubicCentimeter;

            double price = PurchaseCost + profit + refrigerationTax + volumeCost;

            return price;
        }
    }
}