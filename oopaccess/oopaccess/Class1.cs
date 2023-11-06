using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopaccess
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Person person = new.Person();
            Console.Write(person.Name);
            Console.WriteLine(person.LastName);

            Console.WriteLine(person.PopulationCount);
                
        }
    }
}
