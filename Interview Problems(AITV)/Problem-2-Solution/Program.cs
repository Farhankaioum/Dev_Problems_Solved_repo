using System;
using System.Collections.Generic;

namespace Problem_2_Solution
{
    public interface ICompression
    {
        void SetData(string data);
        string DoCompression();
    }

    public class Compression : ICompression
    {
        private readonly IApplication _application;

        public Compression(IApplication application)
        {
            _application = application;
        }

        public string DoCompression()
        {
            
            var compressData = "one.zip";
            SetData(compressData);

            return "";
        }

        public void SetData(string data)
        {
            _application.Compress(data);
        }
    }

    public interface IApplication
    {
        void AddCompressionAlgorithm(CompressionAlgorithm algorithm);
        CompressionAlgorithm SelectCurrentAlgorithm(string id);
        void OpenFile(string fileName);
        void Compress(string fileName);
    }

    public class Application : IApplication
    {
        private List<CompressionAlgorithm> _compressionList = new List<CompressionAlgorithm>();

        public Application()
        {
            _compressionList.Add(new CompressionAlgorithm { 
                Id = "1",
                AlgorithmName = "SHA-512"
            });

            _compressionList.Add(new CompressionAlgorithm
            {
                Id = "2",
                AlgorithmName = "MD-5"
            });


            _compressionList.Add(new CompressionAlgorithm
            {
                Id = "3",
                AlgorithmName = "SHA-1024"
            });
        }

        public void AddCompressionAlgorithm(CompressionAlgorithm algorithm)
        {
            _compressionList.Add(algorithm);
        }

        public void Compress(string fileName)
        {
            var selectedAlgorithm = SelectCurrentAlgorithm("5");
            OpenFile(fileName);
            Console.WriteLine($"Compressing the {fileName} using {selectedAlgorithm} algorithm...");
        }

        public void OpenFile(string fileName)
        {
            Console.WriteLine($"File opening in location: {fileName}");
        }

        public CompressionAlgorithm SelectCurrentAlgorithm(string id)
        {
            return _compressionList.Find(a => a.Id == id);
        }
    }

    public class CompressionAlgorithm
    {
        public string Id { get; set; }
        public string AlgorithmName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IApplication application = new Application();
            ICompression compression = new Compression(application);

            Console.WriteLine(compression.DoCompression());
        }
    }
}
