namespace SeppimCaraibesApp.Domain.Model
{
    using System.Linq;

    internal class Bank
    {
        public int GetIdBank(Data.ORM.SeppimCaraibesLocalEntities context, string bankName, string bankAddress)
        {
            return context.Banks.SingleOrDefault(b => b.BankName == bankName && b.BankAddress == bankAddress).BankId;
        }

        public void AddBank(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Bank bank)
        {
            var rBank = new Data.Repository.BankRepository();
            if (!context.Banks.Any(b => b.BankName == bank.BankName && b.BankAddress == bank.BankAddress))
            {
                rBank.AddBank(context, bank);
            }
        }
    }
}