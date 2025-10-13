class Sample
// rule 1 is for every method to always be inside a class 
// every c sharp program must have a class
{
    static void Main()
    {
        // static = main method can be called without creating any objects for the class 
        System.Console.WriteLine("Hello Yasmin");
        System.Console.ReadKey();
        
        // Console is a static class in the "System" namespace which provides methods to perform i/o operations 
        // in console applications 
        // e.g. interact with user, read inputs and outputs to user 
        
        // main members of Console :

        Console.Write("Write to output, good if want to write strings side by side ");
        Console.WriteLine("Also writes to output but moves cursor to the next line, so prints line by line");
        Console.ReadKey(); // Useful if you want to make the console window wait rather close abruptly
        Console.Clear(); //clears the console window. After clearing,you can display output again using Write() or WriteLine()
        Console.ReadLine(); // Used to accept input from the user. Returns string always , regardless what the user inputs

    }
}

