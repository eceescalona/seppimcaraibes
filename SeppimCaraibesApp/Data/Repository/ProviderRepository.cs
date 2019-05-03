namespace SeppimCaraibesApp.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ProviderRepository
    {
        public ORM.Provider GetProvider(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return context.Providers.Find(code);
        }

        public void AddProvider(ORM.SeppimCaraibesLocalEntities context, ORM.Provider provider)
        {
            context.Providers.Add(provider);
            context.SaveChanges();
        }

        public void EditProvider(ORM.SeppimCaraibesLocalEntities context, ORM.Provider provider)
        {
            context.SaveChanges();
        }

        public void DeleteProvider(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var provider = context.Providers.Find(code);
            context.Providers.Remove(provider);
            context.SaveChanges();
        }
    }
}
