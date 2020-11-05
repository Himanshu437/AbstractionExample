using System;
using System.Net.Http.Headers;

namespace AbstractionExample
{
    class Program
    {
        public abstract class Person
        {
            public void canWalk()
            {
                Console.WriteLine("Yes I can walk");
            }
            public abstract void canSpeak();
           
        }
        public class American : Person
        {
            public American()
            {
                Console.WriteLine("American Class :");
            }
            public override void canSpeak()
            {
                Console.WriteLine("Yes I can speak English");
            }
        }
        public class Indian : Person
        {
            public Indian()
            {
                Console.WriteLine("Indian Class :");
            }
            public override void canSpeak()
            {
                Console.WriteLine("Yes I can speak Hindi");
            }
        }
        public class French : Person
        {
            public French()
            {
                Console.WriteLine("French Class :");
            }
            public override void canSpeak()
            {
                Console.WriteLine("Yes I can speak French");
            }
        }
        static void Main(string[] args)
        {
            American a = new American();
            a.canWalk();
            a.canSpeak();
            Indian b = new Indian();
            b.canWalk();
            b.canSpeak();
            French c = new French();
            c.canWalk();
            c.canSpeak();

        }
    }
}
