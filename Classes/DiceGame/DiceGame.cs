class DiceGame {

    public static void DG()
    {
        int rounds;
        int playerScore = 0;
        int AIScore = 0;
        int DrawScore = 0;
        Random diceRand = new Random();
        Clear();
        WriteLine("\n\t\tWelcome to the Dice Game");
        WriteLine("\t\tYou will be playing five rounds against a computer");
        WriteLine("\t\tPress any Key to start and Good Luck!\n");
        ReadKey();

        do {

            for (rounds = 1; rounds < 6; rounds++)
            {
                int playerDice = diceRand.Next(1, 7);
                int AIDice = diceRand.Next(1, 7);
                Write("\t       ---------------");
                WriteLine($"\n\t\tRound: {rounds}");
                WriteLine($"\t\tYour Roll: {playerDice}");
                WriteLine($"\t\tAI Roll: {AIDice}");

                if (playerDice > AIDice) {
                    playerScore += 1;
                    WriteLine("\t\tPlayer Wins");
                }
                else if (AIDice > playerDice) {
                    AIScore += 1;
                    WriteLine("\t\tAI Wins");
                }
                else if (AIDice == playerDice) {
                    DrawScore += 1;
                    WriteLine("\t\tIt's a Draw");
                }
                WriteLine("\t       ---------------");
                Thread.Sleep(2000);
                
            }

        } while (rounds == 5);

        Clear();
        WriteLine($"\n\t\tPlayer Score {playerScore}");
        WriteLine($"\t\tAI Score {AIScore}");
        WriteLine($"\t\tDraws {DrawScore}");
        if (playerScore > AIScore) { WriteLine("\n\t\t\tPlayer Wins!"); }
        else if (AIScore > playerScore) { WriteLine("\n\t\t\tAI Wins"); }
        else { WriteLine("\n\t\t\tIt's a Draw"); }

        ReadKey();
    }
}