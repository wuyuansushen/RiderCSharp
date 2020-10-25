using System;
using static System.Console;
using static System.Convert;

namespace RiderCSharp
{
    enum Orientation : byte
    {
        North=1,
        South=2,
        East=3,
        West=4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Orientation myDirection;
            byte myByte;
            Write("Type a number(1,2,3,4) to choose your direction:");
            try
            {
                myByte = ToByte(ReadLine());
                myDirection = checked((Orientation) myByte);
                if ((myDirection > Orientation.West) || (myDirection < Orientation.North))
                {
                    throw new ArgumentOutOfRangeException("myByte",myByte,"myByte must be between 1 and 4");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                WriteLine(e.Message);
                WriteLine("Error! Use default direction \"North\" now!");
                myDirection = Orientation.North;
            }
            WriteLine($"myDirection={myDirection}");
        }
    }
}

