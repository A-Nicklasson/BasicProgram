class ShapeAreaCalculator {
    public static void shapeS() { 
        int b = 0;
        int h = 0;
        bool shapesLoop = true;
        while (shapesLoop) {

            Clear();
            WriteLine("\n\t\t  What shape do you want to Calculate?\n");
            WriteLine("\t\t[R]ectangle\t[S]quere\t[C]ircle");
            Write("\t\t[T]riangle\n\n\t\t[E]xit\t");

            string? shapeChoice = ReadLine();
            switch (shapeChoice?.ToLower()) { 

                case "r":
                case "R":
                    WriteLine("\n\t\tCalculate area of Rectangle (base * height)");

                    try {
                    Write("\t\tBase: ");
                    if (!int.TryParse(ReadLine(), out b)) { 
                        throw new FormatException();
                    }
                    Write("\t\tHeight: ");
                    if (!int.TryParse(ReadLine(), out h)) { 
                        throw new FormatException();
                    }
                    int r = b * h;
                    WriteLine($"\n\t\tArea is: {r}");
                    }
                    catch (FormatException) {
                        WriteLine("\n\n\t\tInvalid Input!");
                    }
                    ReadKey();
                    break;
                
                case "S":
                case "s":
                    WriteLine("\n\t\tCalculate area of a Square (all sides a equal)");

                    try {   
                        Write("\t\tSide 1: ");
                        if (!int.TryParse(ReadLine(), out b)) {
                            throw new FormatException();
                        }
                        int s = b * b;
                        WriteLine($"\n\t\tArea is: {s}"); 
                    }

                    catch (FormatException) {
                        WriteLine($"\n\t\tInvalid Input!");
                    }
                    ReadKey();
                    break;
                
                case "C":
                case "c":
                    WriteLine("\n\t\tCalculate area of a Circle (r^2 * pi)");
                    
                    try { 
                        Write("\t\tRadious : ");
                        double radious = Convert.ToDouble(ReadLine());
                        double c = Math.PI * radious * radious;
                        WriteLine($"\n\t\tArea is: {c}");
                    }
                    catch (FormatException) {
                        WriteLine($"\n\t\tInvalid Input!");
                    }
                    ReadKey();
                    break;
                
                case "T":
                case "t":
                    WriteLine("\n\t\tCalculate area of a Triangle (base * height / 2)");
                    try {
                        Write("\t\tBase: ");
                        if (!int.TryParse(ReadLine(), out b)) {
                            throw new FormatException();
                        }
                        Write("\t\tHeight: ");
                        if (!int.TryParse(ReadLine(), out h)) {
                            throw new FormatException();
                        }
                        int t = (b * h) / 2;
                        WriteLine($"\n\t\tArea is: {t}");
                    }
                    catch (FormatException) {
                        WriteLine($"\n\t\tInvalid Input!");
                    }  
                    ReadKey();       
                    break;
                
                case "E":
                case "e":
                    Clear();
                    WriteLine("\n\n\t\t\tGoing back to main menu");
                    ReadKey();
                    shapesLoop = false;
                    break;
                default:
                    WriteLine("\n\n\t\t  Make a choice in the menu or exit ");
                    ReadKey();
                    break;            
            }
        }
    }
}