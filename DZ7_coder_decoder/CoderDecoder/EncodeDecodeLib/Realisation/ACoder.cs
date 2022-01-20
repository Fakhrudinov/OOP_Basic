using EncodeDecodeLib.Abstraction;

namespace EncodeDecodeLib.Realisation
{
    public sealed class ACoder : CoderDecoderAbstract
    {
        public sealed override string Decode(string textToDecode)
        {
            string result = "";

            foreach (char chr in textToDecode)
            {
                result = result + Convert.ToChar(Convert.ToInt32(chr) - 1);
            }

            return result;
        }

        public sealed override string Encode(string textToEncode)
        {
            string result = "";

            foreach (char chr in textToEncode)
            {
                result = result + Convert.ToChar(Convert.ToInt32(chr) + 1);
            }

            return result;
        }
    }
}
