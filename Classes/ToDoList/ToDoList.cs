class ToDoList { 
    public static List<string> entries = [];
    public static void ToDO() { 
        
        bool toDoLoop = true;
        while (toDoLoop) {
            Clear(); 
            WriteLine($"");
            for (int i = 0; i < entries.Count; i++) {
                WriteLine($"\t\tTo Do {i + 1}: {entries[i]}");
            }
            Write("\n\t\t[N]ew Entry\t[R]emove\t[E]xit\t");

            string? userChoice = ReadLine();
            switch (userChoice)
            {
                case "n":
                case "N":
                    Entry.NewEntry();
                    break;

                case "r":
                case "R":
                    Delete.RemoveEntry();
                    break;

                case "e":
                case "E":
                    Clear();
                    WriteLine("\n\n\t\tClosing To Do List!");
                    toDoLoop = false;
                    break;

                default:
                    Clear();
                    WriteLine("\n\t\tInvalid Entry!");
                    break;
            }
        }
        ReadKey();
    }
    
}
class Entry {
    public static void NewEntry() { 
        Write("\n\t\tAdd New Entry: ");

        string? newEntry = ReadLine();
        if (!string.IsNullOrWhiteSpace(newEntry)) {
            ToDoList.entries.Add(newEntry);
        }
        else 
            WriteLine("\n\t\tEntries can't be null!");

    }
}

class Delete { 
    public static void RemoveEntry() {
        WriteLine(" ");
        for (int i = 0; i < ToDoList.entries.Count; i++) {
        WriteLine($"\t\t[{i}] {ToDoList.entries[i]}");
        }
        Write("\n\t\tWhat entry would you like to remove? ");

        try {

            if (int.TryParse(ReadLine(), out int removeTask)) { 

                if (removeTask >= 0 && removeTask < ToDoList.entries.Count) {

                    ToDoList.entries.RemoveAt(removeTask); 
                }
                else {
                    WriteLine("\n\t\tInvalid entry index. Please choose a valid index.");
                    ReadKey();
                }
            }
            else {
                WriteLine("\n\t\tInvalid input. Please enter a number.");
                    ReadKey();
            }
        }
        catch (Exception ex) {
            WriteLine($"\n\n\t\t{ex}");
        }

    }
}