using System.Collections.Generic;
namespace Library
{
    public class Family
    {
        public List<Node> Persons = new List<Node>();

        public void AddIntegrant(Node node)
        {
            this.Persons.Add(node);
        }

    }
}