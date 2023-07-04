using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace FactoryMethodApp
{
    public class Pig:IAnimal
    {
        public void MakeSound()
    {
        Console.WriteLine("Oink!");
    }
    }
}