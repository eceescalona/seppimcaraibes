namespace SeppimCaraibesApp.Data.POCO
{
    internal class TotalSales
    {
        public string Customer { get; set; }
        public string Provider { get; set; }
        public double TotalSale { get; set; }
        public decimal TotalBuy { get; set; }
        public double Earnings { get; set; }
        public double Margin { get; set; }
    }
}
