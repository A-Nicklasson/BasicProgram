class NumberGuessingGame
{
    public static void NGG()
    {
        Random rand = new();
        int balance = 1000;
        int bet = 0;
        int guess = 0;
        int tries = 0;
        
        do {
            int number = rand.Next(1, 6);
            Clear();
            WriteLine($"\n\tWelcome to the Number Guessing Game!\n\tYou have {balance}$");
            WriteLine($"\n\tYou can quit the game whenever you want with 0.");
            Write("\n\tHow much would you like to bet? Max bet is 1000\t\t");

            try
            {
                if (!int.TryParse(ReadLine(), out bet)) { 
                    throw new FormatException();
                }
                if (bet == 0) {
                    Clear();
                    WriteLine("\n\n\t\tQuitting Game!");
                    ReadKey();
                    break;
                }
                else {           
                    Write("\n\tGuess a number between 1-5! you can quit the game with 0.\t");
                    try {
                        
                        if (!int.TryParse(ReadLine(), out guess)) { 
                            throw new FormatException();
                        }
                    
                            if (guess == 0) {
                                Clear();
                                WriteLine("\n\n\t\tQuitting Game!");
                                ReadKey();
                                break;
                            }
                            else if (guess > 5) {
                                balance += bet;
                                WriteLine($"\n\n\t\tInvalid Number"); 
                            }
                            else if (guess != number) {
                                tries++;
                                balance -= bet;
                                WriteLine($"\n\t\tYour Guess: {guess}\n\t\tCorrect Number: {number}\n\t\tNumber of Tries: {tries}");
                                WriteLine($"\n\t\tYou Lose {bet}");                        
                            }

                            else {
                                balance += bet * 3;
                                tries++;
                                WriteLine($"\n\t\tCongratulations you won!");
                                WriteLine($"\t\tCorrect Number: {guess}\n\t\tNumber of Tries: {tries}");
                                WriteLine($"\n\t\t\tYou Win: {bet * 3}");
                            }

                        ReadKey();
                        
                    }
                    
                    catch (FormatException) {
                        WriteLine("\n\n\t\tInvalid Guess");
                        ReadKey();
                    }
                }
            }
            catch (FormatException) {
                WriteLine("\n\n\t\tInvalid Bet");
                ReadKey();
            }

        } while (balance > 0);
        if (guess == 0) { 
            Clear();
        }
        else if (bet == 0) { 
            Clear();
        }
        else {
        Clear();
        WriteLine($"\n\t\tYou are out of money\n\t\tBalance: {balance}");
        WriteLine($"\t\tNumber of tries: {tries}");
        ReadKey();
        }
    }
}