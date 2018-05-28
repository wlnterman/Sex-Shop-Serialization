using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Pattern
{
    public interface ICompressor
    {
        string Name { get; }

        string Format { get; }

        void Compress(string inputFile, string outputFile);

        void Decompress(string inputFile, string outputFile);
    }
}
