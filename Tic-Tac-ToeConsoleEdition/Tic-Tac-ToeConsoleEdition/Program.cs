using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tic_Tac_ToeConsoleEdition
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Loco = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }; //this is the game board
            // player 1 = X and player 2 = O
            Console.WriteLine("put in the number where you whant to place the symbol (1 for example). \n player1 = X and player2 = O");
            int player1 = 1; // player 1 starts
            int player2 = 0; // player 2 doesen't starts first
            int PlaceMent; //where player wants to put it
            int WinOnDraw = 0;

            //make a whant to go again here... (loop) (triggerred by a win)

            //make this into a method
            do
            {
                Console.Clear();
                Console.WriteLine("player1 = X and player2 = O"); //asks to place and checks whos it is
                if (player1 == 1)
                {
                    Console.WriteLine("Player1 turn (X): \n");
                }
                else
                {
                    Console.WriteLine("Player2 turn (O): \n");
                }
                GameBoard(); //here prints the game board it self here so its easier to see where you whant to place

                PlaceMent = int.Parse(Console.ReadLine().ToUpper());// reads where placed
                if (Loco[PlaceMent] != 'X' && Loco[PlaceMent] != 'O') // places the correct one
                {
                    if (player1 == 1)
                    {
                        Loco[PlaceMent] = 'O';
                        player1--; // the whole whos turn it is runs based on who is 1 and who has 0 so... this kinda important >_>
                        player2++;
                    }
                    else
                    {

                        Loco[PlaceMent] = 'X';
                        player1++;
                        player2--;

                    }
                }
                else //if placed somewhere there is already one
                {
                    Console.WriteLine("You done goofed \n in {0} there is {1}", PlaceMent, Loco[PlaceMent], "\n reloading 1s"); //tells user that he done gooffed and to try again....
                    Thread.Sleep(1000);// i mean come on u already know what this does... i hope
                }
                WinOnDraw = IsWinMby(); //here comes a thing to check if there is already a win in case it got missed
            } while (WinOnDraw != 1 && WinOnDraw != 2 && WinOnDraw != 3); // 1= p1 win, 2= p2 win, 3= its all wrong
            Console.Clear();
            GameBoard(); //prints board again to show who won...












        }
    }
}
