using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person juan = new Person("Juan", 65);
            Person carlos = new Person("Carlos", 18);
            Person joaquin = new Person("Joaquín", 22);
            Person rodrigo = new Person("Rodrigo", 35);
            Person martin = new Person("Martín", 18);
            Person pablo = new Person("Pablo", 23);
            Person mario = new Person("Mario", 32);
            Person santiago = new Person("Santiago", 34);
            Family family = new Family();
            Node n1 = new Node(juan);
            Node n2 = new Node(carlos);
            Node n3 = new Node(joaquin);
            Node n4 = new Node(rodrigo);
            Node n5 = new Node(martin);
            Node n6 = new Node(pablo);
            Node n7 = new Node(mario);
            Node n8 = new Node(santiago);
            family.AddIntegrant(n1);
            family.AddIntegrant(n2);
            family.AddIntegrant(n3);
            family.AddIntegrant(n4);
            family.AddIntegrant(n5);
            family.AddIntegrant(n6);
            family.AddIntegrant(n7);
            family.AddIntegrant(n8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol 
            NodeAgeVisitor visitor = new NodeAgeVisitor();
            Console.WriteLine($"La suma de las edades es: {visitor.VisitAge(family)}");
            
        }
    }
}
