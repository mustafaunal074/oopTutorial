namespace Ders13_Deconstruct
{
    class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Mustafa",
                Age = 23
            };
            var(name,age) = person;
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out string name,out int age)
        {
            name = Name;
            age = Age;
        }
    }
}