using PersonRepository.Entities;
using System.Collections.Generic;

namespace PersonRepository.Interfaces
{
    public interface IPersonRepositoryBasic
    {
        List<Person> People { get; set; }
        void Add(Person person);
        void Update(Person person);
        void Delete(int id);
        List<Person> GetFiltered(string name, int age, string email);
        Person GetPerson(int Id);
    }
}
