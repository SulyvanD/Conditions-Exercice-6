using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions_Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string selected_month;
            string[][] months = new string[][]
            {
                new string[] { "Janvier", "Hiver" },
                new string[] { "Février", "Hiver" },
                new string[] { "Mars", "Printemps" },
                new string[] { "Avril", "Printemps" },
                new string[] { "Mai", "Printemps" },
                new string[] { "Juin", "Ete" },
                new string[] { "Juillet", "Ete" },
                new string[] { "Aout", "Ete" },
                new string[] { "Septembre", "Automne" },
                new string[] { "Octobre", "Automne" },
                new string[] { "Novembre", "Automne" },
                new string[] { "Décembre", "Hiver" },
            };

            Console.WriteLine("Donnez-moi un mois de l'année, je vous donne sa saison.");
            selected_month = Console.ReadLine();

            foreach(string[] month in months)
            {
                if (selected_month == month[0])
                {
                    Console.WriteLine($"La saison du mois de { month[0] } est { month[1] }");
                }
            }
        }
    }
}
