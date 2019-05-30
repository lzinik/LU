using PersonRepository.Entities;
using PersonRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonValidator
{
    public class SolucionBasic : IPersonRepositoryBasic
    {
        
        public List<Person> People { get; set; }

        public bool emailValido (string email)
        {
            return EmailValidator.IsValidEmail(email);
        }
        public void Add(Person person)
        {
            bool validToAdd = true;
            foreach(Person p in People)
            {
                validToAdd = validToAdd && ( p.Id != person.Id );
            }

            validToAdd = validToAdd && ( (person.Age > 0 ) && (emailValido(person.Email)) );

            if (validToAdd)
                People.Add(person);
        }

        public void Delete(int id)
        {
            // People.RemoveAll(p => p.Id == id);
            People = People.Where(p => p.Id != id).ToList();
        }

        public int GetCountRangeAges(int min, int max)
        {
            List<Person> PersonasEnRangoDeEdades = People.FindAll( p => (( min <= p.Age ) && ( p.Age <= max )) );
            return PersonasEnRangoDeEdades.Count();
        }

        public List<Person> GetFiltered(string name, int age, string email)
        {
            List<Person> FilteredPeople = People;

            if(name != null && name != "" )
                FilteredPeople = FilteredPeople.FindAll( p => p.Name == name);
            
            if (age != 0)
                FilteredPeople = FilteredPeople.FindAll( p => p.Age == age);
            
            if (email != null && email != "")
                FilteredPeople = FilteredPeople.FindAll( p => p.Email.Contains(email));
                
            return FilteredPeople;
        }

        public Person GetPerson(int Id)
        {
            return People.Find(p => p.Id == Id);
        }

        public void Update(Person person)
        {
            Person pToUpdate = People.Find(p => p.Id == person.Id);
            if (pToUpdate != null && person.Age > 0 && emailValido(person.Email))
            {
                pToUpdate.Name = person.Name;
                pToUpdate.Age = person.Age;
                pToUpdate.Email = person.Email;
            }
        }
    }

}