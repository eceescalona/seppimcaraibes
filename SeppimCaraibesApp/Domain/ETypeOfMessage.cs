namespace SeppimCaraibesApp.Domain
{
    using System.ComponentModel;

    internal enum ETypeOfMessage
    {
        [Description("Error")]
        Error,
        [Description("Información")]
        Information,
        [Description("Advertencia")]
        Warning
    }
}
