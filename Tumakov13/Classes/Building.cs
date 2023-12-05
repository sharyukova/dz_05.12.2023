using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov13.Classes
{
    internal class Building
    {
        internal static int numberOfBuildings = 10;
        private int buildingNumber;
        private int buildingHeight;
        private int numberOfFloors;
        private int numberOfApartments;
        private int numberOfEntrances;

        /// <summary>
        /// Свойство, позволяющее читать поле buildingNumber.
        /// </summary>
        public int BuildingNumber
        {
            get
            {
                return buildingNumber;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать и заполнять поле buildingHeight.
        /// </summary>
        public int BuildingHeight
        {
            get
            {
                return buildingHeight;
            }
            set
            {
                buildingHeight = value;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать и заполнять поле numberOfFloors.
        /// </summary>
        public int NumberOfFloors
        {
            get
            {
                return numberOfFloors;
            }
            set
            {
                numberOfFloors = value;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать и заполнять поле numberOfApartments.
        /// </summary>
        public int NumberOfApartments
        {
            get
            {
                return numberOfApartments;

            }
            set
            {
                numberOfApartments = value;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать и заполнять поле numberOfEntrances.
        /// </summary>
        public int NumberOfEntrances
        {
            get
            {
                return numberOfEntrances;
            }
            set
            {
                numberOfEntrances = value;
            }
        }

        /// <summary>
        /// Свойство, вычисляющee высоту этажей.
        /// </summary>
        /// <returns> Высота этажей в доме. </returns>
        public double CalculationFloorHeight
        {
            get
            {
                return (double)buildingHeight / numberOfFloors;
            }
        }

        /// <summary>
        /// Свойство, вычисляющee количество квартир в подъезде.
        /// </summary>
        /// <returns> Количество квартир в подъезде. </returns>
        public int CalculationNumberOfApartmentsInEntrance
        {
            get
            {
                return NumberOfApartments / NumberOfEntrances;
            }
        }

        /// <summary>
        /// Свойство, вычисляющee количество квартир на одном этаже.
        /// </summary>
        /// <returns> Количество квартир на одном этаже. <returns>
        public int CalculationNumberOfApartmentsOnFloor
        {
            get
            {
                return (NumberOfApartments / NumberOfEntrances) / numberOfFloors;
            }
        }

        /// <summary>
        /// Свойство, изменяющее количество зданий (поле numberOfBuildings).
        /// </summary>
        private int ChangeNumberOfBuilding
        {
            get
            {
                return numberOfBuildings++;
            }
        }
    }
}
