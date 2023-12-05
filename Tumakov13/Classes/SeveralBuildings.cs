using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov13.Classes
{
    internal class SeveralBuildings
    {
        private string[] buildings = new string[Building.numberOfBuildings];

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < 10)
                {
                    return buildings[index];
                }
                else
                {
                    return "ошибка! Либо указанный индекс не входит в диапазон, либо знание под этим индексом не существует";
                }
            }
            set
            {
                if (index >= 0 && index < 10)
                {
                    buildings[index] = value;
                }
            }
        }
    }
}
