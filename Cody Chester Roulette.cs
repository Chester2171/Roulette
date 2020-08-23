using System;

namespace RouletteWheel
{
    class Program
    {
        static Tuple<int, string> theBet = new Tuple<int, string>(0, "null");
        static Tuple<string, int> spinResult = new Tuple<string, int>("null", 0);
        static int wallet = 0;
        static int rollBet = 0;
        static void Welcome()
        {
            Console.WriteLine("Roulette: The Game of Chance!\n" +
                "How much money have you brought to gamble away?");
            wallet = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            bet();
        }
        static void bet()
        {
            int choice = 0;
            if (wallet == 0) return;
            try
            {
                Console.WriteLine("How much would you like to bet?");
                rollBet = int.Parse(Console.ReadLine());
                if (rollBet > wallet)
                {
                    Console.WriteLine($"Your bet is larger than your wallet: {wallet}, please enter a new bet");
                    bet();
                }
                Console.WriteLine("1. Bet on one Number.\n" +
                    "2. Bet on Even or Odds.\n" +
                    "3. Bet on Red or Black.\n" +
                    "4. Bet on High Numbers or Low Numbers.\n" +
                    "5. Bet on Dozens.\n" +
                    "6. Bet on Columns.\n" +
                    "7. Bet on Streets.\n" +
                    "8. Bet on Double Rows.\n" +
                    "9. Bet on Split.\n" +
                    "10. Bet on Corners.\n");
                Console.WriteLine("Enter the number for how you would like to bet: ");
                choice = int.Parse(Console.ReadLine());
                if (choice > 10 || choice < 1)
                {
                    Console.WriteLine("Please enter a valid choice");
                    bet();
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer.");
                bet();
            }
            betType(choice);
        }
        static void betType(int input)
        {
            string betSelect = "";
            int numSelect = 0;

            if (input == 1)
            {
                betSelect = "Number Selection";
                Console.WriteLine("What number would you like to bet on?\n" +
                    "1, 2, 3, 4, 5, 6, 7, 8, 9, 10\n" +
                    "11, 12, 13, 14, 15, 16, 17, 18, 19, 20\n" +
                    "21, 22, 23, 24, 25, 26, 27, 28, 29, 30\n" +
                    "31, 32, 33, 34, 35, 36, 0, 00");
                numSelect = int.Parse(Console.ReadLine());
            }
            if (input == 2)
            {
                betSelect = "Even or Odd";
                Console.WriteLine("Enter 1 for Odds and 2 for Evens: ");
                numSelect = int.Parse(Console.ReadLine());
            }
            if (input == 3)
            {
                betSelect = "Red or Black";
                Console.WriteLine("Enter 1 for Reds and 2 for Blacks: ");
                numSelect = int.Parse(Console.ReadLine());
            }
            if (input == 4)
            {
                betSelect = "Low Numbers or High Numbers";
                Console.WriteLine("Enter 1 for Low Numbers (1-18) and 2 for High Numbers (19-38): ");
                numSelect = int.Parse(Console.ReadLine());
            }
            if (input == 5)
            {
                betSelect = "Dozen";
                Console.WriteLine("Enter 1 for Dozen 1 (1-12), 2 for Dozen (13-24), 3 for Dozen (25-36): ");
                numSelect = int.Parse(Console.ReadLine());
            }
            if (input == 6)
            {
                betSelect = "Column";
                Console.WriteLine("Enter 1 for Column 1, 2 for Column 2, and 3 for Column 3: ");
                numSelect = int.Parse(Console.ReadLine());
            }
            if (input == 7)
            {
                betSelect = "Street";
                Console.WriteLine("Enter the coresponding number to the Street you would like to bet on:\n" +
                    "1. (1-3)\n" +
                    "2. (4-6)\n" +
                    "3. (7-9)\n" +
                    "4. (10-12)\n" +
                    "5. (13-15)\n" +
                    "6. (16-18)\n" +
                    "7. (19-21)\n" +
                    "8. (22-24)\n" +
                    "9. (25-27)\n" +
                    "10. (28-30)\n" +
                    "11. (31-33)\n" +
                    "12. (34-36)\n");
                numSelect = int.Parse(Console.ReadLine());
            }
            if (input == 8)
            {
                betSelect = "6 Lines";
                Console.WriteLine("Enter the coresponding number to the 6 lines:\n" +
                    "1. (1-6)\n" +
                    "2. (7-12)\n" +
                    "3. (13-18)\n" +
                    "4. (19-24)\n" +
                    "5. (25-32)\n" +
                    "6. (33- 36)\n");
                numSelect = int.Parse(Console.ReadLine());
            }
            if (input == 9)
            {
                betSelect = "Split";
                Console.WriteLine("Enter 1 for Horizontal Split and 2 for Vertical Split: ");
                numSelect = int.Parse(Console.ReadLine());
                if (numSelect == 1)
                {
                    Console.WriteLine("What split would you like to bet on?\n" +
                        "Horizontal Splits:\n" +
                        "1. 1/2      2. 2/3\n" +
                        "3. 4/5      4. 5/6\n" +
                        "5. 7/8      6. 8/9\n" +
                        "7. 10/11    8. 11/12\n" +
                        "9. 13/14    10. 14/15\n" +
                        "11. 16/17   12. 17/18\n" +
                        "13. 19/20   14. 20/21\n" +
                        "15. 22/23   16. 23/24\n" +
                        "17. 25/26   18. 26/27\n" +
                        "19. 28/29   20. 29/30\n" +
                        "21. 31/32   22. 32/33\n" +
                        "23. 34/35   24. 35/36");
                    numSelect = int.Parse(Console.ReadLine());
                }
                else if (numSelect == 2)
                {
                    Console.WriteLine("What split would you like to bet on?\n" +
                        "Vertical Splits:\n" +
                        "1. 1/4      2. 2/5      3. 3/6\n" +
                        "4. 4/7      5. 5/8      6. 6/9\n" +
                        "7. 7/10     8. 8/11     9. 9/12\n" +
                        "10. 10/13   11. 11/14   12. 12/15\n" +
                        "13. 13/16   14. 14/17   15. 15/18\n" +
                        "16. 16/19   17. 17/20   18. 18/21\n" +
                        "19. 19/22   20. 20/23   21. 21/24\n" +
                        "22. 22/25   23. 23/26   24. 24/27\n" +
                        "25. 25/28   26. 26/29   27. 27/30\n" +
                        "28. 28/31   29. 29/32   30. 30/33\n" +
                        "31. 31/34   32. 32/35   33. 33/36");
                    numSelect = int.Parse(Console.ReadLine());
                }
            }
            if (input == 10)
            {
                betSelect = "Corners";
                Console.WriteLine("Enter the coresponding number to the Corner you would like to bet on:\n" +
                    "1. 1/2/3/4         2. 2/3/5/6\n" +
                    "3. 4/5/7/8         4. 5/6/8/9\n" +
                    "5. 7/8/10/11       6. 8/9/11/12\n" +
                    "7. 10/11/13/14     8. 11/12/14/15\n" +
                    "9. 13/14/16/17     10. 14/15/17/18\n" +
                    "11. 16/17/19/20    12. 17/18/20/21\n" +
                    "13. 19/20/22/23    14. 20/21/23/24\n" +
                    "15. 22/23/25/26    16. 23/24/26/27\n" +
                    "17. 25/26/28/29    18. 26/27/29/30\n" +
                    "19. 28/29/31/32    20. 29/30/32/33\n" +
                    "21. 31/32/34/35    22. 32/33/35/36");
                numSelect = int.Parse(Console.ReadLine());
            }
            theBet = new Tuple<int, string>(numSelect, betSelect);
            spin();
            winOrLose();
        }
        static void spin()
        {
            Random random = new Random();
            string color = "";
            int[] numbers = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,0,00};
            string[] colors = new string[] { "Black", "Red", "Green" };

            int ballNum = numbers[random.Next(0, 38)];

            if ((ballNum >= 1 && ballNum <= 10) || (ballNum >= 19 && ballNum <= 28))
            {
                if (ballNum % 2 == 0) color = colors[1];
                else color = colors[0];
            }
            else if ((ballNum >= 11 && ballNum <= 18) || (ballNum >= 29 && ballNum <= 36))
            {
                if (ballNum % 2 == 0) color = colors[1];
                else color = colors[0];
            }
            else if (ballNum == 0) color = colors[2];
            spinResult = new Tuple<string, int>(color, ballNum);
        }
        static void winOrLose()
        {
            {
                int rollNum = spinResult.Item2;
                string rollColor = spinResult.Item1;
                string betType = theBet.Item2;
                int betSpecific = theBet.Item1;


                Console.WriteLine($"\nThe roll was {rollNum}, {rollColor}.");
                if (betType == "Number Selection")
                {
                    if (betSpecific == rollNum)
                    {
                        wallet += rollBet * 35;
                        Console.WriteLine($"Nice! You won ${(rollBet * 35)}!\n" +
                            $"You now have ${wallet}.");
                    }
                    else
                    {
                        wallet -= rollBet;
                        Console.WriteLine($"You lost ${rollBet}. Better luck next time!\n" +
                            $"You now have ${wallet}");
                    }
                }

                else if (betType == "Even or Odd")
                {
                    if (betSpecific == 1 && rollNum % 2 == 0)
                    {
                        wallet += rollBet;
                        Console.WriteLine($"Nice! You won ${rollBet}!\n" +
                            $"You now have ${wallet}");
                    }
                    else if (betSpecific == 2 && rollNum % 2 != 0)
                    {
                        wallet += rollBet;
                        Console.WriteLine($"Nice! You won ${rollBet}!\n" +
                            $"You now have ${wallet}");
                    }
                    else
                    {
                        wallet -= rollBet;
                        Console.WriteLine($"You lost ${rollBet}. Better luck next time!\n" +
                            $"You now have ${wallet}");
                    }
                }
                else if (betType == "Red or Black")
                {
                    if (betSpecific == 1 && rollColor == "red")
                    {
                        wallet += rollBet;
                        Console.WriteLine($"Nice! You won ${rollBet}!\n" +
                            $"You now have ${wallet}");
                    }
                    else if (betSpecific == 2 && rollColor == "black")
                    {
                        wallet += rollBet;
                        Console.WriteLine($"Nice! You won ${rollBet}!\n" +
                            $"You now have ${wallet}");
                    }
                    else
                    {
                        wallet -= rollBet;
                        Console.WriteLine($"You lost ${rollBet}. Better luck next time!\n" +
                            $"You now have ${wallet}");
                    }
                }
                else if (betType == "Low Numbers or High Numbers")
                {
                    if (betSpecific == 1 && rollNum >= 1 && rollNum <= 18)
                    {
                        wallet += rollBet;
                        Console.WriteLine($"Nice! You won ${rollBet}!\n" +
                            $"You now have ${wallet}");
                    }
                    else if (betSpecific == 2 && rollNum >= 19 && rollNum <= 36)
                    {
                        wallet += rollBet;
                        Console.WriteLine($"Nice! You won ${rollBet}!\n" +
                            $"You now have ${wallet}");
                    }
                    else
                    {
                        wallet -= rollBet;
                        Console.WriteLine($"You lost ${rollBet}. Better luck next time!\n" +
                            $"You now have ${wallet}");
                    }
                }

                if (betType == "Dozen")
                {
                    if (betSpecific == 1 && rollNum >= 1 && rollNum <= 12)
                    {
                        wallet += rollBet * 2;
                        Console.WriteLine($"Nice! You won ${rollBet * 2}!\n" +
                            $"You now have ${wallet}");
                    }
                    else if (betSpecific == 2 && rollNum >= 13 && rollNum <= 24)
                    {
                        wallet += rollBet * 2;
                        Console.WriteLine($"Nice! You won ${rollBet * 2}!\n" +
                            $"You now have ${wallet}");
                    }
                    else if (betSpecific == 3 && rollNum >= 25 && rollNum <= 36)
                    {
                        wallet += rollBet * 2;
                        Console.WriteLine($"Nice! You won ${rollBet * 2}!\n" +
                            $"You now have ${wallet}");
                    }
                    else
                    {
                        wallet -= rollBet;
                        Console.WriteLine($"You lost ${rollBet}. Better luck next time!\n" +
                            $"You now have ${wallet}");
                    }
                }
                if (betType == "Column")
                {
                    if (betSpecific == 1 && rollNum % 3 == 1)
                    {
                        wallet += rollBet * 2;
                        Console.WriteLine($"Nice! You won ${rollBet * 2}!\n" +
                            $"You now have ${wallet}");
                    }
                    else if (betSpecific == 2 && rollNum % 3 == 2)
                    {
                        wallet += rollBet * 2;
                        Console.WriteLine($"Nice! You won ${rollBet * 2}!\n" +
                            $"You now have ${wallet}");
                    }
                    else if (betSpecific == 3 && rollNum % 3 == 0)
                    {
                        wallet += rollBet * 2;
                        Console.WriteLine($"Nice! You won ${rollBet * 2}!\n" +
                            $"You now have ${wallet}");
                    }
                    else
                    {
                        wallet -= rollBet;
                        Console.WriteLine($"You lost ${rollBet}. Better luck next time!\n" +
                            $"You now have ${wallet}");
                    }
                }
                if (betType == "Street")
                {
                    int winNum = 0;
                    if (rollNum % 3 != 0) winNum = rollNum / 3 + 1;
                    else winNum = rollNum / 3;
                    Console.WriteLine(winNum);

                    if (betSpecific == winNum)
                    {
                        wallet += rollBet * 11;
                        Console.WriteLine($"Nice! You won ${rollBet * 11}!\n" +
                            $"You now have ${wallet}");
                    }
                    else
                    {
                        wallet -= rollBet;
                        Console.WriteLine($"You lost ${rollBet}. Better luck next time!\n" +
                            $"You now have ${wallet}");
                    }
                }

                if (betType == "6 Lines")
                {
                    int winNum = 0;
                    if (rollNum % 6 != 0) winNum = rollNum / 6 + 1;
                    else winNum = rollNum / 6;

                    if (betSpecific == winNum)
                    {
                        wallet += rollBet * 5;
                        Console.WriteLine($"Nice! You won ${rollBet * 5}!\n" +
                            $"You now have ${wallet}");
                    }
                    else
                    {
                        wallet -= rollBet;
                        Console.WriteLine($"You lost ${rollBet}. Better luck next time!\n" +
                            $"You now have ${wallet}");
                    }
                }

                if (betType == "Split")
                {
                    bool isWin = false;

                        int[] horizontalNums = new int[] {1,2,2,3,4,5,5,6,7,8,8,9,10,11,11,12,13,14,14,15,16,17,17,18,19,20
                    ,20,21,22,23,23,24,25,26,26,27,28,29,29,30,31,32,32,33,34,35,35,36};

                        betSpecific = (betSpecific - 1) * 2;

                        for (int i = betSpecific; i < betSpecific + 2; i++)
                        {
                            if (horizontalNums[i] == rollNum) isWin = true;
                        }


                    if (isWin == true)
                    {
                        wallet += rollBet * 5;
                        Console.WriteLine($"Nice! You won ${rollBet * 17}!\n" +
                            $"You now have ${wallet}");
                    }
                    else
                    {
                        wallet -= rollBet;
                        Console.WriteLine($"You lost ${rollBet}. Better luck next time!\n" +
                            $"You now have ${wallet}");
                    }
                }
                if (betType == "Corners")
                {
                    int[] corners = new int[] {1,2,4,5,2,3,5,6,4,5,7,8,5,6,8,9,7,8,10,11,8,9,11,12,10,11,13,14,11,12,14,15,
                13,14,16,17,14,15,17,18,16,17,19,20,17,18,20,21,19,20,22,23,20,21,23,23,22,23,25,25,23,24,26,27,25,26,28,29
                ,26,27,29,30,28,29,31,32,29,30,32,33,31,32,34,35,32,33,35,36};

                    int index = (betSpecific - 1) * 4;
                    bool win = false;
                    for (int i = index; i < index + 4; i++)
                    {
                        if (corners[i] == rollNum)
                        {
                            win = true;
                        }
                    }

                    if (win == true)
                    {
                        wallet += rollBet * 8;
                        Console.WriteLine($"Nice! You won ${rollBet * 8}!\n" +
                            $"You now have ${wallet}");
                    }
                    else if (win == false)
                    {
                        wallet -= rollBet;
                        Console.WriteLine($"You lost ${rollBet}. Better luck next time!\n" +
                            $"You now have ${wallet}");
                    }
                }

                bet();
            }

        }
        static void Main(string[] args)
        {
            Welcome();
        }
    }
}
