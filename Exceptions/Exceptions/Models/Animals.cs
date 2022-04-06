using System;
using System.Collections.Generic;
using System.Text;
using Exceptions.Utilities;

namespace Exceptions.Models
{
    internal class Animals
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Eats { get; set; }

        public bool occur = false;

        public Animals(string name,string type,string eats)
        {
            if(name != null && name != "" && eats != " ")
            {
                Name = name;
            }

            if(type != "Mammal" && type != "Reptile")
            {
                occur = true;
                try
                {
                    throw new NoSuchAnimalException("There is no such animal type , you need to insert Mammal or Reptile");
                }
                catch(NoSuchAnimalException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Type = type;
            }

            if(eats != "Carnivore" && eats != "Herbivore")
            {
                occur=true;
                throw new NoSuchAnimalException("There is no such animal type , other than Carnivore or Herbivore");
            }
            else
            {
                Eats = eats;
            }
        }

        public void ShowInfo()
        {
            if (!occur)
            {
                Console.WriteLine($"Animal's info:\nName: {Name}\nType: {Type}\nEats: {Eats}");

            }
        }

    }
}
