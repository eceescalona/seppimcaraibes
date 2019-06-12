namespace SeppimCaraibesApp.Data.Repository
{
    using System.Threading.Tasks;

    internal class BankRepository
    {
        public async Task<ORM.Bank> GetBank(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return await context.Banks.FindAsync(code);
        }

        public void AddBank(ORM.SeppimCaraibesLocalEntities context, ORM.Bank bank)
        {
            context.Banks.Add(bank);
            context.SaveChanges();
            context.Entry(bank).Reload();
        }

        public void EditBank(ORM.SeppimCaraibesLocalEntities context, ORM.Bank bank)
        {
            context.Banks.Add(bank);
            context.Entry(bank).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            context.Entry(bank).Reload();
        }

        public async void DeleteBank(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var bank = await context.Banks.FindAsync(code);
            context.Banks.Remove(bank);
            context.SaveChanges();
        }
    }
}
