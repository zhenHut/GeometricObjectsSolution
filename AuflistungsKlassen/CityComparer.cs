using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuflistungsKlassen
{
    public class CityComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x == null && y == null)
                return 0;

            Person? y1 = y as Person;
            Person? x1 = x as Person;

            if (x1 == null && y1 != null)
                return -1;

            if (x1 != null && y1 == null)
                return 1;

            if (y1 == null || x1 == null)
                throw new InvalidCastException("Ungültiger Typ");

            return x1.City.CompareTo(y1.City);
        }
    }
}
