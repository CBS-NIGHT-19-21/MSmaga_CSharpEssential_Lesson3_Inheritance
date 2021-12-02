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
class GoodPupil : Pupil
{
    // Define the GoodPupil constructor (string name)
    // and call the base constructor: base (name)
    // so that it writes the value of the name parameter
    // to constructor GoodPupil (string name).
    public GoodPupil(string name) : base(name)
    {

    }

    // Define methods as Override to override the methods of the parent class Pupil.
    public override void Study()
    {
        Console.WriteLine("Я учу сразу С#, Java, и конечно же - Python!");
    }

    public override void Read()
    {
        Console.WriteLine("Я читаю статьи на reactor.cc");
    }

    public override void Write()
    {
        Console.WriteLine("Крукожоплю говнокод, педалирую гоутушками прод");
    }

    public override void Relax()
    {
        Console.WriteLine("Я отдыхаю - задротю в CS:GO");
    }

}
