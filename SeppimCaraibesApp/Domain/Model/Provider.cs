namespace SeppimCaraibesApp.Domain.Model
{
    using System.Linq;
    using System.Threading.Tasks;

    internal class Provider
    {
        public async Task<Data.ORM.Provider> GetProvider(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rProvider = new Data.Repository.ProviderRepository();
            return await rProvider.GetProvider(context, code);
        }

        public void AddProvider(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Provider provider)
        {
            var rProvider = new Data.Repository.ProviderRepository();
            if (!context.Providers.Any(p => p.ProviderId == provider.ProviderId))
            {
                rProvider.AddProvider(context, provider);
            }
        }

        public void EditProvider(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Provider provider)
        {
            var rProvider = new Data.Repository.ProviderRepository();
            rProvider.EditProvider(context, provider);
        }

        public void DeleteProvider(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rProvider = new Data.Repository.ProviderRepository();
            rProvider.DeleteProvider(context, code);
        }
    }
}
