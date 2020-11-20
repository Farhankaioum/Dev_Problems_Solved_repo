namespace Problem_1_Solution
{
    public interface IRepository
    {
        void AddNode(string nodeName);
        void AddNode(string nodeName, string leafNodeName);
        void AddNode(string nodeName, string leafNodeName, string leafNodeValue);
        void RemoveNode(string removeNodeName);
        void RemoveNode(string nodeName, string removeNodeName);
        string GetInneHTML(string nodeName);
        string GetInneHTML(string nodeName, string baseNodeName);
        string GetHTML(string nodeName);
        string GetHTML(string nodeName, string baseNodeName);
    }
}
