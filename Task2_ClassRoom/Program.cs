#region Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: 
//Создать класс, представляющий учебный класс ClassRoom. 
//Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
//Write(), void Relax(). 
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса 
//Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика. 
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
//писать, отдыхать
#endregion

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

// Instantiate instances of child classes, with an input text field.
ExcellentPupil Pupil1 = new ExcellentPupil("Макс");
GoodPupil Pupil2 = new GoodPupil("Серега");
BadPupil Pupil3 = new BadPupil("Антон");
BadPupil Pupil4 = new BadPupil("Валера");

// Instantiate an instance of the classRoom1,
// pass instances of child classes
// do UpCast in the constructor.
ClassRoom classRoom1 = new(Pupil1, Pupil2, Pupil3, Pupil4);

// Get the class name of the instance classRoom1.
Console.WriteLine(classRoom1.GetType());

Console.WriteLine(new String('=', 45));

// Get the class name of the Pupil1 field of the classRoom1 object
// and the value of its textbox as a Pupil1 object.
Console.WriteLine("{0}: {1}", classRoom1.Pupil1.GetType(), classRoom1.Pupil1.name);

Console.WriteLine(new String('=', 45));

// Works as an overridden override method
// from the ExcelentPupil child class.
classRoom1.Pupil1.Study();
classRoom1.Pupil1.Read();
classRoom1.Pupil1.Write();

// Works like a native virtual method of the parent Pupil class
classRoom1.Pupil1.Relax();

Console.WriteLine();

// Get the class name of the Pupil2 field of the classRoom1 object
// and the value of its textbox as a Pupil2 object.
Console.WriteLine("{0}: {1}", classRoom1.Pupil2.GetType(), classRoom1.Pupil2.name);
Console.WriteLine(new String('=', 45));

// Works as an overridden override method
// from the ExcelentPupil child class.
classRoom1.Pupil2.Study();
classRoom1.Pupil2.Read();
classRoom1.Pupil2.Write();

// Works like a native virtual method of the parent Pupil class
classRoom1.Pupil2.Relax();

// Get the class name of the Pupil3 field of the classRoom1 object
// and the value of its textbox as a Pupil3 object.
Console.WriteLine("{0}: {1}", classRoom1.Pupil3.GetType(), classRoom1.Pupil3.name);
Console.WriteLine(new String('=', 45));

// Works as an overridden override method
// from the ExcelentPupil child class.
classRoom1.Pupil3.Study();
classRoom1.Pupil3.Read();
classRoom1.Pupil3.Write();

// Works like a native virtual method of the parent Pupil class
classRoom1.Pupil3.Relax();

// Get the class name of the Pupil4 field of the classRoom1 object
// and the value of its textbox as a Pupil4 object.
Console.WriteLine("{0}: {1}", classRoom1.Pupil4.GetType(), classRoom1.Pupil4.name);
Console.WriteLine(new String('=', 45));

// Works as an overridden override method
// from the ExcelentPupil child class.
classRoom1.Pupil4.Study();
classRoom1.Pupil4.Read();
classRoom1.Pupil4.Write();

// Works like a native virtual method of the parent Pupil class
classRoom1.Pupil4.Relax();

Console.ReadKey();