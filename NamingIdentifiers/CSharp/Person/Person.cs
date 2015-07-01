namespace Person
{
    using System.Text;

    public class Person
    {
        public Person(Sex sex, string name, int age)
        {
            this.Sex = sex;
            this.Name = name;
            this.Age = age;
        }

        public Sex Sex { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendFormat("Name: {0}, Sex: {1}, Age: {2}", this.Name, this.Sex, this.Age);

            return result.ToString();
        }
    }
}
