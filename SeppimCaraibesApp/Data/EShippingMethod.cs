namespace SeppimCaraibesApp
{
    using System.ComponentModel;

    internal enum EShippingMethod : byte
    {
        [Description("Transporte Aéreo")]
        AirTransport = 1,
        [Description("Transporte Marítimo")]
        MaritimeTransportation = 2
    }
}
