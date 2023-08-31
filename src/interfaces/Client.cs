using EMAKE_API.src.client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMAKE_API.src.interfaces
{
    public class Module
    {
        public string Name { get; }

        public Client client { get; }
    }
    interface LogOptions 
    {
        string Message { get; }
        Array Tags { get; }
    }
}
