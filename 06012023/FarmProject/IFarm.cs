using System;
using System.Collections.Generic;
using System.Text;

namespace FarmProject
{
    internal interface IFarm
    {
        Animal[] Animals { get; }
        Animal[] GetAnimals();
        Animal GetAnimalByNo(string no);
        void AddAnimal(Animal animal);

    }
}
