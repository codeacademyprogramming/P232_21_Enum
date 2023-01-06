using System;
using System.Collections.Generic;
using System.Text;

namespace FarmProject
{
    internal class Horse:Animal
    {
        static int _totalCount = 0;
        public Horse()
        {
            _totalCount++;
            No = "H" + _totalCount;
        }
    }
}
