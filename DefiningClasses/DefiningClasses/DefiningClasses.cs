namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for(int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();

                //Person person = new Person();

                //person.Name = parts[0];
                //person.Age = int.Parse(parts[1]);

                //family.AddMember(person);

                family.AddMember(parts[0], int.Parse(parts[1]));

            }

            Person oldest = family.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
            
            /*
            Person person = new Person();
            person.Name = name; 
            person.Age = age;


            var pesho = new Person("Pesho", 20);
            var pesho2 = new Person
            {
                Name = "Pesho",
                Age= 20,
            };



            var gosho = new Person("Gosho", 18);
            var stamat = new Person("Stamat", 43);
            */

        }
    }
}