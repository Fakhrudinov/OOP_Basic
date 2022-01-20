namespace EncodeDecodeLib.Interfaces
{
    public interface IСoder
    {
        string Encode(string textToEncode);
        string Decode(string textToDecode);
    }
}
