using System.Collections;

namespace AuflistungsKlassen
{
    public class NameComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x == null && y == null)
                return 0;

            Person? x1 = x as Person;
            Person? y1 = y as Person;

            if (x1 != null && y1 == null)
                return -1;

            if(x1 == null && y1 != null)
                return 1;

            if (y1 == null || x1 == null)
                throw new InvalidCastException("Ungültiger Typ");

            return x1.Name.CompareTo(y1.Name);
        }
    }
}
