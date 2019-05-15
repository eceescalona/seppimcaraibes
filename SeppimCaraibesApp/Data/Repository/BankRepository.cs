namespace SeppimCaraibesApp.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class BankRepository
    {
        public ORM.Bank GetBank(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return context.Banks.Find(code);
        }

        public void AddBank(ORM.SeppimCaraibesLocalEntities context, ORM.Bank bank)
        {
            context.Banks.Add(bank);
            context.SaveChanges();
            context.Entry(bank).Reload();
        }

        public void EditBank(ORM.SeppimCaraibesLocalEntities context, ORM.Bank bank)
        {
            context.SaveChanges();
            context.Entry(bank).Reload();
        }

        public void DeleteBank(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var bank = context.Banks.Find(code);
            context.Banks.Remove(bank);
            context.SaveChanges();
        }
    }
}
