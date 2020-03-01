using Jdenticon;
using System.IO;

namespace Identicon.Algorithms
{
    public class IdenticonAlgorithm
    {
        public byte[] CreateIdenticon(string seed, int size)
        {
            var icon = Jdenticon.Identicon.FromValue(seed, size: size);
            icon.SaveAsPng("image.png");
            byte[] img = File.ReadAllBytes("image.png");
            return img;
        }
    }
}
