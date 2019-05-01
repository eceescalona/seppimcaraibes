namespace SeppimCaraibesApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
