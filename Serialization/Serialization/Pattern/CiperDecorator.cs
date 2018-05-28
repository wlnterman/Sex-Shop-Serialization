using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serialization.Pattern
{
    public class CipherDecorator : Decorator
    {
        private const int MAX = byte.MaxValue + 1;

        public override string Name => "Ciphered " + base.Name;

        public override string Format => base.Format + "Ci";

        public CipherDecorator(ICompressor compressor) : base(compressor) { }

        public override void Compress(string inputFile, string outputFile)
        {
            Cipher(inputFile);
            base.Compress(inputFile, outputFile);
        }

        public override void Decompress(string inputFile, string outputFile)
        {
            base.Decompress(inputFile, outputFile);
            DeCipher(outputFile);
        }

        private void Cipher(string inputFile)
        {
            byte[] bytes = File.ReadAllBytes(inputFile);

            for (int i = 0; i < bytes.Length; i++)
            {
                int value = bytes[i] + i;
                bytes[i] = (byte)(value % MAX);
            }

            File.WriteAllBytes(inputFile, bytes);
        }

        private void DeCipher(string outputFile)
        {
            byte[] bytes = File.ReadAllBytes(outputFile);

            for (int i = 0; i < bytes.Length; i++)
            {
                int value = bytes[i] + MAX * (i / MAX + 1) - i;
                bytes[i] = (byte)value;
            }

            File.WriteAllBytes(outputFile, bytes);
        }
    }
}
