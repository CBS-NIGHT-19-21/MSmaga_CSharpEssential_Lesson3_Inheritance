#region Задание Дополнительное
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Требуется: 
// Создайте класс Printer. 
// В теле класса создайте метод void Print(string value), который выводит на экран значение 
// аргумента. 
// Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове 
// соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
// выводились разными цветами. 
// Обязательно используйте приведение типов.
#endregion 

string str = "A wiki is essentially a database for creating, browsing, and searching through information.";

// Instance class Printer.
Printer printer = new Printer();
// Call virtual method of class Printer.
printer.Print(str);

// Instance inheritanced class OfficePrinter.
OfficePrinter officePrinter = new OfficePrinter();
// Call overridden method of class Printer.
officePrinter.Print(str);

// Instance inheritanced class HomePrinter.
HomePrinter homePrinter = new HomePrinter();
// Call overridden method of class Printer.
homePrinter.Print(str);