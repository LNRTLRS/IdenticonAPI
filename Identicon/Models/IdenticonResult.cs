using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identicon.Models
{
    public class IdenticonResult
    {
        public byte[] Identicon { get; set; }
        public int Size { get; set; }
    }
}
