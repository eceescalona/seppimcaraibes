namespace SeppimCaraibesApp.Data.Repository
{
    using System.Threading.Tasks;

    internal class ProviderRepository
    {
        public async Task<ORM.Provider> GetProvider(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return await context.Providers.FindAsync(code);
        }

        public void AddProvider(ORM.SeppimCaraibesLocalEntities context, ORM.Provider provider)
        {
            context.Providers.Add(provider);
            context.SaveChanges();
            context.Entry(provider).Reload();
        }

        public void EditProvider(ORM.SeppimCaraibesLocalEntities context, ORM.Provider provider)
        {
            context.Providers.Add(provider);
            context.Entry(provider).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            context.Entry(provider).Reload();
        }

        public async void DeleteProvider(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var provider = await context.Providers.FindAsync(code);
            context.Providers.Remove(provider);
            context.SaveChanges();
        }
    }
}
