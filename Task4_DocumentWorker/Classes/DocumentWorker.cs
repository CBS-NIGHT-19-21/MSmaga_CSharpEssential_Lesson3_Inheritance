// !!!Realize the Object-oriented programming principle - Encapsulation( hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields

// UpCast - Converting the type of an object instance
// from a child class to a parent class with overriding methods(functionality).
class DocumentWorker
{
    // Declarate a concrete method - override is impossible.
    public void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }
    // Declarate a virtual method - for possible override.
    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Про");
    }
    // Declarate a virtual method - for possible override.
    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Про");
    }
}
