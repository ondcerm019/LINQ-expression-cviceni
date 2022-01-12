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
            foreach (var c in db.Countries
                .Include(c => c.Continent)
                .ToList()
            )
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
