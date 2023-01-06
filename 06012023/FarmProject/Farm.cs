using System;
using System.Collections.Generic;
using System.Text;

namespace FarmProject
{
    internal class Farm : IFarm
    {
        private Animal[] _animals;
        public Animal[] Animals => _animals;

        private int _horseLimit;
        private int _sheepLimit;


        public void AddAnimal(Animal animal)
        {
            bool checkSize = false;

            if (animal is Horse)
                checkSize = _horseLimit > _calcAnimalCount(typeof(Horse));
            else
                checkSize = _sheepLimit > _calcAnimalCount(typeof(Sheep));

            if (checkSize)
            {
                Array.Resize(ref _animals, _animals.Length + 1);
                _animals[_animals.Length - 1] = animal;
            }
        }

        public Animal GetAnimalByNo(string no)
        {
            for (int i = 0; i < _animals.Length; i++)
            {
                if (_animals[i].No == no)
                    return _animals[i];
            }

            return null;
        }

        public Animal[] GetAnimals()
        {
            return Animals;
        }

        public Sheep[] GetSheeps()
        {
            Sheep[] sheeps = new Sheep[0];

            for (int i = 0; i < _animals.Length; i++)
            {
                if(_animals[i] is Sheep sheep)
                {
                    Array.Resize(ref sheeps, sheeps.Length + 1);
                    sheeps[sheeps.Length - 1] = sheep;
                }
            }

            return sheeps;
        }
        public Horse[] GetHorses()
        {
            Horse[] horses = new Horse[0];


            foreach (var item in _animals)
            {
                if (item is Horse)
                {
                    Array.Resize(ref horses, horses.Length + 1);
                    horses[horses.Length - 1] = (Horse)item;
                }
            }

            return horses;
        }

        private int _calcAnimalCount(Type type)
        {
            int count = 0;
            for (int i = 0;i< _animals.Length; i++)
            {
                if (_animals[i].GetType() == type)
                    count++;
            }
            return count;
        }
    }
}
