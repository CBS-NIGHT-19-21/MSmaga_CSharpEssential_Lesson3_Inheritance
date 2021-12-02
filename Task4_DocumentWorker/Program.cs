#region Задание 4
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Требуется: 
// Создайте класс DocumentWorker. 
// В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
// В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
// "Редактирование документа доступно в версии Про", "Сохранение документа доступно в 
// версии Про". 
// Создайте производный класс ProDocumentWorker. 
// Переопределите соответствующие методы, при переопределении методов выводите следующие строки: 
// "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных 
// форматах доступно в версии Эксперт".
// Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker. 
// Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран
// "Документ сохранен в новом формате".
// В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. 
// Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается 
// экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен 
// создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.
#endregion

// !!!Realize the Object-oriented programming principle - Encapsulation( hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields

// UpCast - Converting the type of an object instance
// from a child class to a parent class with overriding methods(functionality).

// Declare the document object of the DocumentWorker class.
DocumentWorker document;

// Get the key.
Console.WriteLine("Ввeдите ключ:");
string? key = Console.ReadLine();

// Selection depending on the key value.
switch (key)
{
    case "pro":
        // Construct a ProDocumentWorker object and UpCast to the DocumentWorker type.
        document = new ProDocumentWorker();
        break;

    case "exp":
        // Construct an ExpertDocumentWorker object and UpCast to the DocumentWorker type.
        document = new ExpertDocumentWorker();
        break;

    default:
        // Construct an ExpertDocumentWorker object and UpCast to the DocumentWorker type.
        document = new DocumentWorker();
        break;

}

// Using overridden methods.
document.OpenDocument();

document.EditDocument();

document.SaveDocument();

Console.ReadKey();
