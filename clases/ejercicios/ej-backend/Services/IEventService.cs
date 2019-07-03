using ej_backend.Model;
using System.Collections.Generic;

namespace ej_backend.Services
{
    public interface IEventService
    {
        List<Event> GetEventByCategory(int id);
        List<Event> GetAll();
        Event Get(int id);
        void Save(Event Event);
        void Delete (int id);
    }
}