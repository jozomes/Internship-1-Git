using System;
using System.Numerics;

class TicTacToe
{

    static int CheckWin(HashSet<int> player1, HashSet<int> player2)
    {
        // Check rows, columns, and diagonals
        HashSet<int>[] subsets = {
            new HashSet<int> { 1, 2, 3 },
            new HashSet<int> { 4, 5, 6 },
            new HashSet<int> { 7, 8, 9 },
            new HashSet<int> { 1, 4, 7 },
            new HashSet<int> { 2, 5, 8 },
            new HashSet<int> { 3, 6, 9 },
            new HashSet<int> { 1, 5, 9 },
            new HashSet<int> { 3, 5, 7 }
        };
        foreach (var subset in subsets)
        {
            if (player1.IsSupersetOf(subset))
            {
                return 1;
            }
            else if (player2.IsSupersetOf(subset)) 
            {
                return 2;
            }

        }


        return 0; // No winner yet
    }

    static void Main()
    {
        HashSet<int> player1 = new HashSet<int>();
        HashSet<int> player2 = new HashSet<int>();
        int choice;
        int br = 0;
        do
        {
            if (br % 2 == 0)
            {
                Console.WriteLine("Player 1: ");
                choice = int.Parse(Console.ReadLine());

                if (choice >= 1 && choice <= 9)
                {
                    if (!player1.Contains(choice) && !player2.Contains(choice))
                    {
                        player1.Add(choice);
                        br++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move(already chosen). Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move(out of bounds). Try again.");
                }

            }


            else
            {
                Console.WriteLine("Player 2: ");
                choice = int.Parse(Console.ReadLine());

                if (choice >= 1 && choice <= 9)
                {
                    if (!player1.Contains(choice) && !player2.Contains(choice))
                    {
                        player2.Add(choice);
                        br++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move(already chosen). Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move(out of bounds). Try again.");
                }
            }



        } while (CheckWin(player1,player2) == 0 && br < 9);

        if (CheckWin(player1,player2) == 1)
        {
            Console.WriteLine("Player 1 wins!");
        }
        else if (CheckWin(player1, player2) == 2)
        {
            Console.WriteLine("Player 2 wins!");
        }
        else
        {
            Console.WriteLine("It's a draw!");
        }
        Console.ReadLine();
    }
}