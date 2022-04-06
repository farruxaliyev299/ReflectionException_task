using System;
using Exceptions.Models;
using Exceptions.Utilities;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals("Dog","Mammal","Omnivore");
            

            dog.ShowInfo();
        }
    }
}
