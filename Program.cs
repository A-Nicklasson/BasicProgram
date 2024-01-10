internal class Program {
    private static void Main(string[] args) {
        
        bool loopProgram = true;
        while (loopProgram)
        {
            Clear();
            WriteLine("\n\t\t\t\t\t   Choose program!");
            WriteLine("");
            WriteLine("\t[1] Calculator\t\t\t[2] Simple Dice Game\t\t\t[3] Number Guessing Game");
            WriteLine("\t[4] Shape Area Calculator\t[5] Turn Based Combat Game\t\t[6] Rock Paper Scissors");
            Write("\t[7] To Do List\t\t\t[0] Exit\t");
            _ = int.TryParse(ReadLine(), out int menuOptions);

            switch (menuOptions) {
                case 1:
                    Calculator.Calc();
                    break;

                case 2:
                    DiceGame.DG();
                    break;

                case 3:
                    NumberGuessingGame.NGG();
                    break;

                case 4:
                    ShapeAreaCalculator.shapeS();
                    break;

                case 5:
                    TurnBasedCombat.TBC();
                    break;

                case 6:
                    RockPaperScissor.RPS();
                    break;

                case 7:
                    ToDoList.ToDO();
                    break;

                case 0:
                    Clear();
                    WriteLine("\n\n\t\tClosing Program");
                    loopProgram = false;
                    break;
                default:
                    Clear();
                    WriteLine("\n\n\t\tChoose an Option in the menu!");
                    ReadKey();
                    break;
            }
        }
    }
}