namespace SeppimCaraibesApp.Data.POCO
{
    using System.Collections.Generic;

    internal class AccountReceivable
    {
        public string Customer { get; set; }
        public string Provider { get; set; }
        public Dictionary<string, double> OrderIdTotalByOrder { get; set; }
        public double Total { get; set; }
    }
}
