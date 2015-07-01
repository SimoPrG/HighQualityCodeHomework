using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class PersonTester
    {
        public static void Main()
        {
            var personFactory = new PersonFactory();

            var mary = personFactory.CreatePerson(25);
            Console.WriteLine(mary);

            var bill = personFactory.CreatePerson(26);
            Console.WriteLine(bill);
        }
    }
}
