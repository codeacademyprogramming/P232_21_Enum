using System;
using System.Collections.Generic;
using System.Text;

namespace FarmProject
{
    internal class Sheep:Animal
    {
        static int _totalCount = 0;
        public Sheep()
        {
            _totalCount++;
            No = "S" + _totalCount;
        }
    }
}
