namespace ej_backend.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        // public DateTime 
        public Editorial Editorial { get; set; }
    }
}