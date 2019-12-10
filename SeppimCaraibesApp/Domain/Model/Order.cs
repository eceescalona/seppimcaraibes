namespace SeppimCaraibesApp.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;

    internal class Order
    {
        private string GetEnumDescription(Enum value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            FieldInfo fielInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] descriptionAttributes = (DescriptionAttribute[])fielInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (descriptionAttributes != null && descriptionAttributes.Length > 0)
            {
                return descriptionAttributes[0].Description;
            }
            else
            {
                return string.Empty;
            }
        }


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

        public string GetLastOrderID(Data.ORM.SeppimCaraibesLocalEntities context)
        {
            var rOrder = new Data.Repository.OrderRepository();

            return rOrder.GetLastOrderID(context);
        }

        public string GetLastInvoiceID(Data.ORM.SeppimCaraibesLocalEntities context)
        {
            var rOrder = new Data.Repository.OrderRepository();

            return rOrder.GetLastInvoiceID(context);
        }

        public IEnumerable<Data.POCO.OrderReportView> GetOrderReportView(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var reports = new List<Data.POCO.OrderReportView>();
            var products = new List<Data.POCO.ProductsOrdersReports>();
            var rOrder = new Data.Repository.OrderRepository();

            var order = rOrder.GetOrder(context, code);
            var bank = context.Banks.SingleOrDefault(b => b.BankId == order.BankId);

            var shipment = context.Shipments.SingleOrDefault(s => s.ShipmentId == order.OrderId);
            var customer = context.Customers.SingleOrDefault(c => c.CustomerId == order.CustomerId);
            var provider = context.Providers.SingleOrDefault(p => p.ProviderId == order.ProviderId);

            var paymentOption = GetEnumDescription(order.PaymentOption);
            var shippingMethod = GetEnumDescription(shipment?.ShippingMethod);

            var data = new Data.POCO.OrderReportView
            {
                OrderCode = order.OrderId,
                Date = order.Date,
                OfferPeriod = order.OfferPeriod,
                Period = order.Period,
                BigingDate = order.BigingDate,
                EndDate = order.EndDate,
                DeliveryTime = order.DeliveryTime,
                ProviderReference = order.ProviderReference,
                ProviderName = provider == null ? string.Empty : provider.ProviderName,
                ProviderPhone = provider == null ? string.Empty : provider.ProviderPhone,
                ProviderAddress = provider == null ? string.Empty : provider.ProviderAddress,
                CustomerReference = order.CustomerReference,
                CustomerName = customer == null ? string.Empty : customer.CustomerName,
                CustomerAddress = customer == null ? string.Empty : customer.CustomerAddress,
                CustomerPhone = customer == null ? string.Empty : customer.CustomerPhone,
                PaymentOption = paymentOption,
                ShippingMethod = shippingMethod,
                Devise = order.Devise,
                IncotermsType = order.IncotermType,
                EXW = order.EXW == null ? 0 : order.EXW,
                Freight = order.Freight == null ? 0 : order.Freight,
                Inspection = order.Inspection == null ? 0 : order.Inspection,
                Insurance = order.Insurance == null ? 0 : order.Insurance,
                TotalDiscount = order.TotalDiscount == null ? 0 : order.TotalDiscount,
                ToltalInterests = order.ToltalInterests == null ? 0 : order.ToltalInterests,
                TotalCost = order.TotalCost,
                GrossWeight = shipment?.GrossWeight,
                NetWeight = shipment?.NetWeight,
                PlaceOfDeparture = shipment == null ? string.Empty : shipment.PlaceDeparture,
                Observations = order.Observations,
                DocRequired = order.DocRequired,
                ContractDescription = order.ContractDescription,
                BankName = bank == null ? string.Empty : bank.BankName,
                AccountNumber = bank == null ? string.Empty : bank.AccountNumber,
                AccountName = bank == null ? string.Empty : bank.AccountName,
                Swift = bank == null ? string.Empty : bank.Swift,
                InvoiceReference = order.InvoiceReference,
                Expenses = order.Expenses == null ? 0 : order.Expenses,
                ExpensesType = order.ExpensesType,
                PackingDescription = shipment == null ? string.Empty : shipment.PackingDesciption,
                BankAddress = bank == null ? string.Empty : bank.BankAddress,
                PaymentsTerms = order.PaymentsTerms
            };

            order.ProductsOrders = context.ProductsOrders.Where(po => po.OrderId == order.OrderId).ToList();
            foreach (var productOrder in order.ProductsOrders)
            {
                var product = new Data.POCO.ProductsOrdersReports
                {
                    ProductId = productOrder.ProductId,
                    ProductName = context.Products.SingleOrDefault(p => p.ProductId == productOrder.ProductId)?.ProductName,
                    Qty = productOrder.Qty,
                    UnitPrice = context.Products.SingleOrDefault(p => p.ProductId == productOrder.ProductId)?.UnitPrice,
                    CustomsCode = context.Products.SingleOrDefault(p => p.ProductId == productOrder.ProductId)?.CustomsCode,
                    Origin = context.ProductsViews.SingleOrDefault(p => p.Product_Code == productOrder.ProductId)?.Acronyms,
                    SalePrice = productOrder.Discount
                };

                products.Add(product);
            }

            data.Products = products;

            reports.Add(data);
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
                        Discount = product.SalePrice
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
                    Discount = product.SalePrice
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

        public bool EditOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code, EOrderProcessState orderProcessState)
        {
            var rOrder = new Data.Repository.OrderRepository();

            var order = rOrder.GetOrder(context, code);

            if (string.IsNullOrWhiteSpace(order.ProviderId))
            {
                return false;
            }
            else
            {
                order.OrderProcessState = orderProcessState;
            }

            if (orderProcessState == EOrderProcessState.Invoice)
            {
                order.InvoiceState = EInvoiceState.InProcess;
            }

            rOrder.EditOrder(context, order);

            return true;
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
