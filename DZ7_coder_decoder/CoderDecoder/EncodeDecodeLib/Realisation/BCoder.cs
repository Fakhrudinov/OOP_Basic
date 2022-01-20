using EncodeDecodeLib.Abstraction;
using EncodeDecodeLib.CodeTables;

namespace EncodeDecodeLib.Realisation
{
    public sealed class BCoder : CoderDecoderAbstract
    {
        public sealed override string Decode(string textToDecode)
        {
            string result = "";

            foreach (char chr in textToDecode)
            {
                bool isFoundedInTable = false;

                foreach (string codeTable in CodeTable.CodeTables)
                {
                    if (codeTable.Contains(chr))
                    {
                        result = result + GetSymbolFromCodeTable(codeTable, chr);
                        isFoundedInTable = true;
                        break;
                    }
                }

                if (!isFoundedInTable)
                {
                    result = result + chr;
                }
            }

            return result;
        }

        public sealed override string Encode(string textToEncode)
        {
            string result = "";

            foreach (char chr in textToEncode)
            {
                bool isFoundedInTable = false;

                foreach (string codeTable in CodeTable.CodeTables)
                {
                    if (codeTable.Contains(chr))
                    {
                        result = result + GetSymbolFromCodeTable(codeTable, chr);
                        isFoundedInTable = true;
                    }
                }

                if (!isFoundedInTable)
                {
                    result = result + chr;
                }
            }

            return result;
        }

        private char GetSymbolFromCodeTable(string codeTable, char chr)
        {
            return codeTable[codeTable.Length - (codeTable.IndexOf(chr) + 1)];
        }
    }
}
