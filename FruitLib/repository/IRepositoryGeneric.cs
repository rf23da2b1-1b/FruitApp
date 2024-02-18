using FruitLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLib.repository
{
    public interface IRepositoryGeneric<T>
    {
        List<T> ReadAll();      // eller GetAll
        T ReadById(int id);     // eller GetById
        T Create(T item);  // eller Add
        T Delete(int id);       // eller Remove
        T Update(int id, T item); // eller Modify
    }
}
