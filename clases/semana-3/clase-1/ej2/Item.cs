using System;
using System.Collections.Generic;
using System.Linq;

namespace ej2
{
    public class Item : IItem
    {
        public int Id { get; set; }
        public List<object> Items { get; set; }
        public void Add(object Item)
        {
            Items.Add(Item);
        }
        public object Get()
        {
            object Item;
            if(Items.Count() > 0)
            {
                Item = Items[0];
                Items.RemoveAt(0);
                return Item;
            }
            else
                throw new Exception();
                Console.WriteLine("La lista esta vacía");
        }
        public void Delete(int index)
        {
            if(Items.ElementAtOrDefault(index) != null)
                Items.RemoveAt(index);
            else
                throw new IndexOutOfRangeException();
        }
        public void ShowQuantity()
        {
            Console.WriteLine("La cantidad de items en la lista, es {0}", Items.Count());
        }

        public void ShowMinAndMax()
        {
            if(Items.Count() > 0)
            {
                Console.WriteLine("El primer elemento de la lista, es: {0}", Items[0]);
                Console.WriteLine("El ultimo elemento de la lista, es: {0}", Items[Items.Count() - 1]);
            }
            else
                Console.WriteLine("La lista esta vacía");
        }
        public object Find(int index)
        {
            object Item;
            if(Items.ElementAtOrDefault(index) != null)
                Item = Items[index];
            else
                throw new IndexOutOfRangeException();

            return Item;
        }

        public void PrintAll()
        {
            foreach (object Item in Items)
            {
                Console.WriteLine(Item);
            }
        }
        
        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
