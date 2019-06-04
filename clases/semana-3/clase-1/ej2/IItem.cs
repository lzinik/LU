using System.Collections.Generic;

namespace ej2
{
    public interface IItem
    {
        List<object> Items { get; set; }
        void Add(object Item);
        object Get();
        void Delete(int index);
        void ShowQuantity();
        void ShowMinAndMax();
        object Find(int index);
        void PrintAll();
        void Exit();
    }
}
