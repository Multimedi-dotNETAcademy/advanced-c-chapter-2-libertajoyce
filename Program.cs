using RulerExercise;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ruler myRuler = new Ruler();
            myRuler.StartLength = 2;
            Console.WriteLine($"{myRuler.LengthInM} meter is {myRuler.LengthInFeet} feet.");
            Console.WriteLine($"{myRuler.LengthInM} meter is {myRuler.LengthInCm} cm.");
            Console.WriteLine($"{myRuler.LengthInM} meter is {myRuler.LengthInKm} km.");

        }
    }
}
