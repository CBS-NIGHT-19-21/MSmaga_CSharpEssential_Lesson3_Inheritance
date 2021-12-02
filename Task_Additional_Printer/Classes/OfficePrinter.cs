// Instance inheritanced class OfficePrinter.
class OfficePrinter : Printer
{   // Declare overridden method.  
    public override void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(value);
    }
}

