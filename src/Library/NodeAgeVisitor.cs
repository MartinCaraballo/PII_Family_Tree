namespace Library
{
    public class NodeAgeVisitor : Visitor
    {
        public override int VisitAge(Family family)
        {
            foreach (var item in family.Persons)
            {
                sumaTotal += item.Person.Age;
            }
            return sumaTotal;
        }
        
    }
}