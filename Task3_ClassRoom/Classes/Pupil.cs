// !!!Realize the Object-oriented programming principle - Encapsulation( hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields

// !!!Implement a way to organize interaction between classes - Aggregation : Association HAS A.
// Aggregation : Association - an object of a class is passed as a parameter
// to the constructor of another class.

// UpCast - Converting the type of an object instance
// from a child class to a parent class with overriding methods(functionality).
class Pupil
{   // Declare an public field.
    public string name = string.Empty;

    // Declare a class constructor.
    public Pupil()
    {

    }
    // Declare a class constructor with an input parameter.
    public Pupil(string name)
    {
        this.name = name;
    }

    // Define Virtual Methods to be able to change
    // the functionality of the methods in the inherited class.
    public virtual void Study()
    {
        Console.WriteLine("Ну... я учу то, что задают");
    }

    public virtual void Read()
    {
        Console.WriteLine("Ну...читаю книжки всякие там");
    }

    public virtual void Write()
    {
        Console.WriteLine("Пишу? Нет. Я в лифте не пишу.");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Я отдыхаю в спортзале");
    }
}
