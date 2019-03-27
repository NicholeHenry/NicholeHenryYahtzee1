using System;
using System.Linq;

namespace yahtzee
{
    class Program
    {


        static void Main(string[] args)
        {

            int winningNumber = 0;
            int computerWinner = 0;
            string[] diceRolls = new string[5];

            RandomNumber(winningNumber);
            ComputerRolls(computerWinner);
            WinnerOfGame(winningNumber, computerWinner);

            Console.ReadLine();


        }



        public static int RandomNumber(int winningNumber)
        {
            Random randomNumber = new Random();

            string[] diceRolls = new string[5];

            diceRolls[0] = randomNumber.Next(1, 6).ToString();
            diceRolls[1] = randomNumber.Next(1, 6).ToString();
            diceRolls[2] = randomNumber.Next(1, 6).ToString();
            diceRolls[3] = randomNumber.Next(1, 6).ToString();
            diceRolls[4] = randomNumber.Next(1, 6).ToString();

            foreach (string item in diceRolls)
            {
                Console.WriteLine($"Roll 1: {item}");

            }

            Console.WriteLine("Which dice would you like to remove?");


            // string diceIndex = diceRolls.IndexOf(Console.ReadLine());

            string userInput = Console.ReadLine();
            string randomNew = randomNumber.Next(1, 6).ToString();
            string joinedString = string.Join(",", diceRolls);
            string[] splitString = { "," };
            string finalString = joinedString.Replace(userInput, randomNew);

            string[] diceRoll2 = finalString.Split(splitString, diceRolls.Count(), StringSplitOptions.None);
            foreach (string item in diceRoll2)
            {


                Console.WriteLine($"Dice roll 2: {item}");
            }


            Console.WriteLine("Please choose which dice to remove.");

            string randomNew2 = randomNumber.Next(1, 6).ToString();
            string userInput2 = Console.ReadLine();
            string joinedString2 = string.Join(",", diceRoll2);
            string[] splitString2 = { "," };
            string finalString2 = joinedString2.Replace(userInput2, randomNew2);

            string[] diceRoll3 = finalString2.Split(splitString2, diceRoll2.Count(), StringSplitOptions.None);

            foreach (string item in diceRoll3)
            {
                Console.WriteLine($"Dice roll 3: {item}");
            }

            string finalJoined = string.Join(",", diceRoll3);

            int count1= finalJoined.Split('1').Length - 1;
            Console.WriteLine($"number of times 1 appears : {count1}");
            int count2 = finalJoined.Split('2').Length - 1;
            Console.WriteLine($"number of times 2 appears : {count2}");
            int count3 = finalJoined.Split('3').Length - 1;
            Console.WriteLine($"number of times 3 appears : {count3}");
            int count4 = finalJoined.Split('4').Length - 1;
            Console.WriteLine($"number of times 4 appears : {count4}");
            int count5 = finalJoined.Split('5').Length - 1;
            Console.WriteLine($"number of times 5 appears : {count5}");
            int count6 = finalJoined.Split('6').Length - 1;
            Console.WriteLine($"number of times 6 appears : {count6}");
            

            if (count1 > count2 && count1 > count3 && count1 > count4 && count1 > count5 && count1 > count6)
            {
                winningNumber = count1;
            }

            else if (count2 > count1 && count2 > count3 && count2 > count4 && count2 > count5 && count2 > count6)
            {
                winningNumber = count2;
            }
            else if (count3 > count1 && count3 > count2 && count3 > count4 && count3 > count5 && count3 > count6)
            {
                winningNumber = count3;
            }

            else if (count4 > count1 && count4 > count2 && count4 > count3 && count4 > count5 && count4 > count6)
            {
                winningNumber = count4;
            }

            else if (count5 > count1 && count5 > count2 && count5 > count3 && count5 > count4 && count5 > count6)
            {
                winningNumber = count5;
            }

            else if (count6 > count1 && count6 > count2 && count6 > count3 && count6 > count4 && count6 > count5)
            {
                winningNumber = count6;
            }

            Console.WriteLine(winningNumber);
           //f (finalJoined.IndexOf("1") == 3|| finalJoined.IndexOf("1") == 4 || finalJoined.IndexOf("1") == 5)
           //
           //WriteLine(
           //

            return winningNumber;


            
            
        }


        public static string[] ComputerRolls(int computerWinner)
        {
            string finalComputer1 = null;
            string[] splitComputer = { "," };

            Random computerRandom  = new Random();

              string[] computerRolls = new string[5];

              computerRolls[0] = computerRandom.Next(1, 6).ToString();
              computerRolls[1] = computerRandom.Next(1, 6).ToString();
              computerRolls[2] = computerRandom.Next(1, 6).ToString();
              computerRolls[3] = computerRandom.Next(1, 6).ToString();
              computerRolls[4] = computerRandom.Next(1, 6).ToString();

            for (int i = 0; i < computerRolls.Length; i++)
            {

                Console.WriteLine($"computer roll 1: {i}");

                // Assume not duplicate.

                for (int z = 0; z < i; z++)
                {
                    if (computerRolls[z] != computerRolls[i])
                    {
                        string computer1 = computerRandom.Next(1, 6).ToString();
                        string joinedComputer1 = string.Join(",", computerRolls);
                         finalComputer1 = joinedComputer1.Replace(computerRolls[z], computer1);


                    }


                }

            }

            string[] computerRolls2 = finalComputer1.Split(splitComputer, computerRolls.Count(), StringSplitOptions.None);
            string finalComputer2 = null;
            for (int i = 0; i < computerRolls2.Length; i++)
            {

                Console.WriteLine($"computer roll 2: {i}");

                // Assume not duplicate.

                for (int z = 0; z < i; z++)
                {
                    if (computerRolls2[z] != computerRolls[i])
                    {
                        string computer2 = computerRandom.Next(1, 6).ToString();
                        string joinedComputer2 = string.Join(",", computerRolls2);
                        finalComputer2 = joinedComputer2.Replace(computerRolls2[z], computer2);


                    }


                }

            }

            string[] computerRoll3 = finalComputer2.Split(splitComputer, computerRolls2.Count(), StringSplitOptions.None);

            string finalComputer3 = null;
            for (int i = 0; i < computerRoll3.Length; i++)
            {

                Console.WriteLine($"computer roll 3: {i}");

                // Assume not duplicate.

                for (int z = 0; z < i; z++)
                {
                    if (computerRoll3[z] != computerRolls2[i])
                    {
                        string computer3 = computerRandom.Next(1, 6).ToString();
                        string joinedComputer3 = string.Join(",", computerRoll3);
                        finalComputer3 = joinedComputer3.Replace(computerRoll3[z], computer3);


                    }


                }

            }

            string finalComputer = string.Join(",", computerRoll3);

            int c1 = finalComputer.Split('1').Length - 1;
            Console.WriteLine($"number of times 1 appears : {c1}");
            int c2 = finalComputer.Split('2').Length - 1;
            Console.WriteLine($"number of times 2 appears : {c2}");
            int c3 = finalComputer.Split('3').Length - 1;
            Console.WriteLine($"number of times 3 appears : {c3}");
            int c4 = finalComputer.Split('4').Length - 1;
            Console.WriteLine($"number of times 4 appears : {c4}");
            int c5 = finalComputer.Split('5').Length - 1;
            Console.WriteLine($"number of times 5 appears : {c5}");
            int c6 = finalComputer.Split('6').Length - 1;
            Console.WriteLine($"number of times 6 appears : {c6}");
           

            if (c1 > c2 && c1 > c3 && c1 > c4 && c1 > c5 && c1 > c6)
            {
                computerWinner = c1;
            }

            else if (c2 > c1 && c2 > c3 && c2 > c4 && c2 > c5 && c2 > c6)
            {
                computerWinner = c2;
            }
            else if (c3 > c1 && c3 > c2 && c3 > c4 && c3 > c5 && c3 > c6)
            {
                computerWinner = c3;
            }

            else if (c4 > c1 && c4 > c2 && c4 > c3 && c4 > c5 && c4 > c6)
            {
                computerWinner = c4;
            }

            else if (c5 > c1 && c5 > c2 && c5 > c3 && c5 > c4 && c5 > c6)
            {
                computerWinner = c5;
            }

            else if (c6 > c1 && c6 > c2 && c6 > c3 && c6 > c4 && c6 > c5)
            {
                computerWinner = c6;
            }


            return computerRolls2;


        }

        public static int WinnerOfGame(int winningNumber, int computerWinner)
        {
            int winner = 0;
           
            if (winningNumber > computerWinner)
            {
                winner = winningNumber;
               Console.WriteLine("You Win!");
            }

            else if (computerWinner > winningNumber)
            {
                winner = computerWinner;
                Console.WriteLine("You Lose, sorry.");
            }

            else if (computerWinner == winningNumber)
            {
                winner = winningNumber;
                Console.WriteLine("You win!");
            }
            return winner;
        }

    }
}

//prompt user to roll five dice

//Ask user which dice they want to keep
//roll dice user doesnt want to keep
//ask user which dice they want to keep now
//roll dice user doesnt want to keep
//ask the use which dice they dont want to keep
//roll the dice they dont want to keep
//add up all the dice that was rolled the most ex 6, 4, 3, 3, 3 = 3 dice have the same number 
//now computer needs to roll 3 timesConsole.WritelIne
//each time record the number of die that was used the most
//only keep the computers highest score