using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} with a remainder of {mod}");

            var r = 20;
            var pi = Math.PI;
            var areaOfCircle = pi * (r * r);
            Console.WriteLine($"The area of a circle with a radius of {r} is {areaOfCircle}");

          
            var circumferenceOfACircle = 2 * pi * r;
            var d = r + r;
            Console.WriteLine($"The circumference of a circle with a radius of {r} is {circumferenceOfACircle}");
            Console.WriteLine($"The diameter of a circle with a radius of {r} is {d}");

            Console.WriteLine($"The radius of a circle with a circumfernce of {circumferenceOfACircle} is {circumferenceOfACircle / (2*pi)}");


            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);
            



        }
    }
}
