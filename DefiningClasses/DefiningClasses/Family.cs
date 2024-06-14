using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        List<Person> people = new List<Person>();

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public void AddMember(string name, int age)
        {
            Person p = new Person()
            {
                Name = name,
                Age = age
            };

            this.people.Add(p);
        }

        public Person GetOldestMember()
        {
            Person result = null;

            foreach(Person item in people)
            {
                if(result == null)
                {
                    result = item;            
                }
                else if(result.Age < item.Age)
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
