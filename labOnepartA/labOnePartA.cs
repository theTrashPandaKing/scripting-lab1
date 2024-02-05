// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

namespace labOnePartA
{
    internal class Pythagorean
    {
        static void Main(string[] args)
        {
            int triA = 3; // variable for side a of triangle / default is 3 / to add user input
            int triB = 4; // variable for side b of triangle / default is 4 / to add user input
            int aSq = triA * triA; // variable for a^2 / finds a^2 by multiplying a by itself
            int bSq = triB * triB; // variable for b^2 / finds b^2 by multiplying b by itself
            int cSq = aSq + bSq; // variable for c^2  / finds c^2 by adding a^2 and b^2 together
            float triC= (float)Math.Sqrt(cSq); // variable for side c / finds the square root of c^2
            Console.WriteLine(triC); // the triangles c side length 
        }
    }
}   