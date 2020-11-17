using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAssemblyBlazorDemo.Shared;

namespace WebAssemblyBlazorDemo.Client.Services
{
    public interface IAnimalService
    {
        List<Animal> GetAllAnimals();

        Animal GetAnimal(int id);

        void AdoptAnimal(Animal animalToAdopt);

        void AddAnimal(Animal newAnimal);
    }
}
