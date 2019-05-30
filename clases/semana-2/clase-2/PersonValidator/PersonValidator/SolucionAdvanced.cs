using System;
using System.Collections.Generic;
using PersonRepository.Entities;
using PersonRepository.Interfaces;

namespace PersonValidator
{
    public class SolucionAdvanced : SolucionBasic, IPersonRepositoryAdvanced
    {
        public List<Person> People { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCountRangeAges(int min, int max)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetFiltered(string name, int age, string email)
        {
            throw new NotImplementedException();
        }

        public int[] GetNotCapitalizedIds()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int Id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string[]> GroupEmailByNameCount()
        {
            throw new NotImplementedException();
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}