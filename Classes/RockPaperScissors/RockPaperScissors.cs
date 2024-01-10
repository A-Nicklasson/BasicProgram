using System.Text;
class RockPaperScissor {
    static Random rand = new();

    public static void RPS() {
        
        int computerScore = 0;
        int userScore = 0;
        int userChoice = 0;
        
        bool gameLoop = true;
        while (gameLoop){ 

            int _rng = rand.Next(1, 4);
            Clear();
            WriteLine("\n\t\tYou will be playing a best of three in Rock Paper Scissors");
            WriteLine("\t\tMake your choice and Good Luck!\n");
            WriteLine($"\n\t\tPlayer Score: {userScore}\t\tComputer Score: {computerScore}\n");

            Write("\t\t[1] Rock\t[2] Paper\t[3] Scissors\t");

            _ = int.TryParse(ReadLine(), out userChoice); 
            if (userChoice != _rng) {
                switch (userChoice) { 

                    case 1:
                        if (_rng == 2) {
                            computerScore++;
                            WriteLine($"\n\t\tComputer Wins! +{computerScore}");
                            WriteLine($"\t\tPaper Covers Rock");
                            ReadKey();
                        }
                        
                        else {
                            userScore++;
                            WriteLine($"\n\t\tPlayer Wins! +{userScore}");
                            WriteLine("\t\tRock Crushes Scissor");
                            ReadKey();
                        }
                        break;

                    case 2:
                        if (_rng == 3) {
                            computerScore++;
                            WriteLine($"\n\t\tComputer Wins! +{computerScore}");
                            WriteLine($"\t\tScissors Cuts Paper");
                            ReadKey();
                        }
                        
                        else {
                            userScore++;
                            WriteLine($"\n\t\tPlayer Wins! +{userScore}");
                            WriteLine("\t\tPaper Covers Rock");
                            ReadKey();
                        }
                        break;

                    case 3:
                        if (_rng == 1) {
                            computerScore++;
                            WriteLine($"\n\t\tComputer Wins! +{computerScore}");
                            WriteLine($"\t\tRock Crushes Scissors");ReadKey();
                            ReadKey();
                        }
                        
                        else {
                            userScore++;
                            WriteLine($"\n\t\tPlayer Wins! +{userScore}");
                            WriteLine("\t\tScissors Cuts Paper");
                            ReadKey();
                        }
                        break;
                    default:
                        WriteLine("\n\t\tPlease choose one of the options");
                        ReadKey();
                        break;
               
                }
                if (computerScore == 2 || userScore == 2) { 
                    Clear();
                    if (userScore == 2) { 
                        WriteLine($"\n\t\tCongratulations you won! {userScore}");
                        WriteLine($"\t\tComputer: {computerScore}");
                        gameLoop = false;
                        ReadKey();
                    }
                    else { 
                        WriteLine($"\n\t\tYou Lose! {userScore}");
                        WriteLine($"\t\tComputer: {computerScore}");
                        gameLoop = false;
                        ReadKey();
                    }
                }
            }
            else
            {
                WriteLine("\n\n\t\tIt's a draw");
                ReadKey();
            }
        }        
    }
}