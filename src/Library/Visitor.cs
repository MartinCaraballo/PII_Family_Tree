namespace Library
{
    public abstract class Visitor
    {
        protected int sumaTotal{ get; set; } = 0;
        public abstract int VisitAge(Family family);

    }
}