using EncodeDecodeLib.Interfaces;

namespace EncodeDecodeLib.Abstraction
{
    public abstract class CoderDecoderAbstract : IСoder
    {
        public abstract string Decode(string textToDecode);

        public abstract string Encode(string textToEncode);
    }
}
