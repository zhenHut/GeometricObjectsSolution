using System.Collections;

namespace AuflistungsKlassen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList füllen

            ArrayList arrList = new ArrayList()
            {
                new Person(){Name="Meier", City="Berlin"},
                new Person(){Name="Schulz", City="Stuttgart"},
                new Person(){Name="Gerhards", City="Hamburg"},
                new Person(){Name="Müller", City="Bremen"},
            };

            // nach Citys sortieren

            arrList.Sort(new CityComparer());
            Console.WriteLine("Liste nach Wohnort sortiert");
            ShowSortedListed(arrList);



            // nach Namen sortieren

            arrList.Sort(new NameComparer());
            Console.WriteLine("Liste nach Name sortiert");

            ShowSortedListed(arrList);
        }

        private static void ShowSortedListed(ArrayList arrList)
        {

            foreach (Person person in arrList) 
            {
                if (person != null) 
                {
                    Console.Write($"Name = {person.Name, -12}");
                    Console.WriteLine($"Wohnort = {person.City}");
                }
            }
            Console.WriteLine();
        }
    }
}
