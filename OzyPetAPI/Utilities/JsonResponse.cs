using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OzyPetAPI.Utilities
{
    public class JsonResponse : IDisposable
    {
        public string status { get; set; }
        public string message { get; set; }
        public dynamic data { get; set; }
        public void Dispose() { }
    }
}
