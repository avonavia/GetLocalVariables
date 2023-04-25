using GetMyLocalVariables;
using System;

namespace Reflection15042023
{
    class Program
    {
        static void Main()
        {
            Person person = new Person();
            person.ID = 1;
            person.Name = "aaa";

            Person person2 = new Person();
            person.ID = 2;
            person.Name = "aaaa";


            Animal a1 = new Animal();

            foreach (var i in LocalVariables.GetLocalVariables<Person>())
            {
                Console.WriteLine(i);
            }
        }
    }
}
