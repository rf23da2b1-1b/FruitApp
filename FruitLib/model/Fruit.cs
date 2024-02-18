using FruitLib.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLib.model
{
    public class Fruit:IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public double Price { get; set; }

        public Fruit():this(-1,"",0,0)
        {
        }

        public Fruit(int id, string name, int weight, double price)
        {
            Id = id;
            Name = name;
            Weight = weight;
            Price = price;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Weight)}={Weight.ToString()}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}
