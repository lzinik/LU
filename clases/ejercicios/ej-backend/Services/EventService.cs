using System;
using System.Collections.Generic;
using System.Linq;
using ej_backend.Model;

namespace ej_backend.Services
{
    public class EventService : IEventService
    {
        private List<Event> list;

        public EventService()
        {
            list = new List<Event>();

            var category1 = new Category() { Id = 1, Name = "Editorial 1" };
            var category2 = new Category() { Id = 2, Name = "Editorial 1" };
            var category3 = new Category() { Id = 3, Name = "Editorial 1" };
            var category4 = new Category() { Id = 4, Name = "Editorial 1" };
            var category5 = new Category() { Id = 5, Name = "Editorial 1" };
            var category6 = new Category() { Id = 6, Name = "Editorial 1" };
            var category7 = new Category() { Id = 7, Name = "Editorial 1" };
            var category8 = new Category() { Id = 8, Name = "Editorial 1" };
            var category9 = new Category() { Id = 9, Name = "Editorial 1" };
            var category10 = new Category() { Id = 10, Name = "Editorial 1" };
            var category11 = new Category() { Id = 11, Name = "Editorial 1" };
            var category12 = new Category() { Id = 12, Name = "Editorial 1" };
            var category13 = new Category() { Id = 13, Name = "Editorial 1" };
            var category14 = new Category() { Id = 14, Name = "Editorial 1" };
            var category15 = new Category() { Id = 15, Name = "Editorial 1" };
            var category16 = new Category() { Id = 16, Name = "Editorial 1" };
            var category17 = new Category() { Id = 17, Name = "Editorial 1" };
            var category18 = new Category() { Id = 18, Name = "Editorial 1" };
            var category19 = new Category() { Id = 19, Name = "Editorial 1" };
            var category20 = new Category() { Id = 20, Name = "Editorial 1" };
            var category21 = new Category() { Id = 21, Name = "Editorial 1" };
            var category22 = new Category() { Id = 22, Name = "Editorial 1" };
            var category23 = new Category() { Id = 23, Name = "Editorial 1" };
            var category24 = new Category() { Id = 24, Name = "Editorial 1" };
            var category25 = new Category() { Id = 25, Name = "Editorial 1" };
            var category26 = new Category() { Id = 26, Name = "Editorial 1" };
            var category27 = new Category() { Id = 27, Name = "Editorial 1" };
            var category28 = new Category() { Id = 28, Name = "Editorial 1" };
            var category29 = new Category() { Id = 29, Name = "Editorial 1" };

            list.Add(new Event()
            { 
                Id = 1,
                Name = "Libro 1",
                Place = "",
                Date = new DateTime(2012, 12, 31, 16, 45, 0),
                Category = category1
            });

            list.Add(new Event()
            { 
                Id = 2,
                Name = "Libro 2"
            });

            list.Add(new Event()
            { 
                Id = 3,
                Name = "Libro 3"
            });
        }
        public List<Event> GetAll()
        {
            return list;
        }

        public Event Get(int id)
        {
            return list.FirstOrDefault(b => b.Id == id);
        }

        public List<Event> GetEventByCategory(int id)
        {
            // list.Filter(e => e.Category.id == id) = new list eventByCategory;

            return list.FindAll(e => e.Category.Id == id);
        }

        public void Save(Event Event)
        {
            this.Delete(Event.Id);

            list.Add(Event);
        }

        public void Delete (int id)
        {
            var Event = Get(id);

            if(Event != null)
            {
                list.Remove(Event);
            }
        }

    }
}