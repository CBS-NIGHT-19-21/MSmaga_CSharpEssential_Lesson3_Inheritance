#region Задание 3
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Требуется: 
// Создать класс Vehicle. 
// В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год 
// выпуска). 
// Создайте 3 производных класса Plane, Саг и Ship. 
// Для класса Plane должна быть определена высота и количество пассажиров. 
// Для класса Ship — количество пассажиров и порт приписки. 
// Написать программу, которая выводит на экран информацию о каждом средстве передвижения. 
#endregion

// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields.

// Declaration of the Methods-fields to access to fields of the object.
// This is contrary to encapsulation!!!

// Create an instance of the parent Vehicle class.
Vehicle vehicle = new Vehicle(latitude: 113, longitude: 119, velocity: 23, price: 1319, yearIssue: 2013);

// Call the virtual method of the parent Vehicle class object.
vehicle.Show();

// Create an instance of the child class Car, specifying the names of the formal parameters.
Car car = new Car(latitude: 103, longitude: 109, velocity: 13, price: 2219, yearIssue: 2017);

// Call the overridden method of the child class Car.
car.Show();

// Create an instance of the Ship child class, specifying the names of the formal parameters in a random sequence.
// Formal parameters of the parent class constructor are passed to the child class constructor.
Ship ship = new Ship(numPassengers: 117, latitude: 53, yearIssue: 2013, longitude: 49, portDocker: "Golway",
                     velocity: 23, price: 1319);

// Call the overridden method of the Ship child class.
ship.Show();

Plane plane = new Plane(3, 18, 98, 8, 172, 1987, 34572);

// Call the overridden method of the child class Plane.
plane.Show();

//Dalay
Console.ReadKey();