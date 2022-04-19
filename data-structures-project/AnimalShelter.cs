using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_project
{
    public class AnimalShelter
    {
        Queue cats = new Queue();
        Queue dogs = new Queue();

        int catCounter = 1;
        int dogCounter = 1;

        public void Enqueue(Animal animal)
        {
            if (animal is Cat)
            {
                cats.Enqueue("Cat "+catCounter);
                catCounter++;
            }
            else if (animal is Dog)
            {
                dogs.Enqueue("Dog "+dogCounter);
                dogCounter++;
            }
        }

        public string Dequeue(string pref)
        {
            if (pref == "cat")
            {
                return cats.Dequeue();
            }else if (pref == "dog")
            {
                return dogs.Dequeue();
            }
            return null;
        }
    }

    public class Animal
    {
    }

    public class Cat : Animal
    {
    }

    public class Dog : Animal
    {
    }
}
