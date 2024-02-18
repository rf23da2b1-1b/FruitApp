﻿using FruitLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLib.repository
{
    public class FruitRepository : IFruitRepository
    {
        private readonly List<Fruit> _fruits;

        public FruitRepository()
        {
            _fruits = new List<Fruit>();
        }


        public Fruit Create(Fruit fruit)
        {
            _fruits.Add(fruit);
            return fruit;

        }

        public Fruit Delete(int id)
        {
            Fruit deleteFruit = ReadById(id);
            _fruits.Remove(deleteFruit);
            return deleteFruit;
        }

        public List<Fruit> ReadAll()
        {
            return new List<Fruit>(_fruits);
        }

        public Fruit ReadById(int id)
        {
            Fruit? foundFruit = _fruits.Find(f => f.Id == id);
            if (foundFruit is null)
            {
                throw new KeyNotFoundException($"Fruit with id={id} is not found");
            }

            return foundFruit;

        }

        public Fruit Update(int id, Fruit fruit)
        {

            if (id != fruit.Id)
            {
                throw new ArgumentException($"Kan ikke updatere et id {id} med et andet {fruit.Id}");
            }
            Fruit updateFruit = ReadById(id);
            int ix = _fruits.IndexOf(updateFruit);
            _fruits[ix] = fruit;

            return fruit;
        }
    }
}


/*
 * Teori
 * 
 * i.	Kan du lave objekter af en abstrakt klasse?
 *      Nej
 *      
 * ii.	Kan du have instansfelter i en abstrakt klasse?
 *      Ja
 *      
 * iii.	Kan du kode en metode fx ToString i en abstrakt klasse?
 *      Ja
 *      
 * iv.	Kan du have en konstant i en abstrakt klasse?
 *      Ja
 *      
 */
