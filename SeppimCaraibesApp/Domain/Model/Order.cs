namespace SeppimCaraibesApp.Domain.Model
{
    using System.Collections.Generic;
    using System.Linq;

    internal class Order
    {
        public Data.ORM.Order GetOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rOrder = new Data.Repository.OrderRepository();
            var order = rOrder.GetOrder(context, code);

            if (order != null)
            {
                if (context.ProductsOrders.Any(po => po.OrderId == order.OrderId))
                {
                    order.ProductsOrders = context.ProductsOrders.Where(po => po.OrderId == order.OrderId).ToList();
                }

                if (context.Shipments.Any(s => s.ShipmentId == order.OrderId))
                {
                    order.Shipment = context.Shipments.SingleOrDefault(s => s.ShipmentId == order.OrderId);
                }
            }

            return order;
        }

        public IEnumerable<Data.POCO.OrderReportView> GetOrderReportView(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var reports = new List<Data.POCO.OrderReportView>();
            var products = new List<Data.POCO.ProductsOrders>();
            var rOrder = new Data.Repository.OrderRepository();
            var order = rOrder.GetOrder(context, code);
            var bank = context.Banks.SingleOrDefault(b => b.BankId == order.BankId);
            var shipment = context.Shipments.SingleOrDefault(s => s.ShipmentId == order.OrderId);
            var customer = context.Customers.SingleOrDefault(c => c.CustomerId == order.CustomerId);
            var provider = context.Providers.SingleOrDefault(p => p.ProviderId == order.ProviderId);

            var quote = new Data.POCO.OrderReportView
            {
                OrderCode = order.OrderId,
                Date = order.Date,
                OfferPeriod = order.OfferPeriod,
                Period = order.Period,
                ProviderReference = order.ProviderReference,
                ProviderName = provider == null ? string.Empty : provider.ProviderName,
                ProviderPhone = provider == null ? string.Empty : provider.ProviderPhone,
                CustomerReference = order.CustomerReference,
                CustomerName = customer == null ? string.Empty : customer.CustomerName,
                CustomerAddress = customer == null ? string.Empty : customer.CustomerAddress,
                CustomerPhone = customer == null ? string.Empty : customer.CustomerPhone,
                PaymentOption = order.PaymentOption,
                ShippingMethod = shipment?.ShippingMethod,
                Devise = order.Devise,
                IncotermsType = order.IncotermType,
                Incoterm = order.Incoterm,
                EXW = order.EXW,
                Freight = order.Freight,
                Inspection = order.Inspection,
                Insurance = order.Insurance,
                TotalDiscount = order.TotalDiscount,
                ToltalInterests = order.ToltalInterests,
                TotalCost = order.TotalCost,
                GrossWeight = shipment?.GrossWeight,
                NetWeight = shipment?.NetWeight,
                Packing = shipment == null ? string.Empty : shipment.Packing,
                PlaceOfDeparture = shipment == null ? string.Empty : shipment.PlaceDeparture,
                Observations = order.Observations,
                DocRequired = order.DocRequired,
                ContractDescription = order.ContractDescription,
                BankName = bank == null ? string.Empty : bank.BankName,
                AccountNumber = bank == null ? string.Empty : bank.AccountNumber,
                AccountName = bank == null ? string.Empty : bank.AccountName,
                InvoiceReference = order.InvoiceReference
            };

            foreach (var productOrder in order.ProductsOrders)
            {
                var product = new Data.POCO.ProductsOrders
                {
                    ProductId = productOrder.Product.ProductId,
                    ProductName = productOrder.Product.ProductName,
                    Qty = productOrder.Qty,
                    Discount = productOrder.Discount,
                    Interests = productOrder.Interests,
                    UnitPrice = context.Products.SingleOrDefault(p => p.ProductId == productOrder.ProductId)?.UnitPrice
            };

            products.Add(product);
        }

        quote.Products = products;

            reports.Add(quote);
            return reports;
        }

    public void AddOrder(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Order order, List<Data.POCO.ProductsOrders> productsOrdersViews)
    {
        var rOrder = new Data.Repository.OrderRepository();
        if (!context.Orders.Any(o => o.OrderId == order.OrderId))
        {
            foreach (var product in productsOrdersViews)
            {
                var productOrder = new Data.ORM.ProductsOrder
                {
                    OrderId = order.OrderId,
                    ProductId = product.ProductId,
                    Qty = product.Qty,
                    Discount = product.Discount,
                    Interests = product.Interests
                };

                order.ProductsOrders.Add(productOrder);
            }

            rOrder.AddOrder(context, order);
        }
    }

    public void SetProviderOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code, Data.ORM.Provider provider)
    {
        var rOrder = new Data.Repository.OrderRepository();
        rOrder.SetProviderOrder(context, code, provider);
    }

    public void EditOrder(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Order order)
    {
        var rOrder = new Data.Repository.OrderRepository();

        rOrder.EditOrder(context, order);
    }

    public void EditOrder(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Order order, List<Data.POCO.ProductsOrders> productsOrdersViews)
    {
        var rOrder = new Data.Repository.OrderRepository();

        var productsOrders = new List<Data.ORM.ProductsOrder>();
        foreach (var product in productsOrdersViews)
        {
            var productOrder = new Data.ORM.ProductsOrder
            {
                OrderId = order.OrderId,
                ProductId = product.ProductId,
                Qty = product.Qty,
                Discount = product.Discount,
                Interests = product.Interests
            };

            productsOrders.Add(productOrder);
        }

        if (order.Shipment != null)
        {
            var rShipment = new Data.Repository.ShipmentRepository();
            if (!context.Shipments.Any(s => s.ShipmentId == order.Shipment.ShipmentId))
            {
                rShipment.AddShipment(context, order.Shipment);
            }
        }
        else
        {
            order.Shipment = context.Shipments.SingleOrDefault(s => s.ShipmentId == order.OrderId);
        }

        order.ProductsOrders = productsOrders;

        rOrder.EditOrder(context, order);
    }

    public void EditOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code, EOrderProcessState orderProcessState)
    {
        var rOrder = new Data.Repository.OrderRepository();

        var order = rOrder.GetOrder(context, code);
        order.OrderProcessState = orderProcessState;

        if (orderProcessState == EOrderProcessState.Invoice)
        {
            order.InvoiceState = EInvoiceState.InProcess;
        }

        rOrder.EditOrder(context, order);
    }

    public void EditOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code, EInvoiceState invoiceState)
    {
        var rOrder = new Data.Repository.OrderRepository();

        var order = rOrder.GetOrder(context, code);
        order.InvoiceState = invoiceState;

        rOrder.EditOrder(context, order);
    }

    public void DeleteOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code)
    {
        var rOrder = new Data.Repository.OrderRepository();
        rOrder.DeleteOrder(context, code);
    }
}
}
