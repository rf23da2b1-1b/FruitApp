using FruitLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLib.repository
{
    public class RepositoryGeneric<T> : IRepositoryGeneric<T> where T : IModel
    {
        private readonly List<T> _items;

        public RepositoryGeneric()
        {
            _items = new List<T>();
        }


        public T Create(T item)
        {
            _items.Add(item);
            return item;

        }

        public T Delete(int id)
        {
            T deleteItem = ReadById(id);
            _items.Remove(deleteItem);
            return deleteItem;
        }

        public List<T> ReadAll()
        {
            return new List<T>(_items);
        }

        public T ReadById(int id)
        {
            T? foundItem = _items.Find(i => i.Id == id);
            if (foundItem is null)
            {
                throw new KeyNotFoundException($"Item with id={id} is not found");
            }

            return foundItem;

        }

        public T Update(int id, T item)
        {

            if (id != item.Id)
            {
                throw new ArgumentException($"Kan ikke updatere et id {id} med et andet {item.Id}");
            }
            T updateItem = ReadById(id);
            int ix = _items.IndexOf(updateItem);
            _items[ix] = item;

            return item;
        }
    }
}
