namespace Family_Tree
{
    public class Person
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public List<Person> Children { get; set; } = new List<Person>();
        public List<Person> Parents { get; set; } = new List<Person>();
    }
}