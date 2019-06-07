﻿namespace SeppimCaraibesApp.Data.Repository
{
    using System;

    internal class OrderRepository
    {
        public ORM.Order GetOrder(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return context.Orders.Find(code);
        }

        public void AddOrder(ORM.SeppimCaraibesLocalEntities context, ORM.Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
            context.Entry(order).Reload();
        }

        public void SetProviderOrder(ORM.SeppimCaraibesLocalEntities context, string code, ORM.Provider provider)
        {
            var order = context.Orders.Find(code);
            order.ProviderId = provider.ProviderId;
            context.SaveChanges();
            context.Entry(order).Reload();
        }

        public void EditOrder(ORM.SeppimCaraibesLocalEntities context, ORM.Order order)
        {
            context.SaveChanges();
            context.Entry(order).Reload();
        }

        public void DeleteOrder(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var order = context.Orders.Find(code);
            context.Orders.Remove(order);
            context.SaveChanges();
        }
    }
}
