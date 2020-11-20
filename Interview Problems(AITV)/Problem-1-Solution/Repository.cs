using System;
using System.Text;

namespace Problem_1_Solution
{
    public abstract class Repository : IRepository
    {
        public virtual void AddNode(string nodeName)
        {
            Console.WriteLine($"{nodeName} Node added inside body");
        }

        public virtual void AddNode(string nodeName, string leafNodeName)
        {
            Console.WriteLine($"{leafNodeName} Node added inside {nodeName}");
        }

        public virtual void AddNode(string nodeName, string leafNodeName, string leafNodeValue)
        {
            Console.WriteLine($"{leafNodeName} Node added inside {nodeName} with value {leafNodeValue}");
        }

        public virtual void RemoveNode(string removeNodeName)
        {
            Console.WriteLine($"{removeNodeName} Node remove from body");
        }

        public virtual void RemoveNode(string nodeName, string removeNodeName)
        {
            Console.WriteLine($"{removeNodeName} Node remove from {nodeName}");
        }

        public virtual string GetHTML(string nodeName)
        {
            return $"<{nodeName}> </{nodeName}>";
        }

        public virtual string GetHTML(string nodeName, string baseNodeName)
        {
            var htmlBuilder = new StringBuilder();
            htmlBuilder.Append($"<{baseNodeName}>");
            htmlBuilder.Append("\n");
            htmlBuilder.Append("    ");
            htmlBuilder.Append($"<{nodeName}> </{nodeName}>");
            htmlBuilder.Append("\n");
            htmlBuilder.Append($"</{baseNodeName}>");

            return htmlBuilder.ToString();
        }

        public virtual string GetInneHTML(string nodeName)
        {
            return $"value of {nodeName} = one";
        }

        public virtual string GetInneHTML(string nodeName, string baseNodeName)
        {
            return $"value  {baseNodeName} of {nodeName} = One";
        }
    }
}
