namespace Person
{
    public class PersonFactory
    {
        public Person CreatePerson(int magicNumber)
        {
            Person person;

            if (magicNumber % 2 == 0)
            {
                person = new Person(Sex.Male, "Bill", magicNumber);
            }
            else
            {
                person = new Person(Sex.Female, "Mary", magicNumber);
            }

            return person;
        }
    }
}
