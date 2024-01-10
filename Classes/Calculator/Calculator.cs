class Calculator {
    
    public static void Calc()
    {
        int firstNumber = 0;
        int secondNumber = 0;
        bool calcLoop = true;
        while (calcLoop)
        {
            
            Clear();
            
            try {
                Write("\tWhat's your first number?\t");
                if (!int.TryParse(ReadLine(), out firstNumber)) { 
                    throw new FormatException();
                }
                Write("\tWhat's your second number?\t");
                if (!int.TryParse(ReadLine(), out secondNumber)) { 
                    throw new FormatException();
                }

                WriteLine($"\tYour numbers are {firstNumber} and {secondNumber}, what do you want to do?");
                Write("\n\t[A]ddition\t[S]ubtract\n\t[M]ultiply\t[D]ivision\n\t[B]ack\t");

                string? menuOption2 = ReadLine();
                switch (menuOption2)
                {
                    case "a":
                    case "A":
                        int addition = firstNumber + secondNumber;
                        WriteLine($"\n\t\t{firstNumber} added by {secondNumber} is {addition}");
                        ReadKey();
                        break;

                    case "s":
                    case "S":
                        decimal subtract = (decimal)firstNumber - (decimal)secondNumber;
                        WriteLine($"\n\t\t{firstNumber} subtracted by {secondNumber} is {subtract}");
                        ReadKey();
                        break;
                    
                    case "m":
                    case "M":
                        int multiply = firstNumber * secondNumber;
                        WriteLine($"\n\t\t{firstNumber} multiplied by {secondNumber} is {multiply}");
                        ReadKey();
                        break;
                    
                    case "d":
                    case "D":
                        try
                        {
                            decimal division = (decimal)firstNumber / (decimal)secondNumber;
                            WriteLine($"\n\t\t{firstNumber} divided by {secondNumber} is {division}");
                        }
                        catch (DivideByZeroException)
                        {
                            WriteLine("\n\n\n\t\t\t\tCan't divide wtih zero");
                        }
                        ReadKey();
                        
                        break;
                    
                    case "b":
                    case "B":
                        calcLoop = false;
                        break;
                    
                    default:
                        WriteLine("\n\n\t\tChoose an option in the menu");
                        ReadKey();
                        break;
                }
            }

            catch (FormatException) {
                WriteLine("\n\n\t\tInvalid Input!");
            }
                      
        }

    }
}