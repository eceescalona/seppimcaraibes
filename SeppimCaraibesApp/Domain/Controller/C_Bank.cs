namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;

    internal class C_Bank : IDisposable
    {
        private readonly Data.ORM.SeppimCaraibesLocalEntities _context;
        private readonly Model.Bank _mBank;


        public C_Bank()
        {
            _mBank = new Model.Bank();
            _context = new Data.ORM.SeppimCaraibesLocalEntities();
        }


        #region IDisposable
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion


        private bool Validate(Data.ORM.Bank bank, out Dictionary<string, string> fields)
        {
            fields = new Dictionary<string, string>();
            bool flag = true;
            string message;
            string field;

            if (string.IsNullOrWhiteSpace(bank.BankName))
            {
                flag = false;
                field = "nameTE";
                message = "El Campo Nombre no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(bank.BankAddress))
            {
                flag = false;
                field = "addressTE";
                message = "El Campo Dirección no puede ser vacío.";
                fields.Add(field, message);
            }

            return flag;
        }


        public Data.ORM.SeppimCaraibesLocalEntities GetContext()
        {
            return _context;
        }

        public string GetEnumDescription(Enum value)
        {
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


        #region BankManage
        public void AddBank(IAddEditBank addEditBank, Data.ORM.Bank bank, out int idBank)
        {
            string message = string.Format("El banco {0} ha sido registrado satisfactoriamente.", bank.BankName);

            if (Validate(bank, out Dictionary<string, string> fields))
            {
                _mBank.AddBank(_context, bank);
                addEditBank.ShowMessage(ETypeOfMessage.Information, message);
                idBank = _mBank.GetIdBank(_context, bank.BankName, bank.BankAddress);
            }
            else
            {
                addEditBank.ShowFieldsWithError(fields);
                idBank = -1;
            }
        }
        #endregion
    }
}