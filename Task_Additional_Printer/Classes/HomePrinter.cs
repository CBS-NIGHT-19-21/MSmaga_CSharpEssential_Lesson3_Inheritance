// Instance inheritanced class HomePrinter.
class HomePrinter : Printer
{    // Declare overridden method.  
    public override void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(value);
    }
}
