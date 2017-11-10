using Ders.Entity;
using System;
using Ders.MockDataBase;
using System.Collections.Generic;

namespace Ders.Business
{
    public class PersonManager
    {
        public void Add(Person person)
        {
            Phonebook.People.Add(person);
        }
        public void Add(IEnumerable<Person> people)
        {
            Phonebook.People.AddRange(people);
        }
        public void Remove(Person person)
        {
            Phonebook.People.Remove(person);
        }

        public  Person  SearchByName(string name,string surname)
        {
            foreach (Person person in Phonebook.People)
            {
                if (name==person.Name && surname==person.Surname)
                {
                    return person;
                } 
            }
            return null;
        }

        private int personCount;

        public int PersonCount  //sadece okunmasını istiyorum. phonebook içerisindeki people ın countunu dönsün diyorum
        {
            get { return Phonebook.People.Count; } 
        }

    }
}
