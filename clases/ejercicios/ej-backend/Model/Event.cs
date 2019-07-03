using System;

namespace ej_backend.Model
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }

        public Category Category { get; set; }
    }
}