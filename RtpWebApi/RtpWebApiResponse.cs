using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RtpWebApi
{
    public class RtpWebApiResponse
    {
        public IEnumerable<Object> data;
        public string error;
        public int count;
    }
}
