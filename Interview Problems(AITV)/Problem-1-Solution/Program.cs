using System;
namespace Problem_1_Solution
{
    public interface IAddHtmlTag : IRepository
    {

    }
    public class AddHtmlTag : Repository, IAddHtmlTag
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            var addHtmlTag = new AddHtmlTag();
            addHtmlTag.AddNode("h1");
            addHtmlTag.RemoveNode("h1");
            Console.WriteLine(addHtmlTag.GetHTML("h2")); ;
            Console.WriteLine(addHtmlTag.GetHTML("p", "h2")); ;
            Console.WriteLine(addHtmlTag.GetInneHTML("h2")); ;
            
        }
    }
}
