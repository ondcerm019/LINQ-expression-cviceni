using CountriesEFC.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CountriesEFC
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            // vypis dat
            /*foreach (var c in db.Countries
                .Include(c => c.Continent)
                .ToList()
            )
            {
                Console.WriteLine(c);
            }*/

            //1
            /*foreach (var c in db.Countries.OrderBy(c => c.Name).ToList())
            {
                Console.WriteLine(c);
            }*/

            //2
            /*foreach (var c in db.Countries.OrderByDescending(c => (c.Population / c.LandArea)).ToList())
            {
                Console.WriteLine(c);
            }*/

            //3
            /*foreach (var c in db.Countries.Include(c => c.Continent).Where(c => c.Continent.Name == "Europe").ToList())
            {
                Console.WriteLine(c);
            }*/

            //4
            /*foreach (var c in db.Countries.Where(c => c.FertilityRate > 2).OrderByDescending(c => c.FertilityRate).ToList())
            {
                Console.WriteLine(c);
            }*/

            //5
            /*foreach (var c in db.Countries.Select(c => new { Name = c.Name, CountryEconomic = (c.GDP / c.Population) }).ToList())
            {
                Console.WriteLine(c);
            }*/

            //6
            /*foreach (var c in db.Countries.Include(c => c.Continent).GroupBy(c => c.Continent.Name).Select(g => new { Name = g.Key, Count = g.Count() }).ToList())
            {
                Console.WriteLine(c);
            }*/

            //7
            /*foreach (var c in db.Countries.Include(c => c.Continent).GroupBy(c => c.Continent.Name).Select(g => new { Name = g.Key, Population = g.Sum(c => c.Population) }).ToList())
            {
                Console.WriteLine(c);
            }*/

            //8
            /*foreach (var c in db.Countries.OrderByDescending(c => c.Population).Take(5).ToList())
            {
                Console.WriteLine(c);
            }*/

            //9
            /*foreach (var c in db.Countries.OrderByDescending(c => (c.Population / c.LandArea)).Take(5).ToList())
            {
                Console.WriteLine(c);
            }*/

            //10
            /*foreach (var c in db.Countries.Where(c => c.Name.StartsWith("C")).ToList())
            {
                Console.WriteLine(c);
            }*/

            //11
            foreach (var c in db.Countries.Include(c => c.Continent).GroupBy(c => c.Continent.Name).Select(g => new { Name = g.Key, FertilityRate = g.Average(c => c.FertilityRate) }).ToList())
            {
                Console.WriteLine(c);
            }
        }

        /*
         * Použijte jen funkce LINQ (Select, Where, OrderBy, OrderByDescending, Take, Count, Group)
         * 1. Seřaďte data podle názvu a vypište je
         * 2. Seřaďte data podle hustoty osídlení a vypište je
         * 3. Získejte jen data zemí z Evropy a vypište je
         * 4. Získejte data zemí, které mají porodnost větší než 2 a seřaďte je sestupně podle porodnosti
         * 5. Získejte data všech zemí, ale spočítejte jejich HDP na hlavu a data vypište přes Select jako CountryEconomic
         * 6. Vypište, kolik zemí máme na jakém kontinentu (Group)
         * 7. Vypište, kolik obyvatel z námi vybraných zemí žije na kterém kontinentu
         * 8. Vypište 5 zemí s největší populací
         * 9. Vypište 5 zemí s největší hustotou obyvatelstva
         * 10. Vypište země, jejichž název začíná písmenem "C" (String.StartsWith)
         * 11. Vypište průměrný index porodnosti na jednotlivých kontinentech
         */
    }
}
