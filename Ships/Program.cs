using System;

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



            Console.WriteLine("First method:" + count);

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
                        ships[i, j] = 0;
                        if (j + 1 != 10 && ships[i, j + 1] == 1)
                        {
                            ships[i, j + 1] = 0;
                            if (j + 2 != 10 && ships[i, j + 2] == 1)
                            {
                                ships[i, j + 2] = 0;
                                if (j + 3 != 10 && ships[i, j + 3] == 1)
                                {
                                    ships[i, j + 3] = 0;
                                    count++;
                                }
                                else
                                {
                                    count++;
                                }
                            }
                            else
                            {
                                count++;
                            }

                        }

                        else
                        {
                            if (i + 1 != 10 && ships[i + 1, j] == 1)
                            {
                                ships[i + 1, j] = 0;
                                if (i + 2 != 10 && ships[i + 2, j] == 1)
                                {
                                    ships[i + 2, j] = 0;
                                    if (i + 3 != 10 && ships[i + 3, j] == 1)
                                    {
                                        ships[i + 3, j] = 0;
                                        count++;
                                    }
                                    else
                                    {
                                        count++;
                                    }


                                }
                                else
                                {
                                    count++;
                                }
                            }
                            else
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }

        static bool CheckIfIndexOutOfRange(int index)
        {
            if (index == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
