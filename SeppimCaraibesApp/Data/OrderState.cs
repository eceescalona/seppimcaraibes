using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeppimCaraibesApp.Data
{
    internal enum OrderState : byte
    {
        InProcess = 1,
        Canceled = 2,
        Finished = 3
    }
}
