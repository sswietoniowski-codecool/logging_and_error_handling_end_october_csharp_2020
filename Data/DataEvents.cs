using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace logging.Data
{
    public class DataEvents
    {
        public static EventId GetAllProducts = new EventId(10001, "GetAllProducts");
    }
}
