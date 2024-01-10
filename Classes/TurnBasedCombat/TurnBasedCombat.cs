class TurnBasedCombat {
    public static void TBC()
    {
        Clear();
        bool combatLoop = true;
        Random rand = new();
        int heroHealth = 20;
        int monsterHealth = 50;
        WriteLine("\n\t\tWho dies first! Press any to start the battle.");
        ReadKey();

         while (combatLoop) {

            int heroDMG = rand.Next(5, 15);
            monsterHealth -= heroDMG;
            WriteLine($"\n\t\tHero swings with his warhammer and strikes the monster for {heroDMG}");

            if (monsterHealth <= 0) { 
                WriteLine("\n\t\tThe Hero slew the monster");
                WriteLine($"\t\tHero has {heroHealth} left"); 

                break;
            }

            int monsterDMG = rand.Next(2, 6);
            heroHealth -= monsterDMG;
            WriteLine($"\t\tMonster slashes the hero with it's sharp claw for {monsterDMG}");

            if (heroHealth <= 0) { 
                WriteLine("\n\t\tThe Monster slew the hero"); 
                WriteLine($"\t\tThe Monster has {monsterHealth} left");
                break;
            }

            Thread.Sleep(1000);

        } 
        ReadKey();
    }
}
    