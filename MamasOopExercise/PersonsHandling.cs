using System;
using System.Collections.Generic;
using MamasOopExercise.Interfaces;
using MamasOopExercise.UnitPersons;

namespace MamasOopExercise
{
    public static class PersonsHandling
    {
        static void Main(string[] args)
        {
            // Creating a list of all the unit persons
            var unitPersonsList = new List<IUnitPerson>
            {
                new RegularSolider(),
                new Officer(),
                new Nagad(),
                new Civilian()
            };

            foreach (var person in unitPersonsList)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}