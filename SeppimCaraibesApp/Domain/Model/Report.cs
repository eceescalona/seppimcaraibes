namespace SeppimCaraibesApp.Domain.Model
{
    using System;
    using System.Collections.Generic;

    internal class Report
    {
        public IEnumerable<Data.POCO.TotalSales> GetTotalSales(Data.ORM.SeppimCaraibesLocalEntities context,EPeriod period)
        {
            var totalSales = new List<Data.POCO.TotalSales>();

            if (period <= 0)
            {
                foreach (var item in context.TotalSalesViews)
                {
                    var total = new Data.POCO.TotalSales
                    {
                        Customer = item.Customer,
                        Provider = item.Provider,
                        TotalSale = (double)item.Total_Sale,
                        TotalBuy = (decimal)item.Total_Buy,
                        Earnings = (double)item.Earnings,
                        Margin = (double)item.Margin
                    };

                    totalSales.Add(total);
                }
            }
            else if(period == EPeriod.quarterly)
            {
                var date = DateTime.Today.AddMonths(-3);
                foreach (var item in context.TotalSalesViews)
                {
                    if (item.Date >= date)
                    {
                        var total = new Data.POCO.TotalSales
                        {
                            Customer = item.Customer,
                            Provider = item.Provider,
                            TotalSale = (double)item.Total_Sale,
                            TotalBuy = (decimal)item.Total_Buy,
                            Earnings = (double)item.Earnings,
                            Margin = (double)item.Margin
                        };

                        totalSales.Add(total);
                    }
                }
            }
            else if (period == EPeriod.biannual)
            {
                var date = DateTime.Today.AddMonths(-6);
                foreach (var item in context.TotalSalesViews)
                {
                    if (item.Date >= date)
                    {
                        var total = new Data.POCO.TotalSales
                        {
                            Customer = item.Customer,
                            Provider = item.Provider,
                            TotalSale = (double)item.Total_Sale,
                            TotalBuy = (decimal)item.Total_Buy,
                            Earnings = (double)item.Earnings,
                            Margin = (double)item.Margin
                        };

                        totalSales.Add(total);
                    }
                }
            }
            else if (period == EPeriod.annual)
            {
                var date = DateTime.Today.AddYears(-1);
                foreach (var item in context.TotalSalesViews)
                {
                    if (item.Date >= date)
                    {
                        var total = new Data.POCO.TotalSales
                        {
                            Customer = item.Customer,
                            Provider = item.Provider,
                            TotalSale = (double)item.Total_Sale,
                            TotalBuy = (decimal)item.Total_Buy,
                            Earnings = (double)item.Earnings,
                            Margin = (double)item.Margin
                        };

                        totalSales.Add(total);
                    }
                }
            }

            return totalSales;
        }
    }
}
