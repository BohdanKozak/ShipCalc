using System;
using System.Linq;

namespace Ships
{
    class Program
    {
        static int[,] ships = new int[10, 10] {
        { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, },
        { 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, },
        { 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, },
        { 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, },
        { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, }
       };

        static void Main(string[] args)
        {
            int count = 0;

            // count ships here

            //first method

            count = CountShips(count);
            //second method


            var count2 = from int ship in ships
                         where ship == 1
                         select ship;



            Console.WriteLine("First method:" + count);
            Console.WriteLine("Second method:" + count2.Count());
            Console.ReadLine();

        }

        static int CountShips(int count)
        {
            for (int i = 0; i < ships.GetLength(0); i++)
            {
                for (int j = 0; j < ships.GetLength(1); j++)
                {
                    if (ships[i, j] == 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
