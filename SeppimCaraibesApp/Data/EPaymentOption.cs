namespace SeppimCaraibesApp
{
    using System.ComponentModel;

    internal enum EPaymentOption : byte
    {
        [Description("Transferencia Bancaria")]
        WireTransfer = 1,
        [Description("Carta de Crédito")]
        CreditLetter = 2,
        [Description("Carta de Crédito Financiado")]
        FinacedCreditLetter = 3
    }
}
