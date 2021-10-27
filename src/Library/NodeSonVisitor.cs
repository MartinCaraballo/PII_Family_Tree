namespace Library
{
    public class NodeSonVisitor : Visitor
    {
        public override int VisitAge(Family family)
        {
            int result = 0;
            foreach (var item in family.Persons)
            {
                if (item.Person.Age > result)
                {
                    result = item.Person.Age;
                }
            }
            return result;
        }
    }
}