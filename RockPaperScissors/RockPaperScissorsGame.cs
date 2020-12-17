using System;

namespace RockPaperScissors
{

    public class RockPaperScissorsGame
    {
        private Random rng;
        private int wins;
        private int losses;
        private int ties;

        public RockPaperScissorsGame()
        {
            rng = new Random();
        }

        public void Play()
        {
            string userChoice;
            userChoice = PromptUser();

            while(userChoice != "Q")
            {
                string computerChoice = GetComputerChoice();
                DetermineWinner(userChoice, computerChoice);
                PrintScore();
                Console.Clear();
                userChoice = PromptUser();
            }
        }

        private void PrintScore() 
        {
            Console.WriteLine("\nWins [{0}]\n", wins);
            Console.WriteLine("Losses [{0}]\n", losses);
            Console.WriteLine("Ties [{0}]\n", ties);
            Console.WriteLine("\nPress [ENTER] to continue\n");
            Console.ReadLine();
        }

        private void DetermineWinner(string userChoice, string ComputerChoice)
        {
            if(userChoice == ComputerChoice)
            {
                Console.Clear();
                ties++;
                Console.WriteLine("\n[TIE] You picked {0}, but so did the computer!\n", ConvertChoiceToWord(userChoice));
            }
            else if((userChoice == "R" && ComputerChoice == "S") || (userChoice == "S" && ComputerChoice == "P") || (userChoice == "P" && ComputerChoice == "R"))
            {
                Console.Clear();
                wins++;
                Console.WriteLine("\n[WIN] You chose {0} and the computer chose {1}, you beat the machine at its own game!\n", ConvertChoiceToWord(userChoice), ConvertChoiceToWord(ComputerChoice));
            }
            else
            {
                Console.Clear();
                losses++;
                Console.WriteLine("\n[LOSE] You chose {0} but the computer chose {1}, you lose!\n", ConvertChoiceToWord(userChoice), ConvertChoiceToWord(ComputerChoice));
            }
        }

        private string ConvertChoiceToWord(string choice)
        {
            if (choice == "R") return "Rock";
            else if (choice == "S") return "Scissors";
            else return "Paper";
        }

        private string GetComputerChoice()
        {
            int choice = rng.Next(1, 4);
            if (choice == 1) return "R";
            else if (choice == 2) return "P";
            else return "S";
        }

        private string PromptUser()
        {
            while(true)
            {
                Console.WriteLine("\n\n\n\n\n\n\n");
                Console.Write("\nEnter your choice:\n\n[R] for Rock \n\n[P] for paper \n\n[S] for Scissors\n\n\n If you would like to Quit, please press [Q]\n\n");
                string choice = Console.ReadLine();
                if(choice == "R" || choice == "P" || choice == "S" || choice == "Q") return choice;
                else{
                 Console.Clear();
                 Console.WriteLine("\nThat was not a valid choice, please try again\n");
                }
            }
        }
    }
}
