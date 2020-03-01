using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identicon.Models;

namespace Identicon.Mappers
{
    public class Mapper
    {
        public static IdenticonResult Map(byte[] image, int size)
        {
            IdenticonResult result = new IdenticonResult
            {
                Identicon = image,
                Size = size
            };
            return result;
        }
    }
}
