// See https://aka.ms/new-console-template for more information
using System;

namespace CSharp {
    class Program {
        static void Main(string[] args) {
            int x = 2001;
            System.Console.WriteLine(FeetToInches(x));
        }

        static int FeetToInches(int feet) {
            int inches = feet * 12;
            return inches;
        }
    }
}
