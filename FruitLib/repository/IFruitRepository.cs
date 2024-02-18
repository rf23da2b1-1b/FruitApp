using FruitLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLib.repository
{
    public interface IFruitRepository
    {
        List<Fruit> ReadAll();      // eller GetAll
        Fruit ReadById(int id);     // eller GetById
        Fruit Create(Fruit fruit);  // eller Add
        Fruit Delete(int id);       // eller Remove
        Fruit Update(int id, Fruit fruit); // eller Modify
    }
}


/*
 * Teori
 * 
 * i.	Kan du lave objekter af et interface?
 *      Nej
 *      
 * ii.	Kan du have instansfelter i et interface?
 *      Nej
 *      
 * iii.	Kan du kode en metode fx ToString i et interface?
 *      Nej
 *      
 * iv.	Kan du have en konstant i et interface?
 *      Ja
 *      
 */
